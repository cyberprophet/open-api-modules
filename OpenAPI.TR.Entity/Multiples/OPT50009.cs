using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵시간별잔량</summary>
public class MultiOPT50009
{
    /// <summary>호가시간</summary>
    [DataMember, JsonProperty("호가시간")]
    public string? AskingTime
    {
        get; set;
    }
    /// <summary>매도호가총잔량</summary>
    [DataMember, JsonProperty("매도호가총잔량")]
    public string? TotalBacklogOfSellingPrices
    {
        get; set;
    }
    /// <summary>매수호가총잔량</summary>
    [DataMember, JsonProperty("매수호가총잔량")]
    public string? TotalRemainingAmountOfTheBuyerAskingPrice
    {
        get; set;
    }
    /// <summary>순매수잔량</summary>
    [DataMember, JsonProperty("순매수잔량")]
    public string? NetBuyRemaining
    {
        get; set;
    }
}