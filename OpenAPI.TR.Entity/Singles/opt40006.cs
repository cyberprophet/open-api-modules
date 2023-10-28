using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF종목정보</summary>
public class SingleOpt40006
{
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>ETF대상지수명</summary>
    [DataMember, JsonProperty("ETF대상지수명")]
    public string? ETF대상지수명
    {
        get; set;
    }
    /// <summary>원주가격</summary>
    [DataMember, JsonProperty("원주가격")]
    public string? 원주가격
    {
        get; set;
    }
    /// <summary>ETF과세유형</summary>
    [DataMember, JsonProperty("ETF과세유형")]
    public string? ETF과세유형
    {
        get; set;
    }
    /// <summary>ETN과세유형</summary>
    [DataMember, JsonProperty("ETN과세유형")]
    public string? ETN과세유형
    {
        get; set;
    }
}