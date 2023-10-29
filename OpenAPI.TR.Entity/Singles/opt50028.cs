using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물틱차트</summary>
public class SingleOpt50028
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>마지막틱갯수</summary>
    [DataMember, JsonProperty("마지막틱갯수")]
    public string? LastTickCount
    {
        get; set;
    }
}