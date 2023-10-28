using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF전체시세</summary>
public class MultiOpt40004
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
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
    /// <summary>추적오차율</summary>
    [DataMember, JsonProperty("추적오차율")]
    public string? 추적오차율
    {
        get; set;
    }
    /// <summary>과표기준</summary>
    [DataMember, JsonProperty("과표기준")]
    public string? 과표기준
    {
        get; set;
    }
    /// <summary>배당전기준</summary>
    [DataMember, JsonProperty("배당전기준")]
    public string? 배당전기준
    {
        get; set;
    }
    /// <summary>전일배당금</summary>
    [DataMember, JsonProperty("전일배당금")]
    public string? 전일배당금
    {
        get; set;
    }
    /// <summary>추적지수명</summary>
    [DataMember, JsonProperty("추적지수명")]
    public string? 추적지수명
    {
        get; set;
    }
    /// <summary>배수</summary>
    [DataMember, JsonProperty("배수")]
    public string? 배수
    {
        get; set;
    }
    /// <summary>추적지수코드</summary>
    [DataMember, JsonProperty("추적지수코드")]
    public string? 추적지수코드
    {
        get; set;
    }
    /// <summary>추적지수</summary>
    [DataMember, JsonProperty("추적지수")]
    public string? 추적지수
    {
        get; set;
    }
    /// <summary>추적등락율</summary>
    [DataMember, JsonProperty("추적등락율")]
    public string? 추적등락율
    {
        get; set;
    }
}