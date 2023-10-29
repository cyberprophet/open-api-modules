using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF시간대별추이</summary>
public class MultiOpt40006
{
    /// <summary>시간</summary>
    [DataMember, JsonProperty("시간")]
    public string? Time
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
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? FluctuationRate
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
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금")]
    public string? TransactionPrice
    {
        get; set;
    }
    /// <summary>NAV지수</summary>
    [DataMember, JsonProperty("NAV지수")]
    public string? NAVIndex
    {
        get; set;
    }
    /// <summary>NAVETF</summary>
    [DataMember, JsonProperty(nameof(NAVETF))]
    public string? NAVETF
    {
        get; set;
    }
    /// <summary>추적</summary>
    [DataMember, JsonProperty("추적")]
    public string? Tracking
    {
        get; set;
    }
    /// <summary>추적지수</summary>
    [DataMember, JsonProperty("추적지수")]
    public string? TrackingIndex
    {
        get; set;
    }
    /// <summary>추적지수전일대비</summary>
    [DataMember, JsonProperty("추적지수전일대비")]
    public string? TrackingIndexComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>추적지수전일대비기호</summary>
    [DataMember, JsonProperty("추적지수전일대비기호")]
    public string? TrackingIndexComparisonSymbol
    {
        get; set;
    }
}