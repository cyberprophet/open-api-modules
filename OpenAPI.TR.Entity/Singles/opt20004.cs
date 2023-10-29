using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종틱차트</summary>
public class SingleOpt20004
{
    /// <summary>업종코드</summary>
    [DataMember, JsonProperty("업종코드")]
    public string? IndustryCode
    {
        get; set;
    }
}