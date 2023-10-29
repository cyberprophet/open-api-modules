using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>거래량합계</summary>
public class SingleOpt50044
{
    /// <summary>거래량합계</summary>
    [DataMember, JsonProperty("거래량합계")]
    public string? TotalTransactionVolume
    {
        get; set;
    }
    /// <summary>거래대금합계</summary>
    [DataMember, JsonProperty("거래대금합계")]
    public string? TotalTransactionValue
    {
        get; set;
    }
}