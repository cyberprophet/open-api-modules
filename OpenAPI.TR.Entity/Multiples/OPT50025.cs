using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>시간별변동성분석그래프</summary>
public class MultiOPT50025
{
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? ConcludingTime
    {
        get; set;
    }
    /// <summary>대표내재변동성</summary>
    [DataMember, JsonProperty("대표내재변동성")]
    public string? RepresentativeInternalVolatility
    {
        get; set;
    }
    /// <summary>콜내재변동성</summary>
    [DataMember, JsonProperty("콜내재변동성")]
    public string? VolatilityInCallVolatility
    {
        get; set;
    }
    /// <summary>풋내재변동성</summary>
    [DataMember, JsonProperty("풋내재변동성")]
    public string? InFootVolatility
    {
        get; set;
    }
    /// <summary>선물대표내재변동성</summary>
    [DataMember, JsonProperty("선물대표내재변동성")]
    public string? InternalVolatilityInFuturesRepresentation
    {
        get; set;
    }
    /// <summary>선물콜내재변동성</summary>
    [DataMember, JsonProperty("선물콜내재변동성")]
    public string? VolatilityInFuturesCalls
    {
        get; set;
    }
    /// <summary>선물풋내재변동성</summary>
    [DataMember, JsonProperty("선물풋내재변동성")]
    public string? InFuturesVolatility
    {
        get; set;
    }
    /// <summary>역사적변동성1</summary>
    [DataMember, JsonProperty("역사적변동성1")]
    public string? HistoricalVolatility1
    {
        get; set;
    }
    /// <summary>역사적변동성2</summary>
    [DataMember, JsonProperty("역사적변동성2")]
    public string? HistoricalVolatility2
    {
        get; set;
    }
    /// <summary>역사적변동성3</summary>
    [DataMember, JsonProperty("역사적변동성3")]
    public string? HistoricalVolatility3
    {
        get; set;
    }
    /// <summary>선물역사적변동성1</summary>
    [DataMember, JsonProperty("선물역사적변동성1")]
    public string? FuturesHistoricalVolatility1
    {
        get; set;
    }
    /// <summary>선물역사적변동성2</summary>
    [DataMember, JsonProperty("선물역사적변동성2")]
    public string? FuturesHistoricalVolatility2
    {
        get; set;
    }
    /// <summary>선물역사적변동성3</summary>
    [DataMember, JsonProperty("선물역사적변동성3")]
    public string? FuturesHistoricalVolatility3
    {
        get; set;
    }
}