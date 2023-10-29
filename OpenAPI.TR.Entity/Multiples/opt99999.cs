using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>대차거래상위10종목합계</summary>
public class MultiOpt99999
{
    /// <summary>일자1</summary>
    [DataMember, JsonProperty("일자1")]
    public string? Date1
    {
        get; set;
    }
    /// <summary>일자2</summary>
    [DataMember, JsonProperty("일자2")]
    public string? Date2
    {
        get; set;
    }
    /// <summary>일자3</summary>
    [DataMember, JsonProperty("일자3")]
    public string? Date3
    {
        get; set;
    }
    /// <summary>일자4</summary>
    [DataMember, JsonProperty("일자4")]
    public string? Date4
    {
        get; set;
    }
    /// <summary>일자5</summary>
    [DataMember, JsonProperty("일자5")]
    public string? Date5
    {
        get; set;
    }
    /// <summary>일자6</summary>
    [DataMember, JsonProperty("일자6")]
    public string? Date6
    {
        get; set;
    }
    /// <summary>일자7</summary>
    [DataMember, JsonProperty("일자7")]
    public string? Date7
    {
        get; set;
    }
    /// <summary>일자8</summary>
    [DataMember, JsonProperty("일자8")]
    public string? Date8
    {
        get; set;
    }
}