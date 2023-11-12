using Microsoft.AspNetCore.SignalR.Client;

using Newtonsoft.Json.Linq;

using ShareInvest.Observers;
using ShareInvest.OpenAPI.Entity;
using ShareInvest.Properties;

using System.Net;

namespace ShareInvest;

partial class AnTalk
{
    async Task<int> RequestTransmission(string resource)
    {
        if (Talk == null)
        {
            return int.MaxValue;
        }
        var response = await Talk.ExecuteGetAsync(resource);

        if (HttpStatusCode.OK == response.StatusCode && response.Content?.Replace("\"", string.Empty) is string code)
        {
            var tr = code.Length switch
            {
                6 => new Opt10081
                {
                    Value = new[]
                    {
                        code,
                        DateTime.Now.ToString("yyyyMMdd"),
                        "1"
                    },
                    PrevNext = 0
                },
                _ => null
            };
            axAPI.CommRqData(tr);
        }
        return 0x259;
    }
    async Task OccursDependingOnConnection(Exception? exception)
    {
        if (Talk != null && exception != null)
        {
            _ = await Talk.ExecutePostAsync(new Entities.Kiwoom.OpenMessage
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
        if (IsAdministrator && HubConnectionState.Connected == Socket?.Hub.State)
        {
            await Socket.Hub.SendAsync(e.Type, e.Key, e.Data);
        }
        if (Resources.OPERATION.Equals(e.Type))
        {
            var marketOperation = Operation.Get(e.Data.Split('\t')[0]);

            Delay.Instance.Milliseconds = marketOperation switch
            {
                MarketOperation.장시작 => 0xC9,

                MarketOperation.장마감 => await RequestTransmission(nameof(Opt10081)),

                _ => 0x259
            };
            notifyIcon.Text = $"{DateTime.Now:G}\n{Enum.GetName(marketOperation)}";
        }
    }
    async Task OnReceiveMessage(AxMsgEventArgs e)
    {
        if (Talk != null)
        {
            e.Message.SerialKey = serialKey;

            _ = await Talk.ExecutePostAsync(e.Message);
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
            return;
        }
        switch (e.Securities.AccNo[^2..].CompareTo("31"))
        {
            case < 0:
                axAPI.CommRqData(new OPW00004
                {
                    Value = new[] { e.Securities.AccNo, string.Empty, "0", "00" },
                    PrevNext = 0
                });
                axAPI.CommRqData(new Opw00005
                {
                    Value = new[] { e.Securities.AccNo, string.Empty, "00" },
                    PrevNext = 0
                });
                break;

            case 0:

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

            case Entities.Kiwoom.OPTKWFID o when IsAdministrator is false:

                if (TrConstructor.EventOccursInStock(o.Current) is false)
                {
                    return;
                }
                var resource = string.Concat(nameof(Opt10081), '/', nameof(TrConstructor.EventOccursInStock));

                var response = await Talk!.ExecuteGetAsync(resource, JToken.FromObject(new
                {
                    code = o.Code,
                    price = char.IsDigit(o.Current![0]) ? o.Current : o.Current[1..]
                }));
                if (HttpStatusCode.OK == response.StatusCode)
                {
                    axAPI.CommRqData(new Opt10081
                    {
                        Value = new[]
                        {
                            o.Code!,
                            DateTime.Now.ToString("yyyyMMdd"),
                            "1"
                        },
                        PrevNext = 0
                    });
                }
                return;

            case null:

                return;
        }
        _ = await Talk!.ExecutePostAsync(e.Convey);
    }
    async Task OnReceiveMessage(TransmissionEventArgs e)
    {
        switch (e.Transmission)
        {
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
        Delay.Instance.Milliseconds = await RequestTransmission(e.Transmission.TrCode);
    }
    void OnReceiveMessage(object? sender, MsgEventArgs e)
    {
        _ = BeginInvoke(async () =>
        {
            await (e switch
            {
                RealMsgEventArgs rMsg => OnReceiveMessage(rMsg),

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
    readonly Func<Entities.Kiwoom.OpenMessage, string> convertMsg = arg =>
    {
        var msg = $"{DateTime.Now:G}\n[{arg.Code}] {arg.Title}({arg.Screen})";

        return msg.Length < 0x40 ? msg : $"[{arg.Code}] {arg.Title}({arg.Screen})";
    };
    readonly string[] critCodes = new[]
    {
        "0100",
        "0106"
    };
    readonly CoreWebView webView = new();
    readonly Queue<MultiOpt10081> opt10081Collection = new();
}