using Microsoft.AspNetCore.SignalR.Client;

using ShareInvest.Hubs.Socket;
using ShareInvest.Observers;
using ShareInvest.OpenAPI.Entity;
using ShareInvest.Properties;

using System.Media;

namespace ShareInvest;

partial class AnTalk
{
    async Task ConnectingAsync(string resource)
    {
        while (Socket is null)
        {
            if (string.IsNullOrEmpty(webView.AccessToken))
            {
                await Task.Delay(0x400);

                continue;
            }
            using (var sp = new SoundPlayer(Resources.MARIO))
            {
                Socket = new KiwoomHub(string.Concat(webView.Url, resource), accessToken: webView.AccessToken, serialKey: serialKey);

                sp.PlaySync();
            }
            break;
        }
        if (HubConnectionState.Disconnected == Socket.Hub.State)
        {
            Socket.Send += (sender, args) =>
            {
                switch (args)
                {
                    case AssetsEventArgs e:
                        CheckOneSAccount(e.AccNo);
                        return;

                    case OccursInStockEventArgs stock:
                        LookupDailyChart(stock.Code);
                        return;
                }
            };
            Socket.Hub.Closed += OccursDependingOnConnection;
            Socket.Hub.ServerTimeout = TimeSpan.FromSeconds(0x40);
            Socket.Hub.HandshakeTimeout = TimeSpan.FromSeconds(0x20);

            await Socket.Hub.StartAsync();
        }
    }
    void CheckOneSAccount(string accNo)
    {
        axAPI.CommRqData(new OPW00004
        {
            PrevNext = 0,
            Value = new[] { accNo, string.Empty, "0", "00" }
        });
        axAPI.CommRqData(new Opw00005
        {
            PrevNext = 0,
            Value = new[] { accNo, string.Empty, "00" }
        });
    }
    void LookupDailyChart(string code)
    {
        axAPI.CommRqData(new Opt10081
        {
            PrevNext = 0,
            Value = new[] { code, DateTime.Now.ToString("yyyyMMdd"), "1" }
        });
    }
    bool IsAdministrator
    {
        get; set;
    }
}