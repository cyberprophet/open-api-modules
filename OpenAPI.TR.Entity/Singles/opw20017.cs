using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>신용융자가능여부</summary>
public class SingleOpw20017
{
    /// <summary>신용가능여부</summary>
    [DataMember, JsonProperty("신용가능여부")]
    public string? CreditAvailability
    {
        get; set;
    }
}