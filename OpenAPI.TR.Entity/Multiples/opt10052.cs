using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>거래원순간거래량</summary>
public class MultiOpt10052
{
    /// <summary>시간</summary>
    [DataMember, JsonProperty("시간")]
    public string? Time
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>거래원명</summary>
    [DataMember, JsonProperty("거래원명")]
    public string? TheNameOfATrader
    {
        get; set;
    }
    /// <summary>구분</summary>
    [DataMember, JsonProperty("구분")]
    public string? Sortation
    {
        get; set;
    }
    /// <summary>순간거래량</summary>
    [DataMember, JsonProperty("순간거래량")]
    public string? InstantaneousTradingVolume
    {
        get; set;
    }
    /// <summary>누적순매수</summary>
    [DataMember, JsonProperty("누적순매수")]
    public string? AccumulatedNetBuying
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? ThePresentPrice
    {
        get; set;
    }
    /// <summary>전일대비기호</summary>
    [DataMember, JsonProperty("전일대비기호")]
    public string? SignsComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }
}