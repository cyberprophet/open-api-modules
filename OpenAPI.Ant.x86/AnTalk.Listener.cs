using Microsoft.AspNetCore.SignalR.Client;

using Newtonsoft.Json;

using ShareInvest.Entities.Kiwoom;
using ShareInvest.Observers;
using ShareInvest.OpenAPI.Entity;
using ShareInvest.Properties;

using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net;

namespace ShareInvest;

partial class AnTalk
{
    async Task<int> RequestTransmissionAsync(string resource)
    {
        if (Talk == null)
        {
            return int.MaxValue;
        }
        var response = await Talk.ExecuteGetAsync(resource);

        switch (response.StatusCode)
        {
            case HttpStatusCode.OK when response.Content?.Replace("\"", string.Empty) is string code:

                switch (resource)
                {
                    case nameof(Transmission.Opt10081):
                    case nameof(Transmission.Opt50030):
                        LookupDailyChart(code);
                        break;

                    case nameof(Transmission.Opt10080):
                    case nameof(Transmission.Opt50029):
                        LookupMinuteChart(code);
                        break;

                    case nameof(Transmission.Opt10004):
                        LookupStockQuote(code);
                        break;
                }
                break;

            case HttpStatusCode.NotFound:

                switch (resource)
                {
                    case nameof(Transmission.Opt10081):
                        return await RequestTransmissionAsync(nameof(Transmission.Opt10004));

                    case nameof(Transmission.Opt10004):
                        return await RequestTransmissionAsync(nameof(Transmission.Opt50030));

                    case nameof(Transmission.Opt50030):
                        return await RequestTransmissionAsync(nameof(Transmission.Opt50029));

                    case nameof(Transmission.Opt50029):
                        return await RequestTransmissionAsync(nameof(Transmission.Opt10080));
                }
                break;
        }
        return 0x259;
    }
    async Task OccursDependingOnConnection(Exception? exception)
    {
        if (Talk != null && exception != null)
        {
            _ = await Talk.ExecutePostAsync(new OpenMessage
            {
                Screen = $"{(Socket != null ? (int)Socket.Hub.State : 0):D4}",
                Code = Socket?.Hub.State.ToString(),
                Title = exception.Message,
                Lookup = DateTime.Now.Ticks,
                SerialKey = serialKey
            });
            _ = BeginInvoke(Dispose);
        }
        notifyIcon.Text = $"{DateTime.Now:g}\n[{Socket?.Hub.State}] {exception?.Message ?? string.Empty}";
    }
    async Task OnReceiveMessage(RealMsgEventArgs e)
    {
#if DEBUG
        if (!Array.Exists(realTypes, match => match.Equals(e.Type)))
        {
            Debug.WriteLine(new
            {
                e.Type,
                e.Key,
                e.Data.Split('\t').Length,
                e.Data
            });
        }
#endif
        if (IsAdministrator && HubConnectionState.Connected == Socket?.Hub.State)
        {
            await Socket.Hub.SendAsync(e.Type, e.Key, e.Data);
        }
        if (Resources.OPERATION.Equals(e.Type))
        {
            var marketOperation = Operation.Get(e.Data.Split('\t')[0]);

            Delay.Instance.Milliseconds = marketOperation switch
            {
                MarketOperation.장시작 => worksWithMarketOperation(),

                MarketOperation.장마감 => await RequestTransmissionAsync(nameof(Opt10081)),

                _ => 0x259
            };
            Cache.MarketOperation = marketOperation;

            notifyIcon.Text = $"{DateTime.Now:G}\n{Enum.GetName(marketOperation)}";
        }
    }
    async Task OnReceiveMessage(AxMsgEventArgs e)
    {
        if (Socket != null)
        {
            e.Message.SerialKey = serialKey;

            await Socket.Hub.SendAsync(e.Message.GetType().Name, JsonConvert.SerializeObject(e.Message));
        }
        if (Array.Exists(critCodes, match => match.Equals(e.Message.Screen)))
        {
            _ = BeginInvoke(Dispose);
        }
        notifyIcon.Text = convertMsg(e.Message);
    }
    async Task OnReceiveMessage(SecuritiesEventArgs e)
    {
        e.Securities.SerialKey = serialKey;

        if (string.IsNullOrEmpty(e.Securities.AccNo))
        {
            var now = DateTime.Now;

            Request.IsUsingHoursUnit = now.DayOfWeek switch
            {
                DayOfWeek.Sunday or DayOfWeek.Saturday => true,

                _ => now.Hour < 7 || now.Hour >= 15 && now.Minute > 30 || now.Hour > 15
            };
            if (string.IsNullOrEmpty(e.Securities.MacAddress) is false && Request.IsUsingHoursUnit)
            {
                await RequestTransmissionAsync(nameof(Opt10081));
            }
            return;
        }
        switch (e.Securities.AccNo[^2..].CompareTo("31"))
        {
            case < 0:

                if (await webView.GetCoordinatesAsync() is Entities.Google.Maps.Coordinate crd)
                {
                    _ = await Talk!.ExecutePostAsync(new Entities.Position
                    {
                        Latitude = crd.Lat,
                        Longitude = crd.Lng,
                        MacAddress = Service.GetMacAddress(),
                        SerialKey = serialKey
                    });
                }
                CheckOneSAccount(e.Securities.AccNo);
                break;

            case 0:
                CheckOneSAccount(e.Securities.AccNo);
                break;
        }
        _ = await Talk!.ExecutePostAsync(e.Securities);
    }
    async Task OnReceiveMessage(JsonMsgEventArgs e)
    {
        switch (e.Convey)
        {
            case MultiOpt10081 dailyChart:
                opt10081Collection.Enqueue(dailyChart);
                return;

            case Entities.Kiwoom.Opt10080 minuteChart:
                opt10080Collection.Enqueue(minuteChart);
                return;

            case Entities.Kiwoom.Opt50029 futureMinChart:
                opt50029Collection.Enqueue(futureMinChart);
                return;

            case Entities.Kiwoom.Opt50030 futureDayChart:
                opt50030Collection.Enqueue(futureDayChart);
                return;

            case Entities.Kiwoom.OPTKWFID o when IsAdministrator is false:

                if (TrConstructor.EventOccursInStock(o.Current) is false)
                {
                    return;
                }
                await Socket!.Hub.SendAsync(nameof(TrConstructor.EventOccursInStock), o.Code, char.IsDigit(o.Current![0]) ? o.Current : o.Current[1..]);
                return;

            case Entities.Kiwoom.Opt10004:
                _ = await RequestTransmissionAsync(e.Convey.GetType().Name);
                break;

            case Entities.Kiwoom.Opt50001 or null:

                return;
        }
        _ = await Talk!.ExecutePostAsync(e.Convey);
    }
    async Task OnReceiveMessage(TransmissionEventArgs e)
    {
        switch (e.Transmission)
        {
            case OpenAPI.Entity.Opt50029 when Talk != null:

                if (opt50029Collection.IsEmpty is false)
                {
                    var response = await Talk.ExecutePostAsync(e.Transmission.TrCode, opt50029Collection);

                    var positive = int.TryParse(response.Content?.Replace("\"", string.Empty), out int saveChanges);

                    if (HttpStatusCode.OK != response.StatusCode || positive && saveChanges != opt50029Collection.Count)
                    {
                        e.Transmission.PrevNext = 0;
                    }
                    opt50029Collection.Clear();
                }
                break;

            case OpenAPI.Entity.Opt10080 when Talk != null:

                if (opt10080Collection.IsEmpty is false)
                {
                    var response = await Talk.ExecutePostAsync(e.Transmission.TrCode, opt10080Collection);

                    var positive = int.TryParse(response.Content?.Replace("\"", string.Empty), out int saveChanges);

                    if (HttpStatusCode.OK != response.StatusCode || positive && saveChanges != opt10080Collection.Count)
                    {
                        e.Transmission.PrevNext = 0;
                    }
                    opt10080Collection.Clear();
                }
                break;

            case OpenAPI.Entity.Opt50030 when Talk != null:

                while (opt50030Collection.TryDequeue(out var collection))
                {
                    var response = await Talk.ExecutePostAsync(e.Transmission.TrCode, collection);

                    var positive = int.TryParse(response.Content?.Replace("\"", string.Empty), out int saveChanges);

                    if (HttpStatusCode.OK == response.StatusCode && positive && saveChanges > 0)
                    {
                        continue;
                    }
                    opt50030Collection.Clear();

                    e.Transmission.PrevNext = opt50030Collection.Count;
                }
                break;

            case Opt10081 when Talk != null:

                while (opt10081Collection.TryDequeue(out var collection))
                {
                    var response = await Talk.ExecutePostAsync(e.Transmission.TrCode, collection);

                    var positive = int.TryParse(response.Content?.Replace("\"", string.Empty), out int saveChanges);

                    if (HttpStatusCode.OK == response.StatusCode && positive && saveChanges > 0)
                    {
                        continue;
                    }
                    opt10081Collection.Clear();

                    e.Transmission.PrevNext = opt10081Collection.Count;
                }
                break;
        }
        if (e.Transmission.PrevNext == 2)
        {
            axAPI.CommRqData(e.Transmission);

            return;
        }
        switch (e.Transmission)
        {
            case OpenAPI.Entity.Opt10080:
            case OpenAPI.Entity.Opt50029:
            case OpenAPI.Entity.Opt50030:

                break;

            case Opt10081 when DateTime.Now.ToString("yyyyMMdd").Equals(e.Transmission.Value?[1]):

                break;

            default:

                return;
        }
        Delay.Instance.Milliseconds = await RequestTransmissionAsync(e.Transmission.TrCode);
    }
    async Task OnReceiveMessage(ChejanEventArgs e)
    {
        if (e.Convey is Chejan chejan && Talk != null)
        {
            chejan.Lookup = DateTime.Now.Ticks;

            _ = await Talk.ExecutePostAsync(e.Convey);
        }
    }
    async Task OnReceiveMessage(TrMsgEventArgs e)
    {
        if (Socket != null)
        {
            await Socket.Hub.SendAsync(e.HubMethodName, e.Json);
        }
    }
    void OnReceiveMessage(object? sender, MsgEventArgs e)
    {
        _ = BeginInvoke(async () =>
        {
            await (e switch
            {
                RealMsgEventArgs rMsg => OnReceiveMessage(rMsg),

                TrMsgEventArgs cMsg => OnReceiveMessage(cMsg),

                ChejanEventArgs cjMsg => OnReceiveMessage(cjMsg),

                JsonMsgEventArgs json => OnReceiveMessage(json),

                AxMsgEventArgs axMsg => OnReceiveMessage(axMsg),

                SecuritiesEventArgs securities => OnReceiveMessage(securities),

                TransmissionEventArgs arg => OnReceiveMessage(arg),

                _ => new Func<Task>(() =>
                {
                    notifyIcon.Text = "Not Supported.";

                    return Task.CompletedTask;
                })()
            });
        });
    }
    readonly Func<int> worksWithMarketOperation = () =>
    {
        var now = DateTime.Now;

        Request.IsUsingHoursUnit = now.DayOfWeek switch
        {
            DayOfWeek.Sunday or DayOfWeek.Saturday => true,

            _ => now.Hour < 8 || now.Hour > 14
        };
        return 0xC9;
    };
    readonly Func<OpenMessage, string> convertMsg = arg =>
    {
        var msg = $"{DateTime.Now:G}\n[{arg.Code}] {arg.Title}({arg.Screen})";

        return msg.Length < 0x40 ? msg : $"[{arg.Code}] {arg.Title}({arg.Screen})";
    };
    readonly string[] critCodes =
    [
        "0100",
        "0106"
    ];
#if DEBUG
    readonly string[] realTypes =
    [
        "주식호가잔량",
        "주식체결",
        "주식우선호가",
        "종목프로그램매매",
        "주식당일거래원",
        "주식예상체결"
    ];
#endif
    readonly CoreWebView webView = new();
    readonly ConcurrentQueue<MultiOpt10081> opt10081Collection = new();
    readonly ConcurrentQueue<Entities.Kiwoom.Opt10080> opt10080Collection = new();
    readonly ConcurrentQueue<Entities.Kiwoom.Opt50029> opt50029Collection = new();
    readonly ConcurrentQueue<Entities.Kiwoom.Opt50030> opt50030Collection = new();
}