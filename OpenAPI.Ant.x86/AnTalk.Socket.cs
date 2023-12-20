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
                        LookupDailyChart(stock.Code, -1);
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
            Value = [accNo, string.Empty, "0", "00"]
        });
        axAPI.CommRqData(new Opw00005
        {
            PrevNext = 0,
            Value = [accNo, string.Empty, "00"]
        });
    }
    void LookupDailyChart(string code, int subtract = 0)
    {
        axAPI.CommRqData(new Opt10081
        {
            PrevNext = 0,
            Value = [code, DateTime.Now.AddDays(subtract).ToString("yyyyMMdd"), "1"]
        });
    }
    /// <summary>
    /// 수정주가구분 1:유상증자, 2:무상증자, 4:배당락, 8:액면분할, 16:액면병합, 32:기업합병, 64:감자, 256:권리락
    /// </summary>
    /// <param name="code">종목코드</param>
    /// <param name="tick">1:1분, 3:3분, 5:5분, 10:10분, 15:15분, 30:30분, 45:45분, 60:60분</param>
    void LookupMinuteChart(string code, int tick)
    {
        axAPI.CommRqData(new Opt10080
        {
            PrevNext = 0,
            Value = [code, tick.ToString(), "1"]
        });
    }
    void LookupStockQuote(string code)
    {
        axAPI.CommRqData(new Opt10004 { Value = [code], PrevNext = 0 });
    }
    bool IsAdministrator
    {
        get; set;
    }
}