using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>출력건수</summary>
public class SingleOpw20004
{
    /// <summary>출력건수</summary>
    [DataMember, JsonProperty("출력건수")]
    public string? NumberOfOutputs
    {
        get; set;
    }
}