using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF시간대별체결</summary>
public class SingleOpt40007
{
    /// <summary>종목분류</summary>
    [DataMember, JsonProperty("종목분류")]
    public string? 종목분류
    {
        get; set;
    }
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
    /// <summary>ETF대상지수코드</summary>
    [DataMember, JsonProperty("ETF대상지수코드")]
    public string? ETF대상지수코드
    {
        get; set;
    }
    /// <summary>대상지수대비율</summary>
    [DataMember, JsonProperty("대상지수대비율")]
    public string? 대상지수대비율
    {
        get; set;
    }
    /// <summary>원주가격</summary>
    [DataMember, JsonProperty("원주가격")]
    public string? 원주가격
    {
        get; set;
    }
}