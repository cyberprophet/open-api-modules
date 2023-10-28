using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별프로그램매매합계</summary>
public class SingleOPT90004
{
    /// <summary>합계1</summary>
    [DataMember, JsonProperty("합계1")]
    public string? 합계1
    {
        get; set;
    }
    /// <summary>합계2</summary>
    [DataMember, JsonProperty("합계2")]
    public string? 합계2
    {
        get; set;
    }
    /// <summary>합계3</summary>
    [DataMember, JsonProperty("합계3")]
    public string? 합계3
    {
        get; set;
    }
    /// <summary>합계4</summary>
    [DataMember, JsonProperty("합계4")]
    public string? 합계4
    {
        get; set;
    }
    /// <summary>합계5</summary>
    [DataMember, JsonProperty("합계5")]
    public string? 합계5
    {
        get; set;
    }
    /// <summary>합계6</summary>
    [DataMember, JsonProperty("합계6")]
    public string? 합계6
    {
        get; set;
    }
}