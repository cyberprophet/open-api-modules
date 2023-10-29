using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식기관</summary>
public class MultiOPT10009
{
    /// <summary>날짜</summary>
    [DataMember, JsonProperty("날짜")]
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
    /// <summary>대비</summary>
    [DataMember, JsonProperty("대비")]
    public string? Contrast
    {
        get; set;
    }
    /// <summary>기관기간누적</summary>
    [DataMember, JsonProperty("기관기간누적")]
    public string? AccumulationOfInstitutionalPeriods
    {
        get; set;
    }
    /// <summary>기관일변순매매</summary>
    [DataMember, JsonProperty("기관일변순매매")]
    public string? OneSidedTradingOfTheTrachea
    {
        get; set;
    }
    /// <summary>외국인일변순매매</summary>
    [DataMember, JsonProperty("외국인일변순매매")]
    public string? OneSidedForeignTrade
    {
        get; set;
    }
    /// <summary>외국인지분율</summary>
    [DataMember, JsonProperty("외국인지분율")]
    public string? ForeignEquityRatio
    {
        get; set;
    }
}