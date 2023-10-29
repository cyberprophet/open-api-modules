using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵잔고상세현황합계</summary>
public class SingleOpw20006
{
    /// <summary>선물매도수량</summary>
    [DataMember, JsonProperty("선물매도수량")]
    public string? ForwardSellingQuantity
    {
        get; set;
    }
    /// <summary>선물매수수량</summary>
    [DataMember, JsonProperty("선물매수수량")]
    public string? ForwardPurchaseQuantity
    {
        get; set;
    }
    /// <summary>콜매도수량</summary>
    [DataMember, JsonProperty("콜매도수량")]
    public string? CallSellingQuantity
    {
        get; set;
    }
    /// <summary>콜매수수량</summary>
    [DataMember, JsonProperty("콜매수수량")]
    public string? CallPurchaseQuantity
    {
        get; set;
    }
    /// <summary>풋매도수량</summary>
    [DataMember, JsonProperty("풋매도수량")]
    public string? FootSellingQuantity
    {
        get; set;
    }
    /// <summary>풋매수수량</summary>
    [DataMember, JsonProperty("풋매수수량")]
    public string? AmountOfPutPurchased
    {
        get; set;
    }
    /// <summary>선물매도금액</summary>
    [DataMember, JsonProperty("선물매도금액")]
    public string? ForwardSellingAmount
    {
        get; set;
    }
    /// <summary>선물매수금액</summary>
    [DataMember, JsonProperty("선물매수금액")]
    public string? FuturesPurchaseAmount
    {
        get; set;
    }
    /// <summary>콜매도금액</summary>
    [DataMember, JsonProperty("콜매도금액")]
    public string? CallSellingAmount
    {
        get; set;
    }
    /// <summary>콜매수금액</summary>
    [DataMember, JsonProperty("콜매수금액")]
    public string? CallPurchaseAmount
    {
        get; set;
    }
    /// <summary>풋매도금액</summary>
    [DataMember, JsonProperty("풋매도금액")]
    public string? PutSalesAmount
    {
        get; set;
    }
    /// <summary>풋매수금액</summary>
    [DataMember, JsonProperty("풋매수금액")]
    public string? AmountOfFootSalesCollection
    {
        get; set;
    }
    /// <summary>약정합계</summary>
    [DataMember, JsonProperty("약정합계")]
    public string? AgreedSum
    {
        get; set;
    }
    /// <summary>손익합계</summary>
    [DataMember, JsonProperty("손익합계")]
    public string? TotalProfitAndLoss
    {
        get; set;
    }
    /// <summary>조회건수</summary>
    [DataMember, JsonProperty("조회건수")]
    public string? NumberOfInquiries
    {
        get; set;
    }
}