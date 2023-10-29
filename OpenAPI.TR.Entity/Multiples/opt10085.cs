using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌수익률</summary>
public class MultiOpt10085
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
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
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>매입가</summary>
    [DataMember, JsonProperty("매입가")]
    public string? PurchasingPrice
    {
        get; set;
    }
    /// <summary>매입금액</summary>
    [DataMember, JsonProperty("매입금액")]
    public string? PurchaseAmount
    {
        get; set;
    }
    /// <summary>보유수량</summary>
    [DataMember, JsonProperty("보유수량")]
    public string? AmountHeld
    {
        get; set;
    }
    /// <summary>당일매도손익</summary>
    [DataMember, JsonProperty("당일매도손익")]
    public string? ProfitOrLossOnSaleOnTheSameDay
    {
        get; set;
    }
    /// <summary>당일매매수수료</summary>
    [DataMember, JsonProperty("당일매매수수료")]
    public string? SameDayTradingFee
    {
        get; set;
    }
    /// <summary>당일매매세금</summary>
    [DataMember, JsonProperty("당일매매세금")]
    public string? SameDaySalesTax
    {
        get; set;
    }
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
    /// <summary>결제잔고</summary>
    [DataMember, JsonProperty("결제잔고")]
    public string? PaymentBalance
    {
        get; set;
    }
    /// <summary>청산가능수량</summary>
    [DataMember, JsonProperty("청산가능수량")]
    public string? LiquidationPossibleQuantity
    {
        get; set;
    }
    /// <summary>신용금액</summary>
    [DataMember, JsonProperty("신용금액")]
    public string? CreditAmount
    {
        get; set;
    }
    /// <summary>신용이자</summary>
    [DataMember, JsonProperty("신용이자")]
    public string? CreditInterest
    {
        get; set;
    }
    /// <summary>만기일</summary>
    [DataMember, JsonProperty("만기일")]
    public string? ExpirationDate
    {
        get; set;
    }
}