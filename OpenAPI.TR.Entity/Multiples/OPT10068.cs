using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>대차거래추이</summary>
public class MultiOPT10068
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? 일자
    {
        get; set;
    }
    /// <summary>대차거래체결주수</summary>
    [DataMember, JsonProperty("대차거래체결주수")]
    public string? 대차거래체결주수
    {
        get; set;
    }
    /// <summary>대차거래상환주수</summary>
    [DataMember, JsonProperty("대차거래상환주수")]
    public string? 대차거래상환주수
    {
        get; set;
    }
    /// <summary>대차거래증감</summary>
    [DataMember, JsonProperty("대차거래증감")]
    public string? 대차거래증감
    {
        get; set;
    }
    /// <summary>잔고주수</summary>
    [DataMember, JsonProperty("잔고주수")]
    public string? 잔고주수
    {
        get; set;
    }
    /// <summary>잔고금액</summary>
    [DataMember, JsonProperty("잔고금액")]
    public string? 잔고금액
    {
        get; set;
    }
}