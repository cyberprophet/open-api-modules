using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>시간대별전일비거래비중</summary>
public class MultiOPT10071
{
    /// <summary>시간</summary>
    [DataMember, JsonProperty("시간")]
    public string? 시간
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
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
    /// <summary>체결거래량</summary>
    [DataMember, JsonProperty("체결거래량")]
    public string? 체결거래량
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? 누적거래량
    {
        get; set;
    }
    /// <summary>순간비율</summary>
    [DataMember, JsonProperty("순간비율")]
    public string? 순간비율
    {
        get; set;
    }
    /// <summary>누적비율</summary>
    [DataMember, JsonProperty("누적비율")]
    public string? 누적비율
    {
        get; set;
    }
}