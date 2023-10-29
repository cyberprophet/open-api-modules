using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>테마구성종목단일</summary>
public class SingleOpt90002
{
    /// <summary>등락률</summary>
    [DataMember, JsonProperty("등락률")]
    public string? FluctuationRate
    {
        get; set;
    }
    /// <summary>기간수익률</summary>
    [DataMember, JsonProperty("기간수익률")]
    public string? TermRateOfReturn
    {
        get; set;
    }
}