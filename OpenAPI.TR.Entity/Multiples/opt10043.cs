using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>거래원매물대분석</summary>
public class MultiOpt10043
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? 일자
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
    /// <summary>매도량</summary>
    [DataMember, JsonProperty("매도량")]
    public string? 매도량
    {
        get; set;
    }
    /// <summary>매수량</summary>
    [DataMember, JsonProperty("매수량")]
    public string? 매수량
    {
        get; set;
    }
    /// <summary>순매수수량</summary>
    [DataMember, JsonProperty("순매수수량")]
    public string? 순매수수량
    {
        get; set;
    }
    /// <summary>거래량합</summary>
    [DataMember, JsonProperty("거래량합")]
    public string? 거래량합
    {
        get; set;
    }
    /// <summary>거래비중</summary>
    [DataMember, JsonProperty("거래비중")]
    public string? 거래비중
    {
        get; set;
    }
}