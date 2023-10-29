using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>민감도지표추이</summary>
public class MultiOpt50023
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? ConcludingTime
    {
        get; set;
    }
    /// <summary>현재가n</summary>
    [DataMember, JsonProperty("현재가n")]
    public string? CurrentPriceN
    {
        get; set;
    }
    /// <summary>이론가n</summary>
    [DataMember, JsonProperty("이론가n")]
    public string? TheoristN
    {
        get; set;
    }
    /// <summary>내재변동성n</summary>
    [DataMember, JsonProperty("내재변동성n")]
    public string? IntrinsicVariabilityN
    {
        get; set;
    }
    /// <summary>델타n</summary>
    [DataMember, JsonProperty("델타n")]
    public string? DeltaN
    {
        get; set;
    }
    /// <summary>감마n</summary>
    [DataMember, JsonProperty("감마n")]
    public string? GammaN
    {
        get; set;
    }
    /// <summary>세타n</summary>
    [DataMember, JsonProperty("세타n")]
    public string? ThetaN
    {
        get; set;
    }
    /// <summary>베가n</summary>
    [DataMember, JsonProperty("베가n")]
    public string? VegaN
    {
        get; set;
    }
    /// <summary>로n</summary>
    [DataMember, JsonProperty("로n")]
    public string? RhoN
    {
        get; set;
    }
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가")]
    public string? StartPrice
    {
        get; set;
    }
    /// <summary>고가n</summary>
    [DataMember, JsonProperty("고가n")]
    public string? ExpensiveN
    {
        get; set;
    }
    /// <summary>저가n</summary>
    [DataMember, JsonProperty("저가n")]
    public string? LowPriceN
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
    /// <summary>누적거래량n</summary>
    [DataMember, JsonProperty("누적거래량n")]
    public string? AccumulatedTradingVolumeN
    {
        get; set;
    }
    /// <summary>미결제약정n</summary>
    [DataMember, JsonProperty("미결제약정n")]
    public string? OpenInterestN
    {
        get; set;
    }
}