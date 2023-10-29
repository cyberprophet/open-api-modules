using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별계좌평가현황</summary>
public class MultiOPW00004
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
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
    /// <summary>보유수량</summary>
    [DataMember, JsonProperty("보유수량")]
    public string? AmountHeld
    {
        get; set;
    }
    /// <summary>평균단가</summary>
    [DataMember, JsonProperty("평균단가")]
    public string? AverageUnitPrice
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>평가금액</summary>
    [DataMember, JsonProperty("평가금액")]
    public string? EvaluationAmount
    {
        get; set;
    }
    /// <summary>손익금액</summary>
    [DataMember, JsonProperty("손익금액")]
    public string? ProfitAndLossAmount
    {
        get; set;
    }
    /// <summary>손익율</summary>
    [DataMember, JsonProperty("손익율")]
    public string? ProfitLossRatio
    {
        get; set;
    }
    /// <summary>대출일</summary>
    [DataMember, JsonProperty("대출일")]
    public string? DateOfLoan
    {
        get; set;
    }
    /// <summary>매입금액</summary>
    [DataMember, JsonProperty("매입금액")]
    public string? PurchaseAmount
    {
        get; set;
    }
    /// <summary>결제잔고</summary>
    [DataMember, JsonProperty("결제잔고")]
    public string? PaymentBalance
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
}