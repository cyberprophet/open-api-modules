using Microsoft.AspNetCore.SignalR.Client;

using Newtonsoft.Json;

using ShareInvest.Entities.Kiwoom;
using ShareInvest.Observers;
using ShareInvest.OpenAPI.Entity;
using ShareInvest.Utilities;

using System.Collections.Concurrent;
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
                    case nameof(Transmission.Opt50068):
                        LookupDailyChart(code);
                        break;

                    case nameof(Transmission.Opt10080):
                    case nameof(Transmission.Opt50029):
                    case nameof(Transmission.Opt50067):
                        LookupMinuteChart(code);
                        break;

                    case nameof(Transmission.Opt10004):
                        LookupStockQuote(code);
                        break;
                }

                if (code.Length == 6)
                {
                    foreach (var fs in await FinancialSummary.ExecuteAsync(code))
                    {
                        fs.Code = code;
                        fs.Date = fs.ReceiveDate?[..7].Replace('.', '-');
                        fs.Estimated = fs.ReceiveDate?[^2] == 'E';

                        _ = await Talk.ExecutePostAsync(fs);
                    }
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
                        return await RequestTransmissionAsync(nameof(Transmission.Opt50068));

                    case nameof(Transmission.Opt50029):
                        return await RequestTransmissionAsync(nameof(Transmission.Opt50067));

                    case nameof(Transmission.Opt50067):
                        return await RequestTransmissionAsync(nameof(Transmission.Opt10080));

                    case nameof(Transmission.Opt50068):
                        return await RequestTransmissionAsync(nameof(Transmission.Opt50029));
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

    void OnReceiveMessage(object? sender, MsgEventArgs e)
    {
        _ = BeginInvoke(async () =>
        {
            await (e switch
            {
                RealMsgEventArgs rMsg => OnReceiveMessage(rMsg),

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
    readonly ConcurrentQueue<Entities.Kiwoom.Opt50067> opt50067Collection = new();
    readonly ConcurrentQueue<Entities.Kiwoom.Opt50068> opt50068Collection = new();
}