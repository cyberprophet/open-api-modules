using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>체결강도일별</summary>
public class MultiOpt10047
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? ThePresentPrice
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>전일대비기호</summary>
    [DataMember, JsonProperty("전일대비기호")]
    public string? SignsComparedToThePreviousDay
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
    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금")]
    public string? AccumulatedTransactionAmount
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? AccumulatedTradingVolume
    {
        get; set;
    }
    /// <summary>체결강도</summary>
    [DataMember, JsonProperty("체결강도")]
    public string? FasteningStrength
    {
        get; set;
    }
    /// <summary>체결강도5분</summary>
    [DataMember, JsonProperty("체결강도5분")]
    public string? FasteningStrength5Minutes
    {
        get; set;
    }
    /// <summary>체결강도20분</summary>
    [DataMember, JsonProperty("체결강도20분")]
    public string? FasteningStrength20Minutes
    {
        get; set;
    }
    /// <summary>체결강도60분</summary>
    [DataMember, JsonProperty("체결강도60분")]
    public string? FasteningStrength60Minutes
    {
        get; set;
    }
}