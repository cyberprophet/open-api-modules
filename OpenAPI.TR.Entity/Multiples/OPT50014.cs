using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물가격대별비중차트</summary>
public class MultiOPT50014
{
    /// <summary>구간구분</summary>
    [DataMember, JsonProperty("구간구분")]
    public string? 구간구분
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? 거래량
    {
        get; set;
    }
    /// <summary>비중</summary>
    [DataMember, JsonProperty("비중")]
    public string? 비중
    {
        get; set;
    }
}