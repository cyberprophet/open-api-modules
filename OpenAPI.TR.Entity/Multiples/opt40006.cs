using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF시간대별추이</summary>
public class MultiOpt40006
{
    /// <summary>시간</summary>
    [DataMember, JsonProperty("시간")]
    public string? 시간
    {
        get; set;
    }
    /// <summary>종가</summary>
    [DataMember, JsonProperty("종가")]
    public string? 종가
    {
        get; set;
    }
    /// <summary>대비기호</summary>
    [DataMember, JsonProperty("대비기호")]
    public string? 대비기호
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? 전일대비
    {
        get; set;
    }
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? 등락율
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? 거래량
    {
        get; set;
    }
    /// <summary>NAV</summary>
    [DataMember, JsonProperty("NAV")]
    public string? NAV
    {
        get; set;
    }
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금")]
    public string? 거래대금
    {
        get; set;
    }
    /// <summary>NAV지수</summary>
    [DataMember, JsonProperty("NAV지수")]
    public string? NAV지수
    {
        get; set;
    }
    /// <summary>NAVETF</summary>
    [DataMember, JsonProperty("NAVETF")]
    public string? NAVETF
    {
        get; set;
    }
    /// <summary>추적</summary>
    [DataMember, JsonProperty("추적")]
    public string? 추적
    {
        get; set;
    }
    /// <summary>추적지수</summary>
    [DataMember, JsonProperty("추적지수")]
    public string? 추적지수
    {
        get; set;
    }
    /// <summary>추적지수전일대비</summary>
    [DataMember, JsonProperty("추적지수전일대비")]
    public string? 추적지수전일대비
    {
        get; set;
    }
    /// <summary>추적지수전일대비기호</summary>
    [DataMember, JsonProperty("추적지수전일대비기호")]
    public string? 추적지수전일대비기호
    {
        get; set;
    }
}