using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF일별추이</summary>
public class MultiOPT40005
{
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? ConcludingTime
    {
        get; set;
    }
    /// <summary>종가</summary>
    [DataMember, JsonProperty("종가")]
    public string? ClosingPrice
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
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? VolumeOfTransaction
    {
        get; set;
    }
    /// <summary>NAV</summary>
    [DataMember, JsonProperty(nameof(NAV))]
    public string? NAV
    {
        get; set;
    }
    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금")]
    public string? AccumulatedTransactionAmount
    {
        get; set;
    }
    /// <summary>NAV/지수괴리율</summary>
    [DataMember, JsonProperty("NAV/지수괴리율")]
    public string? NAVIndexDistortionRate
    {
        get; set;
    }
    /// <summary>NAV/ETF괴리율</summary>
    [DataMember, JsonProperty("NAV/ETF괴리율")]
    public string? NAVETFDistinctionRate
    {
        get; set;
    }
    /// <summary>추적오차율</summary>
    [DataMember, JsonProperty("추적오차율")]
    public string? TrackingErrorRate
    {
        get; set;
    }
    /// <summary>추적지수</summary>
    [DataMember, JsonProperty("추적지수")]
    public string? TrackingIndex
    {
        get; set;
    }
    /// <summary>추적대비기호</summary>
    [DataMember, JsonProperty("추적대비기호")]
    public string? TrackingContrastSymbol
    {
        get; set;
    }
    /// <summary>추적전일대비</summary>
    [DataMember, JsonProperty("추적전일대비")]
    public string? ComparedToThePreviousDayOfTracking
    {
        get; set;
    }
}