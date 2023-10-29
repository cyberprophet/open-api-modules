using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별프로그램매매합계</summary>
public class SingleOPT90004
{
    /// <summary>합계1</summary>
    [DataMember, JsonProperty("합계1")]
    public string? TotalOfOne
    {
        get; set;
    }
    /// <summary>합계2</summary>
    [DataMember, JsonProperty("합계2")]
    public string? TotalOfTwo
    {
        get; set;
    }
    /// <summary>합계3</summary>
    [DataMember, JsonProperty("합계3")]
    public string? TotalOfThree
    {
        get; set;
    }
    /// <summary>합계4</summary>
    [DataMember, JsonProperty("합계4")]
    public string? TotalOfFour
    {
        get; set;
    }
    /// <summary>합계5</summary>
    [DataMember, JsonProperty("합계5")]
    public string? TotalOfFive
    {
        get; set;
    }
    /// <summary>합계6</summary>
    [DataMember, JsonProperty("합계6")]
    public string? TotalOfSix
    {
        get; set;
    }
}