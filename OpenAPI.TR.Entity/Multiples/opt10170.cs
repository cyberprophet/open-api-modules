using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>당일매매일지</summary>
public class MultiOpt10170
{
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>매수평균가</summary>
    [DataMember, JsonProperty("매수평균가")]
    public string? AveragePriceOf
    {
        get; set;
    }
    /// <summary>매수수량</summary>
    [DataMember, JsonProperty("매수수량")]
    public string? PurchaseQuantity
    {
        get; set;
    }
    /// <summary>매도평균가</summary>
    [DataMember, JsonProperty("매도평균가")]
    public string? AverageSellingPrice
    {
        get; set;
    }
    /// <summary>매도수량</summary>
    [DataMember, JsonProperty("매도수량")]
    public string? SalesVolume
    {
        get; set;
    }
    /// <summary>수수료_제세금</summary>
    [DataMember, JsonProperty("수수료_제세금")]
    public string? FeesTaxes
    {
        get; set;
    }
    /// <summary>손익금액</summary>
    [DataMember, JsonProperty("손익금액")]
    public string? ProfitAndLossAmount
    {
        get; set;
    }
    /// <summary>매도금액</summary>
    [DataMember, JsonProperty("매도금액")]
    public string? SellingAmount
    {
        get; set;
    }
    /// <summary>매수금액</summary>
    [DataMember, JsonProperty("매수금액")]
    public string? PurchaseAmount
    {
        get; set;
    }
    /// <summary>수익률</summary>
    [DataMember, JsonProperty("수익률")]
    public string? YieldRateOfReturn
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
}