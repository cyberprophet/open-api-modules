using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵체결추이</summary>
public class MultiOPT50006
{
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? ConcludingTime
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
    /// <summary>체결량</summary>
    [DataMember, JsonProperty("체결량")]
    public string? AmountOfEngagement
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? AccumulatedTradingVolume
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
    /// <summary>전일거래량대비</summary>
    [DataMember, JsonProperty("전일거래량대비")]
    public string? ComparedToThePreviousDayTradingVolume
    {
        get; set;
    }
    /// <summary>전일거래량</summary>
    [DataMember, JsonProperty("전일거래량")]
    public string? FullTimeTradingVolume
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public string? StandardPrice
    {
        get; set;
    }
}