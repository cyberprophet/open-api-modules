﻿using Microsoft.AspNetCore.SignalR.Client;

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
                            OriginalOrderNumber = e.Data["원주문번호"],
                            OrderStatus = (OrderStatus)Convert.ToInt32(e.Data["매도수구분"]),
                            OrderQuantity = Convert.ToInt32(e.Data["주문수량"]),
                            UntradedQuantity = Convert.ToInt32(e.Data["미체결수량"]),
                            OrderPrice = Convert.ToDecimal(e.Data["주문가격"]),
                            Code = e.Data["종목코드_업종코드"],
                            Tax = Convert.ToInt32(e.Data["당일매매세금"]),
                            TradingFee = Convert.ToInt32(e.Data["당일매매수수료"]),
                            UnitContractAmount = Convert.ToInt32(e.Data["단위체결량"]),
                            UnitContractPrice = Convert.ToDecimal(e.Data["단위체결가"])
                        };
                        break;

                    case OrderState.체결 when Convert.ToInt32(e.Data["미체결수량"]) is int untradedQuantity && untradedQuantity != 0:

                        if (conclusion.TryGetValue(e.Data["주문번호"], out var c))
                        {
                            c.Tax = Convert.ToInt32(e.Data["당일매매세금"]);
                            c.TradingFee = Convert.ToInt32(e.Data["당일매매수수료"]);
                            c.UnitContractAmount = Convert.ToInt32(e.Data["단위체결량"]);
                            c.UnitContractPrice = Convert.ToDecimal(e.Data["단위체결가"]);
                            c.UntradedQuantity = untradedQuantity;
                        }
                        break;

                    case OrderState.체결 or OrderState.취소:
                        _ = conclusion.TryRemove(e.Data["주문번호"], out var _);
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
                        TradingProfit = Convert.ToInt64(e.Data["당일총매도손익"])
                    };
                }
                break;
        }
        await saveChanges;
    }
}