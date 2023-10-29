using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌평가잔고개별합산</summary>
public class MultiOpw00018
{
    /// <summary>종목번호</summary>
    [DataMember, JsonProperty("종목번호")]
    public string? Code
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>평가손익</summary>
    [DataMember, JsonProperty("평가손익")]
    public string? ValuationGainsAndLosses
    {
        get; set;
    }
    /// <summary>수익률(%)</summary>
    [DataMember, JsonProperty("수익률(%)")]
    public string? Return
    {
        get; set;
    }
    /// <summary>매입가</summary>
    [DataMember, JsonProperty("매입가")]
    public string? PurchasingPrice
    {
        get; set;
    }
    /// <summary>전일종가</summary>
    [DataMember, JsonProperty("전일종가")]
    public string? ClosingPriceOfTheDayBefore
    {
        get; set;
    }
    /// <summary>보유수량</summary>
    [DataMember, JsonProperty("보유수량")]
    public string? AmountHeld
    {
        get; set;
    }
    /// <summary>매매가능수량</summary>
    [DataMember, JsonProperty("매매가능수량")]
    public string? AvailableQuantityForSaleable
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>전일매수수량</summary>
    [DataMember, JsonProperty("전일매수수량")]
    public string? DailyPurchaseQuantity
    {
        get; set;
    }
    /// <summary>전일매도수량</summary>
    [DataMember, JsonProperty("전일매도수량")]
    public string? SalesVolumeOfTheQuantity
    {
        get; set;
    }
    /// <summary>금일매수수량</summary>
    [DataMember, JsonProperty("금일매수수량")]
    public string? TodayPurchaseQuantity
    {
        get; set;
    }
    /// <summary>금일매도수량</summary>
    [DataMember, JsonProperty("금일매도수량")]
    public string? TodaySellingQuantity
    {
        get; set;
    }
    /// <summary>매입금액</summary>
    [DataMember, JsonProperty("매입금액")]
    public string? PurchaseAmount
    {
        get; set;
    }
    /// <summary>매입수수료</summary>
    [DataMember, JsonProperty("매입수수료")]
    public string? PurchaseFee
    {
        get; set;
    }
    /// <summary>평가금액</summary>
    [DataMember, JsonProperty("평가금액")]
    public string? EvaluationAmount
    {
        get; set;
    }
    /// <summary>평가수수료</summary>
    [DataMember, JsonProperty("평가수수료")]
    public string? EvaluationFee
    {
        get; set;
    }
    /// <summary>세금</summary>
    [DataMember, JsonProperty("세금")]
    public string? Tax
    {
        get; set;
    }
    /// <summary>수수료합</summary>
    [DataMember, JsonProperty("수수료합")]
    public string? CommissionSum
    {
        get; set;
    }
    /// <summary>보유비중(%)</summary>
    [DataMember, JsonProperty("보유비중(%)")]
    public string? PercentageOfHoldings
    {
        get; set;
    }
    /// <summary>신용구분</summary>
    [DataMember, JsonProperty("신용구분")]
    public string? CreditClassification
    {
        get; set;
    }
    /// <summary>신용구분명</summary>
    [DataMember, JsonProperty("신용구분명")]
    public string? CreditClassificationName
    {
        get; set;
    }
    /// <summary>대출일</summary>
    [DataMember, JsonProperty("대출일")]
    public string? DateOfLoan
    {
        get; set;
    }
}