using ShareInvest.Observers;

namespace ShareInvest;

partial class AnTalk
{
    void OnReceiveMessage(object? sender, MsgEventArgs e)
    {

    }
    async Task OccursDependingOnConnection(Exception? exception)
    {

    }
    async Task OnReceiveMessage(RealMsgEventArgs e)
    {

    }
    async Task OnReceiveMessage(JsonMsgEventArgs e)
    {

    }
    async Task OnReceiveMessage(AxMsgEventArgs e)
    {

    }
    async Task OnReceiveMessage(SecuritiesEventArgs e)
    {

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