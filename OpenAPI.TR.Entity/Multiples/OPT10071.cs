using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>시간대별전일비거래비중</summary>
public class MultiOPT10071
{
    /// <summary>시간</summary>
    [DataMember, JsonProperty("시간")]
    public string? Time
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>대비기호</summary>
    [DataMember, JsonProperty("대비기호")]
    public string? ContrastSymbol
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>대비율</summary>
    [DataMember, JsonProperty("대비율")]
    public string? ContrastRatio
    {
        get; set;
    }
    /// <summary>체결거래량</summary>
    [DataMember, JsonProperty("체결거래량")]
    public string? ConcludedTransactionVolume
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? AccumulatedTradingVolume
    {
        get; set;
    }
    /// <summary>순간비율</summary>
    [DataMember, JsonProperty("순간비율")]
    public string? InstantaneousRatio
    {
        get; set;
    }
    /// <summary>누적비율</summary>
    [DataMember, JsonProperty("누적비율")]
    public string? AccumulatedRatio
    {
        get; set;
    }
}