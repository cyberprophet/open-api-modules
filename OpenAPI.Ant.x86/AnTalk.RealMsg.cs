using Microsoft.AspNetCore.SignalR.Client;

using ShareInvest.Observers;
using ShareInvest.OpenAPI.Entity;

using System.Diagnostics;

namespace ShareInvest;

partial class AnTalk
{
    async Task OnReceiveMessage(RealMsgEventArgs e)
    {
        if (IsAdministrator && HubConnectionState.Connected == Socket?.Hub.State)
        {
            await Socket.Hub.SendAsync(e.Type, e.Key, e.Data);
        }

        if (Enum.TryParse(e.Type, out KiwoomRealType type))
        {
            string[] data;

            switch (type)
            {
                case KiwoomRealType.선물시세:

                    data = e.Data.Split('\t');

                    if (priorityQuote.TryGetValue(e.Key, out var q))
                    {
                        q.CurrentPrice = data[1];
                        q.TopPriorityAskPrice = data[4];
                        q.TopPriorityBidPrice = data[5];
                    }
                    else
                    {
                        priorityQuote[e.Key] = new RealType.PriorityQuote
                        {
                            CurrentPrice = data[1],
                            TopPriorityAskPrice = data[4],
                            TopPriorityBidPrice = data[5]
                        };
                    }
                    break;

                case KiwoomRealType.선물호가잔량:

                    data = e.Data.Split('\t');

                    if (priorityQuote.TryGetValue(e.Key, out var qb))
                    {
                        qb.TopPriorityAskPrice = data[1];
                        qb.TopPriorityBidPrice = data[2];
                    }
                    else
                    {
                        priorityQuote[e.Key] = new RealType.PriorityQuote
                        {
                            TopPriorityAskPrice = data[1],
                            TopPriorityBidPrice = data[2]
                        };
                    }
                    break;

                case KiwoomRealType.선물옵션우선호가:

                    data = e.Data.Split('\t');

                    if (priorityQuote.TryGetValue(e.Key, out var tq))
                    {
                        tq.CurrentPrice = data[0];
                        tq.TopPriorityAskPrice = data[1];
                        tq.TopPriorityBidPrice = data[2];
                    }
                    else
                    {
                        priorityQuote[e.Key] = new RealType.PriorityQuote
                        {
                            CurrentPrice = data[0],
                            TopPriorityAskPrice = data[1],
                            TopPriorityBidPrice = data[2]
                        };
                    }
                    break;

                case KiwoomRealType.장시작시간:
                    var marketOperation = Operation.Get(e.Data.Split('\t')[0]);

                    Delay.Instance.Milliseconds = marketOperation switch
                    {
                        MarketOperation.장시작 => worksWithMarketOperation(),

                        MarketOperation.선옵_장마감전_동시호가_시작 => LiquidateInPrinciple(),

                        MarketOperation.장마감 => await RequestTransmissionAsync(nameof(Opt10081)),

                        _ => 0x259
                    };
                    Cache.MarketOperation = marketOperation;

                    notifyIcon.Text = $"{DateTime.Now:G}\n{Enum.GetName(marketOperation)}";
                    break;
            }
        }

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
    }

    int LiquidateInPrinciple()
    {
        foreach (var con in from fc in conclusion
                            where fc.Value.Code?.Length == 0x8 && "시장가".Equals(fc.Value.TradedClassification) is false
                            select new
                            {
                                fc.Value.UntradedQuantity,
                                fc.Value.AccNo,
                                fc.Value.Code,
                                OrgOrdNo = string.IsNullOrEmpty(fc.Value.OrgOrdNo) || fc.Value.OrgOrdNo.All(e => '0'.Equals(e)) ? fc.Key : fc.Value.OrgOrdNo
                            })
        {
            axAPI.SendOrderFO(new OpenAPI.OrderFO
            {
                AccNo = con.AccNo,
                Code = con.Code,
                OrdKind = 3,
                OrgOrdNo = con.OrgOrdNo,
                Qty = con.UntradedQuantity,
                RQName = con.Code
            });
        }

        foreach (var bal in from fb in balance
                            where 0x8 == fb.Key.Length && (fb.Key[0] == '1' || fb.Key[0] == 'A')
                            select new
                            {
                                Code = fb.Key,
                                fb.Value.AccNo,
                                fb.Value.QuantityAvailableForOrder,
                                fb.Value.OrderStatus
                            })
        {
            if (conclusion.Any(e => bal.Code.Equals(e.Value.Code) &&
                                    bal.QuantityAvailableForOrder == e.Value.UntradedQuantity &&
                                    bal.OrderStatus != e.Value.OrderStatus &&
                                    "시장가".Equals(e.Value.TradedClassification)))
            {
                continue;
            }
            axAPI.SendOrderFO(new OpenAPI.OrderFO
            {
                AccNo = bal.AccNo,
                Code = bal.Code,
                OrdTp = "3",
                Price = string.Empty,
                Qty = bal.QuantityAvailableForOrder,
                RQName = bal.Code,
                SlbyTp = OrderStatus.매도 == bal.OrderStatus ? "2" : "1"
            });
        }
        return 0x259;
    }
}