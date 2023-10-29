using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일자별종목별실현손익</summary>
public class MultiOPT10072
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>당일hts매도수수료</summary>
    [DataMember, JsonProperty("당일hts매도수수료")]
    public string? SameDayHtsSaleFee
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>체결량</summary>
    [DataMember, JsonProperty("체결량")]
    public string? TheAmountOfEngagement
    {
        get; set;
    }
    /// <summary>매입단가</summary>
    [DataMember, JsonProperty("매입단가")]
    public string? PurchaseUnitPrice
    {
        get; set;
    }
    /// <summary>체결가</summary>
    [DataMember, JsonProperty("체결가")]
    public string? AnEngagementPrice
    {
        get; set;
    }
    /// <summary>당일매도손익</summary>
    [DataMember, JsonProperty("당일매도손익")]
    public string? ProfitOrLossOnSaleOnTheSameDay
    {
        get; set;
    }
    /// <summary>손익율</summary>
    [DataMember, JsonProperty("손익율")]
    public string? ProfitLossRatio
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
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
    /// <summary>인출가능금액</summary>
    [DataMember, JsonProperty("인출가능금액")]
    public string? WithdrawableAmount
    {
        get; set;
    }
    /// <summary>대출일</summary>
    [DataMember, JsonProperty("대출일")]
    public string? DateOfLoan
    {
        get; set;
    }
    /// <summary>신용구분</summary>
    [DataMember, JsonProperty("신용구분")]
    public string? CreditClassification
    {
        get; set;
    }
    /// <summary>종목코드1</summary>
    [DataMember, JsonProperty("종목코드1")]
    public string? Code1
    {
        get; set;
    }
    /// <summary>당일매도손익1</summary>
    [DataMember, JsonProperty("당일매도손익1")]
    public string? ProfitAndLossOnSaleOnTheSameDay
    {
        get; set;
    }
}