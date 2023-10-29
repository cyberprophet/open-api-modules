using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW종목상세1</summary>
public class SingleOpt30006
{
    /// <summary>조기종료여부</summary>
    [DataMember, JsonProperty("조기종료여부")]
    public string? EarlyTerminationStatus
    {
        get; set;
    }
}