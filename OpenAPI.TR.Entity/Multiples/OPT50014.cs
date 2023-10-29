using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물가격대별비중차트</summary>
public class MultiOPT50014
{
    /// <summary>구간구분</summary>
    [DataMember, JsonProperty("구간구분")]
    public string? SectionClassification
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? VolumeOfTransaction
    {
        get; set;
    }
    /// <summary>비중</summary>
    [DataMember, JsonProperty("비중")]
    public string? Weight
    {
        get; set;
    }
}