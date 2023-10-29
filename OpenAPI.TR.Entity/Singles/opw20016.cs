using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>신용융자가능여부</summary>
public class SingleOpw20016
{
    /// <summary>신용융자가능여부</summary>
    [DataMember, JsonProperty("신용융자가능여부")]
    public string? CreditLoanAvailability
    {
        get; set;
    }
    /// <summary>출력건수</summary>
    [DataMember, JsonProperty("출력건수")]
    public string? NumberOfOutputs
    {
        get; set;
    }
}