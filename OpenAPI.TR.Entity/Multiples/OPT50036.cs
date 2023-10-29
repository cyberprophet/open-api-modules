using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주요지수변동성차트</summary>
public class MultiOPT50036
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>전일종가</summary>
    [DataMember, JsonProperty("전일종가")]
    public string? ClosingPriceOfTheDayBefore
    {
        get; set;
    }
    /// <summary>선물역사적변동성</summary>
    [DataMember, JsonProperty("선물역사적변동성")]
    public string? FuturesHistoricalVolatility
    {
        get; set;
    }
}