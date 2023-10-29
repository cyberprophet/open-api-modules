using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵일자별체결</summary>
public class MultiOpt50002
{
    /// <summary>체결일자</summary>
    [DataMember, JsonProperty("체결일자")]
    public string? DateOfConclusion
    {
        get; set;
    }
    /// <summary>현재가n</summary>
    [DataMember, JsonProperty("현재가n")]
    public string? CurrentPriceN
    {
        get; set;
    }
    /// <summary>대비기호n</summary>
    [DataMember, JsonProperty("대비기호n")]
    public string? ContrastSymbolN
    {
        get; set;
    }
    /// <summary>전일대비n</summary>
    [DataMember, JsonProperty("전일대비n")]
    public string? ComparedToThePreviousDayN
    {
        get; set;
    }
    /// <summary>등락율n</summary>
    [DataMember, JsonProperty("등락율n")]
    public string? FluctuationRateN
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? VolumeOfTransaction
    {
        get; set;
    }
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가")]
    public string? MarketPrice
    {
        get; set;
    }
    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가")]
    public string? HighPrice
    {
        get; set;
    }
    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가")]
    public string? LowPrice
    {
        get; set;
    }
    /// <summary>예상체결가</summary>
    [DataMember, JsonProperty("예상체결가")]
    public string? EstimatedClosingPrice
    {
        get; set;
    }
    /// <summary>미결제약정</summary>
    [DataMember, JsonProperty("미결제약정")]
    public string? OpenInterest
    {
        get; set;
    }
    /// <summary>예상체결가전일종가대비기호</summary>
    [DataMember, JsonProperty("예상체결가전일종가대비기호")]
    public string? ExpectedClosingPriceOfHomeAppliances
    {
        get; set;
    }
    /// <summary>예상체결가전일종가대비</summary>
    [DataMember, JsonProperty("예상체결가전일종가대비")]
    public string? EstimatedClosingPriceComparedToExpectedClosingPrice
    {
        get; set;
    }
    /// <summary>예상체결가전일종가대비등락율</summary>
    [DataMember, JsonProperty("예상체결가전일종가대비등락율")]
    public string? ExpectedRateOfFluctuationComparedToExpectedClosingPriceOfHomeAppliances
    {
        get; set;
    }
}