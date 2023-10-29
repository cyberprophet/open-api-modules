using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵당일매매변동현황</summary>
public class SingleOPW20002
{
    /// <summary>선물수수료</summary>
    [DataMember, JsonProperty("선물수수료")]
    public string? FuturesFee
    {
        get; set;
    }
    /// <summary>옵션수수료</summary>
    [DataMember, JsonProperty("옵션수수료")]
    public string? OptionFee
    {
        get; set;
    }
    /// <summary>주식옵션수수료</summary>
    [DataMember, JsonProperty("주식옵션수수료")]
    public string? StockOptionCommission
    {
        get; set;
    }
    /// <summary>선물매도수량</summary>
    [DataMember, JsonProperty("선물매도수량")]
    public string? ForwardSellingQuantity
    {
        get; set;
    }
    /// <summary>선물매도금액</summary>
    [DataMember, JsonProperty("선물매도금액")]
    public string? ForwardSellingAmount
    {
        get; set;
    }
    /// <summary>선물매도평균가격</summary>
    [DataMember, JsonProperty("선물매도평균가격")]
    public string? AverageSellingPriceOfFutures
    {
        get; set;
    }
    /// <summary>선물매수수량</summary>
    [DataMember, JsonProperty("선물매수수량")]
    public string? ForwardPurchaseQuantity
    {
        get; set;
    }
    /// <summary>선물매수금액</summary>
    [DataMember, JsonProperty("선물매수금액")]
    public string? FuturesPurchaseAmount
    {
        get; set;
    }
    /// <summary>선물매수평균가격</summary>
    [DataMember, JsonProperty("선물매수평균가격")]
    public string? AverageForwardPurchasePriceOfAFuturesPurchase
    {
        get; set;
    }
    /// <summary>선물전매수량</summary>
    [DataMember, JsonProperty("선물전매수량")]
    public string? FuturesSaleQuantity
    {
        get; set;
    }
    /// <summary>선물전매금액</summary>
    [DataMember, JsonProperty("선물전매금액")]
    public string? FuturesSaleAmount
    {
        get; set;
    }
    /// <summary>선물환매수량</summary>
    [DataMember, JsonProperty("선물환매수량")]
    public string? ForwardExchangePurchaseVolume
    {
        get; set;
    }
    /// <summary>선물환매금액</summary>
    [DataMember, JsonProperty("선물환매금액")]
    public string? FuturesRedemptionAmount
    {
        get; set;
    }
    /// <summary>콜매도수량</summary>
    [DataMember, JsonProperty("콜매도수량")]
    public string? CallSellingQuantity
    {
        get; set;
    }
    /// <summary>콜매도금액</summary>
    [DataMember, JsonProperty("콜매도금액")]
    public string? CallSellingAmount
    {
        get; set;
    }
    /// <summary>콜매도평균가격</summary>
    [DataMember, JsonProperty("콜매도평균가격")]
    public string? CallSellingAveragePrice
    {
        get; set;
    }
    /// <summary>콜매수수량</summary>
    [DataMember, JsonProperty("콜매수수량")]
    public string? CallPurchaseQuantity
    {
        get; set;
    }
    /// <summary>콜매수금액</summary>
    [DataMember, JsonProperty("콜매수금액")]
    public string? CallPurchaseAmount
    {
        get; set;
    }
    /// <summary>콜매수평균가격</summary>
    [DataMember, JsonProperty("콜매수평균가격")]
    public string? AverageCallPurchasePrice
    {
        get; set;
    }
    /// <summary>콜전매수량</summary>
    [DataMember, JsonProperty("콜전매수량")]
    public string? CallSaleQuantity
    {
        get; set;
    }
    /// <summary>콜전매금액</summary>
    [DataMember, JsonProperty("콜전매금액")]
    public string? CallResaleAmount
    {
        get; set;
    }
    /// <summary>콜환매수량</summary>
    [DataMember, JsonProperty("콜환매수량")]
    public string? CallRepurchaseQuantity
    {
        get; set;
    }
    /// <summary>콜환매금액</summary>
    [DataMember, JsonProperty("콜환매금액")]
    public string? CallRepurchaseAmount
    {
        get; set;
    }
    /// <summary>풋매도수량</summary>
    [DataMember, JsonProperty("풋매도수량")]
    public string? PutSellingQuantity
    {
        get; set;
    }
    /// <summary>풋매도금액</summary>
    [DataMember, JsonProperty("풋매도금액")]
    public string? PutSalesAmount
    {
        get; set;
    }
    /// <summary>풋매도평균가격</summary>
    [DataMember, JsonProperty("풋매도평균가격")]
    public string? AveragePutSellPrice
    {
        get; set;
    }
    /// <summary>풋매수수량</summary>
    [DataMember, JsonProperty("풋매수수량")]
    public string? AmountOfPutPurchased
    {
        get; set;
    }
    /// <summary>풋매수금액</summary>
    [DataMember, JsonProperty("풋매수금액")]
    public string? AmountOfFootSalesCollection
    {
        get; set;
    }
    /// <summary>풋매수평균가격</summary>
    [DataMember, JsonProperty("풋매수평균가격")]
    public string? AveragePutPurchasePrice
    {
        get; set;
    }
    /// <summary>풋전매수량</summary>
    [DataMember, JsonProperty("풋전매수량")]
    public string? TheAmountOfMoneyBoughtBeforePutting
    {
        get; set;
    }
    /// <summary>풋전매금액</summary>
    [DataMember, JsonProperty("풋전매금액")]
    public string? PutPreSaleAmount
    {
        get; set;
    }
    /// <summary>풋환매수량</summary>
    [DataMember, JsonProperty("풋환매수량")]
    public string? TheAmountOfPutBackPurchases
    {
        get; set;
    }
    /// <summary>풋환매금액</summary>
    [DataMember, JsonProperty("풋환매금액")]
    public string? PutRedemptionAmount
    {
        get; set;
    }
    /// <summary>선물최종매도수량</summary>
    [DataMember, JsonProperty("선물최종매도수량")]
    public string? FuturesFinalSellingVolume
    {
        get; set;
    }
    /// <summary>선물최종매도금액</summary>
    [DataMember, JsonProperty("선물최종매도금액")]
    public string? FinalSellingAmountOfFutures
    {
        get; set;
    }
    /// <summary>선물최종매도평균가격</summary>
    [DataMember, JsonProperty("선물최종매도평균가격")]
    public string? AverageSellingPriceOfFuturesFinalSelling
    {
        get; set;
    }
    /// <summary>선물최종매수수량</summary>
    [DataMember, JsonProperty("선물최종매수수량")]
    public string? FuturesFinalPurchaseQuantity
    {
        get; set;
    }
    /// <summary>선물최종매수금액</summary>
    [DataMember, JsonProperty("선물최종매수금액")]
    public string? FuturesFinalPurchaseAmount
    {
        get; set;
    }
    /// <summary>선물최종매수평균가격</summary>
    [DataMember, JsonProperty("선물최종매수평균가격")]
    public string? AveragePriceOfFuturesFinalPurchase
    {
        get; set;
    }
    /// <summary>콜권리행사수량</summary>
    [DataMember, JsonProperty("콜권리행사수량")]
    public string? CallRightExerciseQuantity
    {
        get; set;
    }
    /// <summary>콜권리행사금액</summary>
    [DataMember, JsonProperty("콜권리행사금액")]
    public string? AmountOfExerciseOfCallRights
    {
        get; set;
    }
    /// <summary>콜권리행사가격</summary>
    [DataMember, JsonProperty("콜권리행사가격")]
    public string? CallRightExercisePrice
    {
        get; set;
    }
    /// <summary>풋권리행사수량</summary>
    [DataMember, JsonProperty("풋권리행사수량")]
    public string? PutRightExerciseQuantity
    {
        get; set;
    }
    /// <summary>풋권리행사금액</summary>
    [DataMember, JsonProperty("풋권리행사금액")]
    public string? AmountOfExerciseOfPutRights
    {
        get; set;
    }
    /// <summary>풋권리행사가격</summary>
    [DataMember, JsonProperty("풋권리행사가격")]
    public string? PutRightsExercise
    {
        get; set;
    }
    /// <summary>콜권리배정수량</summary>
    [DataMember, JsonProperty("콜권리배정수량")]
    public string? CallRightsAllocationQuantity
    {
        get; set;
    }
    /// <summary>콜권리배정금액</summary>
    [DataMember, JsonProperty("콜권리배정금액")]
    public string? CallRightAllocationAmount
    {
        get; set;
    }
    /// <summary>콜권리배정가격</summary>
    [DataMember, JsonProperty("콜권리배정가격")]
    public string? CallRightsAllocationPrice
    {
        get; set;
    }
    /// <summary>풋권리배정수량</summary>
    [DataMember, JsonProperty("풋권리배정수량")]
    public string? PutRightsAllocationQuantity
    {
        get; set;
    }
    /// <summary>풋권리배정금액</summary>
    [DataMember, JsonProperty("풋권리배정금액")]
    public string? PutRightAllocationAmount
    {
        get; set;
    }
    /// <summary>풋권리배정가격</summary>
    [DataMember, JsonProperty("풋권리배정가격")]
    public string? PutRightsAllocationPrice
    {
        get; set;
    }
}