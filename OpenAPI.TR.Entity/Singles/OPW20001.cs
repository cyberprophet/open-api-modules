using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵위탁증거금가계산</summary>
public class SingleOPW20001
{
    /// <summary>현재위탁증거금총액</summary>
    [DataMember, JsonProperty("현재위탁증거금총액")]
    public string? 현재위탁증거금총액
    {
        get; set;
    }
    /// <summary>현재현금예탁필요액</summary>
    [DataMember, JsonProperty("현재현금예탁필요액")]
    public string? 현재현금예탁필요액
    {
        get; set;
    }
    /// <summary>체결위탁증거금총액</summary>
    [DataMember, JsonProperty("체결위탁증거금총액")]
    public string? 체결위탁증거금총액
    {
        get; set;
    }
    /// <summary>체결현금예탁필요액</summary>
    [DataMember, JsonProperty("체결현금예탁필요액")]
    public string? 체결현금예탁필요액
    {
        get; set;
    }
    /// <summary>증감위탁증거금총액</summary>
    [DataMember, JsonProperty("증감위탁증거금총액")]
    public string? 증감위탁증거금총액
    {
        get; set;
    }
    /// <summary>증감현금예탁필요액</summary>
    [DataMember, JsonProperty("증감현금예탁필요액")]
    public string? 증감현금예탁필요액
    {
        get; set;
    }
}