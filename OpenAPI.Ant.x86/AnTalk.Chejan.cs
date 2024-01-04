using Microsoft.AspNetCore.SignalR.Client;

using Newtonsoft.Json;

using ShareInvest.Entities.Kiwoom;
using ShareInvest.Observers;

namespace ShareInvest;

partial class AnTalk
{
    async Task OnReceiveMessage(ChejanEventArgs e)
    {
        var hubMethodName = Enum.GetName(e.Type);

        if (Socket == null || string.IsNullOrEmpty(hubMethodName))
        {
            return;
        }
        var saveChanges = Socket.Hub.SendAsync(hubMethodName, JsonConvert.SerializeObject(e.Data));

        switch (e.Type)
        {
            case ChejanType.주문체결 when Enum.TryParse(e.Data["주문상태"], out OrderState state):

                switch (state)
                {
                    case OrderState.접수:
                        conclusion[e.Data["주문번호"]] = new OpenAPI.Conclusion
                        {
                            OrgOrdNo = e.Data["원주문번호"],
                            OrderStatus = (OrderStatus)Convert.ToInt32(e.Data["매도수구분"]),
                            OrderQuantity = Convert.ToInt32(e.Data["주문수량"]),
                            OrderPrice = Convert.ToDouble(e.Data["주문가격"]),
                            UntradedQuantity = Convert.ToInt32(e.Data["미체결수량"]),
                            TradedClassification = e.Data["매매구분"],
                            Code = e.Data["종목코드_업종코드"],
                            AccNo = e.Data["계좌번호"]
                        };
                        CheckOneSAccount(e.Data["주문업무분류"], e.Data["계좌번호"]);
                        break;

                    case OrderState.체결 when Convert.ToInt32(e.Data["미체결수량"]) is int untradedQuantity:

                        if (untradedQuantity != 0 && conclusion.TryGetValue(e.Data["주문번호"], out var c))
                        {
                            c.UnitContractAmount = Convert.ToInt32(e.Data["단위체결량"]);
                            c.UnitContractPrice = Convert.ToDouble(e.Data["단위체결가"]);
                            c.UntradedQuantity = untradedQuantity;
                        }
                        else
                        {
                            _ = conclusion.TryRemove(e.Data["주문번호"], out var _);
                        }
                        break;

                    case OrderState.취소 when conclusion.TryRemove(e.Data["주문번호"], out var _):
                        CheckOneSAccount(e.Data["주문업무분류"], e.Data["계좌번호"]);
                        break;

                    case OrderState.확인:
                        notifyIcon.Text = convertMsg(new OpenMessage
                        {
                            Code = e.Data["종목코드_업종코드"].Length == 8 ? e.Data["종목코드_업종코드"] : e.Data["종목명"],
                            Title = char.IsSymbol(e.Data["주문구분"][0]) ? e.Data["주문구분"][1..] : e.Data["주문구분"],
                            Screen = e.Data["주문번호"]
                        });
                        break;
                }
                break;

            case ChejanType.잔고 or ChejanType.파생잔고:

                if (this.balance.TryGetValue(e.Data["종목코드_업종코드"], out var balance))
                {
                    balance.HoldingQuantity = Convert.ToInt32(e.Data["보유수량"]);
                    balance.QuantityAvailableForOrder = Convert.ToInt32(e.Data["주문가능수량"]);
                    balance.OrderStatus = (OrderStatus)Convert.ToInt32(e.Data["매도_매수구분"]);
                    balance.TransactionQuantity = Convert.ToInt32(e.Data["당일순매수량"]);
                    balance.TradingProfit = Convert.ToInt64(e.Data["당일총매도손익"]);
                }
                else
                {
                    this.balance[e.Data["종목코드_업종코드"]] = new OpenAPI.Balance
                    {
                        HoldingQuantity = Convert.ToInt32(e.Data["보유수량"]),
                        QuantityAvailableForOrder = Convert.ToInt32(e.Data["주문가능수량"]),
                        OrderStatus = (OrderStatus)Convert.ToInt32(e.Data["매도_매수구분"]),
                        TransactionQuantity = Convert.ToInt32(e.Data["당일순매수량"]),
                        TradingProfit = Convert.ToInt64(e.Data["당일총매도손익"]),
                        AccNo = e.Data["계좌번호"]
                    };
                }
                break;
        }
        await saveChanges;
    }
    void CheckOneSAccount(string orderState, string accNo)
    {
        axAPI.CommRqData(orderState switch
        {
            "JJ" => new OpenAPI.Entity.Opw00005
            {
                Value = [accNo, string.Empty, "00"],
                PrevNext = 0
            },
            "FJ" => new OpenAPI.Entity.OPW20010
            {
                Value = [accNo, string.Empty, "00"],
                PrevNext = 0
            },
            _ => null
        });
    }
}