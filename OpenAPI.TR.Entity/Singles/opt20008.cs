using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종월봉차트</summary>
public class SingleOpt20008
{
    /// <summary>업종코드</summary>
    [DataMember, JsonProperty("업종코드")]
    public string? IndustryCode
    {
        get; set;
    }
}