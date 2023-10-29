using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>추정자산조회</summary>
public class SingleOPW00003
{
    /// <summary>추정예탁자산</summary>
    [DataMember, JsonProperty("추정예탁자산")]
    public string? EstimatedDepositAssets
    {
        get; set;
    }
}