using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별증권사순위</summary>
public class MultiOpt10038
{
    /// <summary>순위</summary>
    [DataMember, JsonProperty("순위")]
    public string? 순위
    {
        get; set;
    }
    /// <summary>회원사명</summary>
    [DataMember, JsonProperty("회원사명")]
    public string? 회원사명
    {
        get; set;
    }
    /// <summary>매수수량</summary>
    [DataMember, JsonProperty("매수수량")]
    public string? 매수수량
    {
        get; set;
    }
    /// <summary>매도수량</summary>
    [DataMember, JsonProperty("매도수량")]
    public string? 매도수량
    {
        get; set;
    }
    /// <summary>누적순매수수량</summary>
    [DataMember, JsonProperty("누적순매수수량")]
    public string? 누적순매수수량
    {
        get; set;
    }
}