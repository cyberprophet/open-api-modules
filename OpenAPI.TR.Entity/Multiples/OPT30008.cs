using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW민감도지표</summary>
public class MultiOPT30008
{
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? 체결시간
    {
        get; set;
    }
    /// <summary>내재변동성</summary>
    [DataMember, JsonProperty("내재변동성")]
    public string? 내재변동성
    {
        get; set;
    }
    /// <summary>델타</summary>
    [DataMember, JsonProperty("델타")]
    public string? 델타
    {
        get; set;
    }
    /// <summary>감마</summary>
    [DataMember, JsonProperty("감마")]
    public string? 감마
    {
        get; set;
    }
    /// <summary>쎄타</summary>
    [DataMember, JsonProperty("쎄타")]
    public string? 쎄타
    {
        get; set;
    }
    /// <summary>베가</summary>
    [DataMember, JsonProperty("베가")]
    public string? 베가
    {
        get; set;
    }
    /// <summary>로</summary>
    [DataMember, JsonProperty("로")]
    public string? 로
    {
        get; set;
    }
    /// <summary>X-Ray순간체결량증거금100%구분</summary>
    [DataMember, JsonProperty("X-Ray순간체결량증거금100%구분")]
    public string? XRay순간체결량증거금100구분
    {
        get; set;
    }
}