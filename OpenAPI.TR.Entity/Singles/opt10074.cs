using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일자별실현손익단일</summary>
public class SingleOpt10074
{
    /// <summary>총매수금액</summary>
    [DataMember, JsonProperty("총매수금액")]
    public string? 총매수금액
    {
        get; set;
    }
    /// <summary>총매도금액</summary>
    [DataMember, JsonProperty("총매도금액")]
    public string? 총매도금액
    {
        get; set;
    }
    /// <summary>실현손익</summary>
    [DataMember, JsonProperty("실현손익")]
    public string? 실현손익
    {
        get; set;
    }
    /// <summary>매매수수료</summary>
    [DataMember, JsonProperty("매매수수료")]
    public string? 매매수수료
    {
        get; set;
    }
    /// <summary>매매세금</summary>
    [DataMember, JsonProperty("매매세금")]
    public string? 매매세금
    {
        get; set;
    }
}