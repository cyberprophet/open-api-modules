using Microsoft.AspNetCore.SignalR.Client;

using ShareInvest.Observers;
using ShareInvest.OpenAPI.Entity;
using ShareInvest.Properties;

namespace ShareInvest;

partial class AnTalk
{
    async Task OccursDependingOnConnection(Exception? exception)
    {
        if (Talk != null && exception != null)
        {
            _ = await Talk.ExecuteAsync(new Entities.Kiwoom.OpenMessage
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
        if (Socket != null && HubConnectionState.Connected == Socket.Hub.State)
        {
            await Socket.Hub.SendAsync(e.Type, e.Key, e.Data);
        }
#endif
        if (Resources.OPERATION.Equals(e.Type))
        {
            var marketOperation = Utilities.Kiwoom.Operation.Get(e.Data.Split('\t')[0]);

            Delay.Instance.Milliseconds = marketOperation switch
            {
                Utilities.Kiwoom.MarketOperation.장시작 => 0xC9,

                Utilities.Kiwoom.MarketOperation.장마감 => await worksWithMarketClose(axAPI),

                _ => 0x259
            };
            notifyIcon.Text = $"{DateTime.Now:G}\n{Enum.GetName(marketOperation)}";
        }
    }
    async Task OnReceiveMessage(JsonMsgEventArgs e)
    {
        if (e.Convey == null || Talk == null)
        {
            return;
        }
#if DEBUG
        if (e.Convey is Entities.Kiwoom.OPTKWFID)
        {
            return;
        }
#endif
        _ = await Talk.ExecuteAsync(e.Convey);
    }
    async Task OnReceiveMessage(AxMsgEventArgs e)
    {
        if (Talk != null)
        {
            e.Message.SerialKey = serialKey;

            _ = await Talk.ExecuteAsync(e.Message);
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
        _ = await Talk!.ExecuteAsync(e.Securities);
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

                _ => new Func<Task>(() =>
                {
                    notifyIcon.Text = "Not Supported.";

                    return Task.CompletedTask;
                })()
            });
        });
    }
    readonly Func<AxKH, Task<int>> worksWithMarketClose = axAPI =>
    {
        axAPI.GetCodeListByMarket();

        return Task.FromResult(0x259);
    };
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
}