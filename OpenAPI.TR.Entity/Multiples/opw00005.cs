using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별체결잔고</summary>
public class MultiOpw00005
{
    /// <summary>신용구분</summary>
    [DataMember, JsonProperty("신용구분")]
    public string? CreditClassification
    {
        get; set;
    }
    /// <summary>대출일</summary>
    [DataMember, JsonProperty("대출일")]
    public string? DateOfLoan
    {
        get; set;
    }
    /// <summary>만기일</summary>
    [DataMember, JsonProperty("만기일")]
    public string? ExpirationDate
    {
        get; set;
    }
    /// <summary>종목번호</summary>
    [DataMember, JsonProperty("종목번호")]
    public string? ItemNumber
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>결제잔고</summary>
    [DataMember, JsonProperty("결제잔고")]
    public string? PaymentBalance
    {
        get; set;
    }
    /// <summary>현재잔고</summary>
    [DataMember, JsonProperty("현재잔고")]
    public string? CurrentBalance
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>매입단가</summary>
    [DataMember, JsonProperty("매입단가")]
    public string? PurchaseUnitPrice
    {
        get; set;
    }
    /// <summary>매입금액</summary>
    [DataMember, JsonProperty("매입금액")]
    public string? PurchaseAmount
    {
        get; set;
    }
    /// <summary>평가금액</summary>
    [DataMember, JsonProperty("평가금액")]
    public string? EvaluationAmount
    {
        get; set;
    }
    /// <summary>평가손익</summary>
    [DataMember, JsonProperty("평가손익")]
    public string? ValuationGainsAndLosses
    {
        get; set;
    }
    /// <summary>손익률</summary>
    [DataMember, JsonProperty("손익률")]
    public string? ProfitAndLossRatio
    {
        get; set;
    }
}