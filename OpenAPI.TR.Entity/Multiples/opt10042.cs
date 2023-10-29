using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>순매수거래원순위</summary>
public class MultiOpt10042
{
    /// <summary>순위</summary>
    [DataMember, JsonProperty("순위")]
    public string? Ranking
    {
        get; set;
    }
    /// <summary>회원사코드</summary>
    [DataMember, JsonProperty("회원사코드")]
    public string? MemberCompanyCode
    {
        get; set;
    }
    /// <summary>회원사명</summary>
    [DataMember, JsonProperty("회원사명")]
    public string? MemberCompanyName
    {
        get; set;
    }
}