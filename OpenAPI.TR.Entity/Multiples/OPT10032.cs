using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>거래대금상위</summary>
public class MultiOPT10032
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>현재순위</summary>
    [DataMember, JsonProperty("현재순위")]
    public string? CurrentRanking
    {
        get; set;
    }
    /// <summary>전일순위</summary>
    [DataMember, JsonProperty("전일순위")]
    public string? FullTimeRanking
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
    /// <summary>매도호가</summary>
    [DataMember, JsonProperty("매도호가")]
    public string? SellingPrice
    {
        get; set;
    }
    /// <summary>매수호가</summary>
    [DataMember, JsonProperty("매수호가")]
    public string? BuyInPrice
    {
        get; set;
    }
    /// <summary>현재거래량</summary>
    [DataMember, JsonProperty("현재거래량")]
    public string? CurrentTradingVolume
    {
        get; set;
    }
    /// <summary>전일거래량</summary>
    [DataMember, JsonProperty("전일거래량")]
    public string? FullTimeTradingVolume
    {
        get; set;
    }
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금")]
    public string? TransactionPrice
    {
        get; set;
    }
}