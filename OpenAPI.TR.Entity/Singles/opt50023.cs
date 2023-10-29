using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>민감도지표추이단일</summary>
public class SingleOpt50023
{
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
    /// <summary>내재변동성</summary>
    [DataMember, JsonProperty("내재변동성")]
    public string? IntrinsicVolatility
    {
        get; set;
    }
    /// <summary>시장베이시스</summary>
    [DataMember, JsonProperty("시장베이시스")]
    public string? MarketBasis
    {
        get; set;
    }
    /// <summary>델타</summary>
    [DataMember, JsonProperty("델타")]
    public string? Delta
    {
        get; set;
    }
    /// <summary>베가</summary>
    [DataMember, JsonProperty("베가")]
    public string? Vega
    {
        get; set;
    }
    /// <summary>감마</summary>
    [DataMember, JsonProperty("감마")]
    public string? Gamma
    {
        get; set;
    }
    /// <summary>로</summary>
    [DataMember, JsonProperty("로")]
    public string? Rho
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
    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가")]
    public string? HighPrice
    {
        get; set;
    }
    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가")]
    public string? LowPrice
    {
        get; set;
    }
    /// <summary>종목표준코드</summary>
    [DataMember, JsonProperty("종목표준코드")]
    public string? StandardCode
    {
        get; set;
    }
    /// <summary>내재가치</summary>
    [DataMember, JsonProperty("내재가치")]
    public string? IntrinsicValue
    {
        get; set;
    }
    /// <summary>시간가치</summary>
    [DataMember, JsonProperty("시간가치")]
    public string? TimeValue
    {
        get; set;
    }
}