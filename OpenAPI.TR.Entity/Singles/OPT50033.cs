using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵잔존일조회</summary>
public class SingleOPT50033
{
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
    /// <summary>역사적변동성</summary>
    [DataMember, JsonProperty("역사적변동성")]
    public string? 역사적변동성
    {
        get; set;
    }
    /// <summary>잔존일수</summary>
    [DataMember, JsonProperty("잔존일수")]
    public string? 잔존일수
    {
        get; set;
    }
    /// <summary>영업일기준잔존일</summary>
    [DataMember, JsonProperty("영업일기준잔존일")]
    public string? 영업일기준잔존일
    {
        get; set;
    }
    /// <summary>차근달력기준잔존일</summary>
    [DataMember, JsonProperty("차근달력기준잔존일")]
    public string? 차근달력기준잔존일
    {
        get; set;
    }
    /// <summary>차근영업일기준잔존일</summary>
    [DataMember, JsonProperty("차근영업일기준잔존일")]
    public string? 차근영업일기준잔존일
    {
        get; set;
    }
    /// <summary>차차근달력기준잔존일</summary>
    [DataMember, JsonProperty("차차근달력기준잔존일")]
    public string? 차차근달력기준잔존일
    {
        get; set;
    }
    /// <summary>차차근영업일기준잔존일</summary>
    [DataMember, JsonProperty("차차근영업일기준잔존일")]
    public string? 차차근영업일기준잔존일
    {
        get; set;
    }
    /// <summary>차차차근달력기준잔존일</summary>
    [DataMember, JsonProperty("차차차근달력기준잔존일")]
    public string? 차차차근달력기준잔존일
    {
        get; set;
    }
    /// <summary>차차차근영업일기준잔존일</summary>
    [DataMember, JsonProperty("차차차근영업일기준잔존일")]
    public string? 차차차근영업일기준잔존일
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
}