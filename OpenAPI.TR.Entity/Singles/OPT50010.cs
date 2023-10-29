using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵시고저가</summary>
public class SingleOPT50010
{
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가")]
    public string? StartPrice
    {
        get; set;
    }
    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가")]
    public string? HighPrice
    {
        get; set;
    }
    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가")]
    public string? LowPrice
    {
        get; set;
    }
}