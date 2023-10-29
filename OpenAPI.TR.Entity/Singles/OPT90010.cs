using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>기준일자</summary>
public class SingleOPT90010
{
    /// <summary>기준일자</summary>
    [DataMember, JsonProperty("기준일자")]
    public string? ReferenceDate
    {
        get; set;
    }
}