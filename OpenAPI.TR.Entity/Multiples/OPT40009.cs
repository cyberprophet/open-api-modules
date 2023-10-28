using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETFNAV배열</summary>
public class MultiOPT40009
{
    /// <summary>NAV</summary>
    [DataMember, JsonProperty("NAV")]
    public string? NAV
    {
        get; set;
    }
    /// <summary>NAV전일대비</summary>
    [DataMember, JsonProperty("NAV전일대비")]
    public string? NAV전일대비
    {
        get; set;
    }
    /// <summary>NAV등락율</summary>
    [DataMember, JsonProperty("NAV등락율")]
    public string? NAV등락율
    {
        get; set;
    }
    /// <summary>추적오차율</summary>
    [DataMember, JsonProperty("추적오차율")]
    public string? 추적오차율
    {
        get; set;
    }
    /// <summary>괴리율</summary>
    [DataMember, JsonProperty("괴리율")]
    public string? 괴리율
    {
        get; set;
    }
    /// <summary>주식수</summary>
    [DataMember, JsonProperty("주식수")]
    public string? 주식수
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public string? 기준가
    {
        get; set;
    }
    /// <summary>외인보유수량</summary>
    [DataMember, JsonProperty("외인보유수량")]
    public string? 외인보유수량
    {
        get; set;
    }
    /// <summary>대용가</summary>
    [DataMember, JsonProperty("대용가")]
    public string? 대용가
    {
        get; set;
    }
    /// <summary>모름</summary>
    [DataMember, JsonProperty("모름")]
    public string? 모름
    {
        get; set;
    }
    /// <summary>환산가격</summary>
    [DataMember, JsonProperty("환산가격")]
    public string? 환산가격
    {
        get; set;
    }
    /// <summary>DR/주</summary>
    [DataMember, JsonProperty("DR/주")]
    public string? DR주
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