using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>비밀번호일치여부</summary>
public class SingleOPW00014
{
    /// <summary>일치여부</summary>
    [DataMember, JsonProperty("일치여부")]
    public string? MatchingStatus
    {
        get; set;
    }
}