using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일자별실현손익</summary>
public class MultiOpt10074
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>매수금액</summary>
    [DataMember, JsonProperty("매수금액")]
    public string? PurchaseAmount
    {
        get; set;
    }
    /// <summary>매도금액</summary>
    [DataMember, JsonProperty("매도금액")]
    public string? SellingAmount
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
}