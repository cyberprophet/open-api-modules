using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>조기종료통화단위</summary>
public class MultiOpt10041
{
    /// <summary>조기종료여부</summary>
    [DataMember, JsonProperty("조기종료여부")]
    public string? EarlyTerminationStatus
    {
        get; set;
    }
    /// <summary>통화단위</summary>
    [DataMember, JsonProperty("통화단위")]
    public string? MonetaryUnit
    {
        get; set;
    }
}