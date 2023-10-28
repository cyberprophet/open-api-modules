using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵전일가격</summary>
public class MultiOPT50034
{
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? 체결시간
    {
        get; set;
    }
}