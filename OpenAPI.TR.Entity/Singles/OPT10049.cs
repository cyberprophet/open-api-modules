using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW투자지표</summary>
public class SingleOPT10049
{
    /// <summary>연속구분</summary>
    [DataMember, JsonProperty("연속구분")]
    public string? ContinuousClassification
    {
        get; set;
    }
    /// <summary>연속키</summary>
    [DataMember, JsonProperty("연속키")]
    public string? ContinuousKey
    {
        get; set;
    }
}