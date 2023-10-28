using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일별변동성분석그래프</summary>
public class MultiOPT50024
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? 일자
    {
        get; set;
    }
    /// <summary>대표내재변동성</summary>
    [DataMember, JsonProperty("대표내재변동성")]
    public string? 대표내재변동성
    {
        get; set;
    }
    /// <summary>콜내재변동성</summary>
    [DataMember, JsonProperty("콜내재변동성")]
    public string? 콜내재변동성
    {
        get; set;
    }
    /// <summary>풋내재변동성</summary>
    [DataMember, JsonProperty("풋내재변동성")]
    public string? 풋내재변동성
    {
        get; set;
    }
    /// <summary>선물대표내재변동성</summary>
    [DataMember, JsonProperty("선물대표내재변동성")]
    public string? 선물대표내재변동성
    {
        get; set;
    }
    /// <summary>선물콜내재변동성</summary>
    [DataMember, JsonProperty("선물콜내재변동성")]
    public string? 선물콜내재변동성
    {
        get; set;
    }
    /// <summary>선물풋내재변동성</summary>
    [DataMember, JsonProperty("선물풋내재변동성")]
    public string? 선물풋내재변동성
    {
        get; set;
    }
    /// <summary>역사적변동성1</summary>
    [DataMember, JsonProperty("역사적변동성1")]
    public string? 역사적변동성1
    {
        get; set;
    }
    /// <summary>역사적변동성2</summary>
    [DataMember, JsonProperty("역사적변동성2")]
    public string? 역사적변동성2
    {
        get; set;
    }
    /// <summary>역사적변동성3</summary>
    [DataMember, JsonProperty("역사적변동성3")]
    public string? 역사적변동성3
    {
        get; set;
    }
    /// <summary>선물역사적변동성1</summary>
    [DataMember, JsonProperty("선물역사적변동성1")]
    public string? 선물역사적변동성1
    {
        get; set;
    }
    /// <summary>선물역사적변동성2</summary>
    [DataMember, JsonProperty("선물역사적변동성2")]
    public string? 선물역사적변동성2
    {
        get; set;
    }
    /// <summary>선물역사적변동성3</summary>
    [DataMember, JsonProperty("선물역사적변동성3")]
    public string? 선물역사적변동성3
    {
        get; set;
    }
    /// <summary>시작일자</summary>
    [DataMember, JsonProperty("시작일자")]
    public string? 시작일자
    {
        get; set;
    }
}