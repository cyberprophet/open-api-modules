using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>옵션현재가정보</summary>
public class SingleOpt50063
{
    /// <summary>현재가s</summary>
    [DataMember, JsonProperty("현재가s")]
    public string? CurrentPrice
    {
        get; set;
    }
    /// <summary>대비기호s</summary>
    [DataMember, JsonProperty("대비기호s")]
    public string? ContrastSymbol
    {
        get; set;
    }
    /// <summary>전일대비s</summary>
    [DataMember, JsonProperty("전일대비s")]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>등락율s</summary>
    [DataMember, JsonProperty("등락율s")]
    public string? FluctuationRate
    {
        get; set;
    }
    /// <summary>고가s</summary>
    [DataMember, JsonProperty("고가s")]
    public string? ExpensivePrice
    {
        get; set;
    }
    /// <summary>저가s</summary>
    [DataMember, JsonProperty("저가s")]
    public string? LowPrice
    {
        get; set;
    }
    /// <summary>누적거래량s</summary>
    [DataMember, JsonProperty("누적거래량s")]
    public string? AccumulatedTradingVolume
    {
        get; set;
    }
    /// <summary>미결제약정s</summary>
    [DataMember, JsonProperty("미결제약정s")]
    public string? OpenInterest
    {
        get; set;
    }
    /// <summary>종목명s</summary>
    [DataMember, JsonProperty("종목명s")]
    public string? Name
    {
        get; set;
    }
}