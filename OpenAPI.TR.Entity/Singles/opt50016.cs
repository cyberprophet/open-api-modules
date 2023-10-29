using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>전일종가</summary>
public class SingleOpt50016
{
    /// <summary>전일종가</summary>
    [DataMember, JsonProperty("전일종가")]
    public string? ClosingPriceOfTheDayBefore
    {
        get; set;
    }
}