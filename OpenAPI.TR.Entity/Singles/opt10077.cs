using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>당일실현손익</summary>
public class SingleOpt10077
{
    /// <summary>당일실현손익</summary>
    [DataMember, JsonProperty("당일실현손익")]
    public string? EarningsAndLossesRealizedOnTheSameDay
    {
        get; set;
    }
}