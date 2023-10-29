using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종프로그램</summary>
public class MultiOPT10010
{
    /// <summary>차익위탁매도수량</summary>
    [DataMember, JsonProperty("차익위탁매도수량")]
    public string? ProfitConsignmentSalesQuantity
    {
        get; set;
    }
    /// <summary>차익위탁매도금액</summary>
    [DataMember, JsonProperty("차익위탁매도금액")]
    public string? ProfitConsignmentSellingAmount
    {
        get; set;
    }
    /// <summary>차익위탁매수수량</summary>
    [DataMember, JsonProperty("차익위탁매수수량")]
    public string? ProfitConsignmentPurchaseQuantity
    {
        get; set;
    }
    /// <summary>차익위탁매수금액</summary>
    [DataMember, JsonProperty("차익위탁매수금액")]
    public string? ProfitConsignmentPurchaseAmount
    {
        get; set;
    }
    /// <summary>차익위탁순매수수량</summary>
    [DataMember, JsonProperty("차익위탁순매수수량")]
    public string? NetPurchaseQuantityOfProfitConsignment
    {
        get; set;
    }
    /// <summary>차익위탁순매수금액</summary>
    [DataMember, JsonProperty("차익위탁순매수금액")]
    public string? NetPurchaseAmountOfConsignmentOfProfit
    {
        get; set;
    }
    /// <summary>비차익위탁매도수량</summary>
    [DataMember, JsonProperty("비차익위탁매도수량")]
    public string? NonProfitConsignmentSalesQuantity
    {
        get; set;
    }
    /// <summary>비차익위탁매도금액</summary>
    [DataMember, JsonProperty("비차익위탁매도금액")]
    public string? NonProfitConsignmentSellingAmount
    {
        get; set;
    }
    /// <summary>비차익위탁매수수량</summary>
    [DataMember, JsonProperty("비차익위탁매수수량")]
    public string? NonProfitConsignmentPurchaseQuantity
    {
        get; set;
    }
    /// <summary>비차익위탁매수금액</summary>
    [DataMember, JsonProperty("비차익위탁매수금액")]
    public string? NonProfitConsignmentPurchaseAmount
    {
        get; set;
    }
    /// <summary>비차익위탁순매수수량</summary>
    [DataMember, JsonProperty("비차익위탁순매수수량")]
    public string? NonProfitConsignmentNetPurchaseQuantity
    {
        get; set;
    }
    /// <summary>비차익위탁순매수금액</summary>
    [DataMember, JsonProperty("비차익위탁순매수금액")]
    public string? NonProfitConsignmentNetPurchaseAmount
    {
        get; set;
    }
    /// <summary>전체차익위탁매도수량</summary>
    [DataMember, JsonProperty("전체차익위탁매도수량")]
    public string? TotalProfitConsignmentSalesVolume
    {
        get; set;
    }
    /// <summary>전체차익위탁매도금액</summary>
    [DataMember, JsonProperty("전체차익위탁매도금액")]
    public string? TotalProfitConsignmentSaleAmount
    {
        get; set;
    }
    /// <summary>전체차익위탁매수수량</summary>
    [DataMember, JsonProperty("전체차익위탁매수수량")]
    public string? TotalProfitConsignmentPurchaseQuantity
    {
        get; set;
    }
    /// <summary>전체차익위탁매수금액</summary>
    [DataMember, JsonProperty("전체차익위탁매수금액")]
    public string? TotalGainsConsignmentPurchaseAmount
    {
        get; set;
    }
    /// <summary>전체차익위탁순매수수량</summary>
    [DataMember, JsonProperty("전체차익위탁순매수수량")]
    public string? TotalGainsEntrustedNetPurchaseQuantity
    {
        get; set;
    }
    /// <summary>전체차익위탁순매수금액</summary>
    [DataMember, JsonProperty("전체차익위탁순매수금액")]
    public string? TotalGainsEntrustedNetPurchaseAmount
    {
        get; set;
    }
}