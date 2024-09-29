using Microsoft.AspNetCore.SignalR.Client;

using ShareInvest.Entities.Assets;
using ShareInvest.Observers;
using ShareInvest.OpenAPI.Entity;

using System.Diagnostics;

namespace ShareInvest;

partial class AnTalk
{
    async Task OnReceiveMessage(JsonMsgEventArgs e)
    {
        switch (e.Convey)
        {
            case BalOPW00004 bpw4 when string.IsNullOrEmpty(bpw4.Code) is false:

                if (this.balance.TryGetValue(bpw4.Code, out var balance))
                {
                    balance.HoldingQuantity = Convert.ToInt32(bpw4.Quantity);
                }
                else
                {
                    this.balance[bpw4.Code] = new OpenAPI.Balance
                    {
                        HoldingQuantity = Convert.ToInt32(bpw4.Quantity),
                        AccNo = bpw4.AccNo
                    };
                }
                break;

            case Entities.Assets.Opw20007 opw207 when string.IsNullOrEmpty(opw207.Code) is false:

                if (this.balance.TryGetValue(opw207.Code, out var bal))
                {
                    bal.HoldingQuantity = Convert.ToInt32(opw207.Quantity);
                    bal.QuantityAvailableForOrder = Convert.ToInt32(opw207.LiquidationPossibleQuantity);
                }
                else
                {
                    this.balance[opw207.Code] = new OpenAPI.Balance
                    {
                        HoldingQuantity = Convert.ToInt32(opw207.Quantity),
                        QuantityAvailableForOrder = Convert.ToInt32(opw207.LiquidationPossibleQuantity),
                        AccNo = opw207.AccNo
                    };
                }
                break;

            case AccOPW00005 apw5 when string.IsNullOrEmpty(apw5.AccNo) is false:
                account[apw5.AccNo] = new OpenAPI.Account
                {
                    OrderableCash = Convert.ToInt64(apw5.OrderableCash)
                };
                break;

            case Entities.Assets.OPW20010 opw210 when string.IsNullOrEmpty(opw210.AccNo) is false:
                account[opw210.AccNo] = new OpenAPI.Account
                {
                    OrderableCash = Convert.ToInt64(opw210.TotalOrderableAmount)
                };
                break;

            case MultiOpt10081 dailyChart:
                opt10081Collection.Enqueue(dailyChart);
                return;

            case Entities.Kiwoom.Opt10080 minuteChart:
                opt10080Collection.Enqueue(minuteChart);
                return;

            case Entities.Kiwoom.Opt20005 indexMinChart:
                opt20005Collection.Enqueue(indexMinChart);
                return;

            case Entities.Kiwoom.Opt20006 indexDayChart:
                opt20006Collection.Enqueue(indexDayChart);
                return;

            case Entities.Kiwoom.Opt50029 futureMinChart:
                opt50029Collection.Enqueue(futureMinChart);
                return;

            case Entities.Kiwoom.Opt50030 futureDayChart:
                opt50030Collection.Enqueue(futureDayChart);
                return;

            case Entities.Kiwoom.Opt50067 optionMinChart:
                opt50067Collection.Enqueue(optionMinChart);
                return;

            case Entities.Kiwoom.Opt50068 optionDayChart:
                opt50068Collection.Enqueue(optionDayChart);
                return;

            case Entities.Kiwoom.OPTKWFID o when IsAdministrator is false:

                if (TrConstructor.EventOccursInStock(o.Current) is false)
                {
                    return;
                }
                await Socket!.Hub.SendAsync(nameof(TrConstructor.EventOccursInStock), o.Code, char.IsDigit(o.Current![0]) ? o.Current : o.Current[1..]);
                return;

            case Entities.Kiwoom.Opt10003 opt13:
                opt10003Collection.Enqueue(opt13);
                return;

            case Entities.Kiwoom.Opt10004:
                _ = await RequestTransmissionAsync(e.Convey.GetType().Name);
                break;

            case Entities.Kiwoom.OPT20001 opt20001:
#if DEBUG
                Debug.WriteLine(opt20001.Code);
#endif
                return;

            case Entities.Kiwoom.OPT20003 opt20003:
#if DEBUG
                Debug.WriteLine(opt20003.Code);
#endif
                return;

            case Entities.Kiwoom.Opt50001 or null:
                axAPI.CommRqData();
                return;
        }
        _ = await Talk!.ExecutePostAsync(e.Convey);
    }
}