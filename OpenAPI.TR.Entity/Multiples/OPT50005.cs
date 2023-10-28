using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵시간별거래량</summary>
public class MultiOPT50005
{
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? 체결시간
    {
        get; set;
    }
    /// <summary>미결제약정</summary>
    [DataMember, JsonProperty("미결제약정")]
    public string? 미결제약정
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? 누적거래량
    {
        get; set;
    }
    /// <summary>체결량</summary>
    [DataMember, JsonProperty("체결량")]
    public string? 체결량
    {
        get; set;
    }
}