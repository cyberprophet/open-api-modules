using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF전체시세</summary>
public class MultiOpt40004
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>종목분류</summary>
    [DataMember, JsonProperty("종목분류")]
    public string? ItemClassification
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
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
    /// <summary>추적오차율</summary>
    [DataMember, JsonProperty("추적오차율")]
    public string? TrackingErrorRate
    {
        get; set;
    }
    /// <summary>과표기준</summary>
    [DataMember, JsonProperty("과표기준")]
    public string? BasedOnTheTable
    {
        get; set;
    }
    /// <summary>배당전기준</summary>
    [DataMember, JsonProperty("배당전기준")]
    public string? PreDividendBasis
    {
        get; set;
    }
    /// <summary>전일배당금</summary>
    [DataMember, JsonProperty("전일배당금")]
    public string? ThePreviousDay
    {
        get; set;
    }
    /// <summary>추적지수명</summary>
    [DataMember, JsonProperty("추적지수명")]
    public string? TrackingIndexName
    {
        get; set;
    }
    /// <summary>배수</summary>
    [DataMember, JsonProperty("배수")]
    public string? Drainage
    {
        get; set;
    }
    /// <summary>추적지수코드</summary>
    [DataMember, JsonProperty("추적지수코드")]
    public string? TrackingIndexCode
    {
        get; set;
    }
    /// <summary>추적지수</summary>
    [DataMember, JsonProperty("추적지수")]
    public string? TrackingIndex
    {
        get; set;
    }
    /// <summary>추적등락율</summary>
    [DataMember, JsonProperty("추적등락율")]
    public string? TrackingRateOfInversion
    {
        get; set;
    }
}