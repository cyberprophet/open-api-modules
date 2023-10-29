using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물시세추이</summary>
public class MultiOpt50007
{
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? ConcludingTime
    {
        get; set;
    }
    /// <summary>시가n</summary>
    [DataMember, JsonProperty("시가n")]
    public string? MarketPriceOfN
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
    /// <summary>체결량</summary>
    [DataMember, JsonProperty("체결량")]
    public string? AmountOfEngagement
    {
        get; set;
    }
    /// <summary>누적거래량n</summary>
    [DataMember, JsonProperty("누적거래량n")]
    public string? AccumulatedTradingVolumeN
    {
        get; set;
    }
    /// <summary>미결제약정</summary>
    [DataMember, JsonProperty("미결제약정")]
    public string? OpenInterest
    {
        get; set;
    }
    /// <summary>미결제증감</summary>
    [DataMember, JsonProperty("미결제증감")]
    public string? IncreaseOrDecreaseOutstanding
    {
        get; set;
    }
    /// <summary>시장베이시스</summary>
    [DataMember, JsonProperty("시장베이시스")]
    public string? MarketBasis
    {
        get; set;
    }
    /// <summary>코스피200</summary>
    [DataMember, JsonProperty("코스피200")]
    public string? KOSPI200
    {
        get;
        set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>내재가치n</summary>
    [DataMember, JsonProperty("내재가치n")]
    public string? IntrinsicValueN
    {
        get; set;
    }
}