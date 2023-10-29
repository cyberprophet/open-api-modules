using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>매물대집중</summary>
public class MultiOPT10025
{
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
    /// <summary>등락률</summary>
    [DataMember, JsonProperty("등락률")]
    public string? FluctuationRate
    {
        get; set;
    }
    /// <summary>현재거래량</summary>
    [DataMember, JsonProperty("현재거래량")]
    public string? CurrentTradingVolume
    {
        get; set;
    }
    /// <summary>가격대시작</summary>
    [DataMember, JsonProperty("가격대시작")]
    public string? TheStartOfThePriceRange
    {
        get; set;
    }
    /// <summary>가격대끝</summary>
    [DataMember, JsonProperty("가격대끝")]
    public string? TheEndOfThePriceRange
    {
        get; set;
    }
    /// <summary>매물량</summary>
    [DataMember, JsonProperty("매물량")]
    public string? TheVolumeOfGoods
    {
        get; set;
    }
    /// <summary>매물비</summary>
    [DataMember, JsonProperty("매물비")]
    public string? CostOfSale
    {
        get; set;
    }
}