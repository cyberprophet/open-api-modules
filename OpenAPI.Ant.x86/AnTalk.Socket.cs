using Microsoft.AspNetCore.SignalR.Client;

using Newtonsoft.Json;

using ShareInvest.Hubs.Socket;
using ShareInvest.Observers;
using ShareInvest.OpenAPI.Entity;
using ShareInvest.Properties;
using ShareInvest.RealType;

using System.Collections.Concurrent;
using System.Diagnostics;
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
                    case OrderFOArgs kf when string.IsNullOrEmpty(kf.OrderFO.Strategics) is false:
                        SendOrderFO(kf.OrderFO);
                        return;

                    case RenewBalanceArgs rb:
                        axAPI.CommRqData(new Opw20007
                        {
                            Value = [rb.AccNo, string.Empty, "00"],
                            PrevNext = 0
                        });
                        return;

                    case AssetsEventArgs e:
                        CheckOneSAccount(e.AccNo);
                        return;

                    case OccursInStockEventArgs stock:
                        LookupDailyChart(stock.Code, -1);
                        LookupMinuteChart(stock.Code, 1);
                        return;
                }
            };
            Socket.Hub.Closed += OccursDependingOnConnection;
            Socket.Hub.ServerTimeout = TimeSpan.FromSeconds(0x40);
            Socket.Hub.HandshakeTimeout = TimeSpan.FromSeconds(0x20);

            await Socket.Hub.StartAsync();
        }
    }

    void SendOrderFO(OpenAPI.OrderFO orderFO)
    {
        double price = Convert.ToDouble(orderFO.Price), margin, commission;

        if (string.IsNullOrEmpty(orderFO.AccNo) || this.account.TryGetValue(orderFO.AccNo, out var account) is false)
        {
            return;
        }
        switch (orderFO.Code?[..3])
        {
            case "101":
                margin = price * Service.KospiTransactionMultiplier * Service.KospiConsignmentMarginRate * orderFO.Qty;
                commission = price * Service.KospiTransactionMultiplier * Service.Commission * orderFO.Qty;
                break;

            case "106":
                margin = price * Service.KosdaqTransactionMultiplier * Service.KosdaqConsignmentMarginRate * orderFO.Qty;
                commission = price * Service.KosdaqTransactionMultiplier * Service.Commission * orderFO.Qty;
                break;

            default:
#if DEBUG
                Debug.WriteLine(JsonConvert.SerializeObject(orderFO, Formatting.Indented));
#endif
                return;
        }
        _ = this.balance.TryGetValue(orderFO.Code, out var balance);

        if (commission + margin < account.OrderableCash || balance?.QuantityAvailableForOrder >= orderFO.Qty && (int)balance.OrderStatus != Convert.ToInt32(orderFO.SlbyTp))
        {
            axAPI.SendOrderFO(orderFO);
        }
    }

    void CheckOneSAccount(string accNo)
    {
        if ("31".Equals(accNo[^2..]))
        {
            axAPI.CommRqData(new OPW20010 { Value = [accNo, string.Empty, "00"], PrevNext = 0 });
            axAPI.CommRqData(new Opw20007 { Value = [accNo, string.Empty, "00"], PrevNext = 0 });
        }
        else
        {
            axAPI.CommRqData(new OPW00004 { Value = [accNo, string.Empty, "0", "00"], PrevNext = 0 });
            axAPI.CommRqData(new Opw00005 { Value = [accNo, string.Empty, "00"], PrevNext = 0 });
        }
    }

    void LookupDailyChart(string code, int subtract = 0)
    {
        var now = DateTime.Now;
        var baseDate = now.AddDays(subtract).ToString("yyyyMMdd");

        switch (code.Length)
        {
            case 6:
                axAPI.CommRqData(new Opt10081 { Value = [code, baseDate, "1"], PrevNext = 0 });
                break;

            case 3:
                axAPI.CommRqData(new Opt20006 { Value = [code, baseDate], PrevNext = 0 });
                break;

            case 8:
                TR tr;

                if (axAPI.IsFutures(code))
                {
                    tr = new Opt50030 { Value = [code, baseDate], PrevNext = 0 };
                }
                else
                {
                    var expirationDate = Service.GetSecondThursday(now.Year, now.Month);

                    tr = new Opt50068 { Value = [code, (expirationDate.Day.CompareTo(now.Day) < 0 ? now.AddMonths(1) : now).ToString("yyyyMM")], PrevNext = 0 };
                }
                axAPI.CommRqData(tr);
                break;
        }
    }

    /// <summary>
    /// 수정주가구분 1:유상증자, 2:무상증자, 4:배당락, 8:액면분할, 16:액면병합, 32:기업합병, 64:감자, 256:권리락
    /// </summary>
    /// <param name="code">종목코드</param>
    /// <param name="tick">1:1분, 3:3분, 5:5분, 10:10분, 15:15분, 30:30분, 45:45분, 60:60분</param>
    void LookupMinuteChart(string code, int tick = 1)
    {
        switch (code.Length)
        {
            case 6:
                axAPI.CommRqData(new Opt10080 { Value = [code, tick.ToString(), "1"], PrevNext = 0 });
                break;

            case 3:
                axAPI.CommRqData(new Opt20005 { Value = [code, tick.ToString()], PrevNext = 0 });
                break;

            case 8:
                TR tr;

                if (axAPI.IsFutures(code))
                {
                    tr = new Opt50029 { Value = [code, tick.ToString()], PrevNext = 0 };
                }
                else
                {
                    tr = new Opt50067 { Value = [code, tick.ToString()], PrevNext = 0 };
                }
                axAPI.CommRqData(tr);
                break;
        }
    }

    void LookupStockQuote(string code) => axAPI.CommRqData(new Opt10004 { Value = [code], PrevNext = 0 });

    void LookupStockConclusion(string code) => axAPI.CommRqData(new Opt10003 { Value = [code], PrevNext = 0 });

    bool IsAdministrator
    {
        get; set;
    }

    readonly ConcurrentDictionary<string, OpenAPI.Account> account = new();
    readonly ConcurrentDictionary<string, OpenAPI.Balance> balance = new();
    readonly ConcurrentDictionary<string, OpenAPI.Conclusion> conclusion = new();
    readonly ConcurrentDictionary<string, PriorityQuote> priorityQuote = new();
}