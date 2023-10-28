using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF일별추이</summary>
public class MultiOPT40005
{
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? 체결시간
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
    /// <summary>대비율</summary>
    [DataMember, JsonProperty("대비율")]
    public string? 대비율
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
    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금")]
    public string? 누적거래대금
    {
        get; set;
    }
    /// <summary>NAV/지수괴리율</summary>
    [DataMember, JsonProperty("NAV/지수괴리율")]
    public string? NAV지수괴리율
    {
        get; set;
    }
    /// <summary>NAV/ETF괴리율</summary>
    [DataMember, JsonProperty("NAV/ETF괴리율")]
    public string? NAVETF괴리율
    {
        get; set;
    }
    /// <summary>추적오차율</summary>
    [DataMember, JsonProperty("추적오차율")]
    public string? 추적오차율
    {
        get; set;
    }
    /// <summary>추적지수</summary>
    [DataMember, JsonProperty("추적지수")]
    public string? 추적지수
    {
        get; set;
    }
    /// <summary>추적대비기호</summary>
    [DataMember, JsonProperty("추적대비기호")]
    public string? 추적대비기호
    {
        get; set;
    }
    /// <summary>추적전일대비</summary>
    [DataMember, JsonProperty("추적전일대비")]
    public string? 추적전일대비
    {
        get; set;
    }
}