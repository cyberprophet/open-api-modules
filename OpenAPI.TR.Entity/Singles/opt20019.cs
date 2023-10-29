using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종년봉차트</summary>
public class SingleOpt20019
{
    /// <summary>업종코드</summary>
    [DataMember, JsonProperty("업종코드")]
    public string? IndustryCode
    {
        get; set;
    }
}