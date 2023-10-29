using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>외인연속순매매상위</summary>
public class MultiOPT10035
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? ThePresentPrice
    {
        get; set;
    }
    /// <summary>전일대비기호</summary>
    [DataMember, JsonProperty("전일대비기호")]
    public string? SignsComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>D-1</summary>
    [DataMember, JsonProperty("D-1")]
    public string? D1
    {
        get; set;
    }
    /// <summary>D-2</summary>
    [DataMember, JsonProperty("D-2")]
    public string? D2
    {
        get; set;
    }
    /// <summary>D-3</summary>
    [DataMember, JsonProperty("D-3")]
    public string? D3
    {
        get; set;
    }
    /// <summary>합계</summary>
    [DataMember, JsonProperty("합계")]
    public string? Sum
    {
        get; set;
    }
    /// <summary>한도소진율</summary>
    [DataMember, JsonProperty("한도소진율")]
    public string? LimitExhaustionRate
    {
        get; set;
    }
    /// <summary>전일대비1</summary>
    [DataMember, JsonProperty("전일대비1")]
    public string? _1ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>전일대비2</summary>
    [DataMember, JsonProperty("전일대비2")]
    public string? _2ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>전일대비3</summary>
    [DataMember, JsonProperty("전일대비3")]
    public string? _3ComparedToThePreviousDay
    {
        get; set;
    }
}