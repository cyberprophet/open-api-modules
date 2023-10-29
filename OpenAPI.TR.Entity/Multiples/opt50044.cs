using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식선물시세표</summary>
public class MultiOpt50044
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>종목표준코드</summary>
    [DataMember, JsonProperty("종목표준코드")]
    public string? StandardCode
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
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? FluctuationRate
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? AccumulatedTradingVolume
    {
        get; set;
    }
    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금")]
    public string? AccumulatedTransactionAmount
    {
        get; set;
    }
    /// <summary>미결제약정</summary>
    [DataMember, JsonProperty("미결제약정")]
    public string? OpenInterest
    {
        get; set;
    }
    /// <summary>미결제약정전일대비</summary>
    [DataMember, JsonProperty("미결제약정전일대비")]
    public string? ComparedToThePreviousDayOfTheOutstandingPayment
    {
        get; set;
    }
    /// <summary>이론가</summary>
    [DataMember, JsonProperty("이론가")]
    public string? Theorist
    {
        get; set;
    }
    /// <summary>괴리율</summary>
    [DataMember, JsonProperty("괴리율")]
    public string? DisparateRatio
    {
        get; set;
    }
    /// <summary>시장베이시스</summary>
    [DataMember, JsonProperty("시장베이시스")]
    public string? MarketBasis
    {
        get; set;
    }
    /// <summary>최우선매수호가</summary>
    [DataMember, JsonProperty("최우선매수호가")]
    public string? HighestAskingPrice
    {
        get; set;
    }
    /// <summary>최우선매도호가</summary>
    [DataMember, JsonProperty("최우선매도호가")]
    public string? HighestSellingPrice
    {
        get; set;
    }
    /// <summary>코스피200</summary>
    [DataMember, JsonProperty("코스피200")]
    public string? KOSPI200
    {
        get; set;
    }
}