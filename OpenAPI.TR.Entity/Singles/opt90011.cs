using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>기준일자</summary>
public class SingleOpt90011
{
    /// <summary>기준일자</summary>
    [DataMember, JsonProperty("기준일자")]
    public string? ReferenceDate
    {
        get; set;
    }
}