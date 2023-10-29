using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>외인한도소진율증가상위</summary>
public class MultiOpt10036
{
    /// <summary>순위</summary>
    [DataMember, JsonProperty("순위")]
    public string? Ranking
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
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? VolumeOfTransaction
    {
        get; set;
    }
    /// <summary>보유주식수</summary>
    [DataMember, JsonProperty("보유주식수")]
    public string? NumberOfSharesHeld
    {
        get; set;
    }
    /// <summary>취득가능주식수</summary>
    [DataMember, JsonProperty("취득가능주식수")]
    public string? NumberOfSharesAvailableForAcquisition
    {
        get; set;
    }
    /// <summary>기준한도소진율</summary>
    [DataMember, JsonProperty("기준한도소진율")]
    public string? BaseLimitBurnoutRate
    {
        get; set;
    }
    /// <summary>한도소진율</summary>
    [DataMember, JsonProperty("한도소진율")]
    public string? LimitExhaustionRate
    {
        get; set;
    }
    /// <summary>소진율증가</summary>
    [DataMember, JsonProperty("소진율증가")]
    public string? IncreasedBurnoutRate
    {
        get; set;
    }
}