using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일별추정예탁자산현황</summary>
public class MultiOPW00002
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? 일자
    {
        get; set;
    }
    /// <summary>예수금</summary>
    [DataMember, JsonProperty("예수금")]
    public string? 예수금
    {
        get; set;
    }
    /// <summary>담보대출금</summary>
    [DataMember, JsonProperty("담보대출금")]
    public string? 담보대출금
    {
        get; set;
    }
    /// <summary>신용융자금</summary>
    [DataMember, JsonProperty("신용융자금")]
    public string? 신용융자금
    {
        get; set;
    }
    /// <summary>대주담보금</summary>
    [DataMember, JsonProperty("대주담보금")]
    public string? 대주담보금
    {
        get; set;
    }
    /// <summary>대용금</summary>
    [DataMember, JsonProperty("대용금")]
    public string? 대용금
    {
        get; set;
    }
    /// <summary>추정예탁자산</summary>
    [DataMember, JsonProperty("추정예탁자산")]
    public string? 추정예탁자산
    {
        get; set;
    }
    /// <summary>추정예탁자산수익증권제외</summary>
    [DataMember, JsonProperty("추정예탁자산수익증권제외")]
    public string? 추정예탁자산수익증권제외
    {
        get; set;
    }
}