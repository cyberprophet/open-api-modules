using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별기관매매추이</summary>
public class MultiOpt10045
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>종가</summary>
    [DataMember, JsonProperty("종가")]
    public string? ClosingPrice
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
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? VolumeOfTransaction
    {
        get; set;
    }
    /// <summary>기관기간누적</summary>
    [DataMember, JsonProperty("기관기간누적")]
    public string? AccumulationOfInstitutionalPeriods
    {
        get; set;
    }
    /// <summary>기관일별순매매수량</summary>
    [DataMember, JsonProperty("기관일별순매매수량")]
    public string? NetSalesVolumePerInstitutionalDay
    {
        get; set;
    }
    /// <summary>외인기간누적</summary>
    [DataMember, JsonProperty("외인기간누적")]
    public string? AccumulatedForeignPeriodOfForeigners
    {
        get; set;
    }
    /// <summary>외인일별순매매수량</summary>
    [DataMember, JsonProperty("외인일별순매매수량")]
    public string? NetSalesVolumePerForeignPersonDaily
    {
        get; set;
    }
    /// <summary>한도소진율</summary>
    [DataMember, JsonProperty("한도소진율")]
    public string? LimitExhaustionRate
    {
        get; set;
    }
}