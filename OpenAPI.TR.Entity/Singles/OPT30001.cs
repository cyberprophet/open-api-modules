using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>기준가시간</summary>
public class SingleOPT30001
{
    /// <summary>기준가시간</summary>
    [DataMember, JsonProperty("기준가시간")]
    public string? BasePriceTime
    {
        get; set;
    }
}