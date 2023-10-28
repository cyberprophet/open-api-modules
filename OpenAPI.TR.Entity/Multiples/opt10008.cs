using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식외국인</summary>
public class MultiOpt10008
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
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? 전일대비
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? 거래량
    {
        get; set;
    }
    /// <summary>변동수량</summary>
    [DataMember, JsonProperty("변동수량")]
    public string? 변동수량
    {
        get; set;
    }
    /// <summary>보유주식수</summary>
    [DataMember, JsonProperty("보유주식수")]
    public string? 보유주식수
    {
        get; set;
    }
    /// <summary>비중</summary>
    [DataMember, JsonProperty("비중")]
    public string? 비중
    {
        get; set;
    }
    /// <summary>취득가능주식수</summary>
    [DataMember, JsonProperty("취득가능주식수")]
    public string? 취득가능주식수
    {
        get; set;
    }
    /// <summary>외국인한도</summary>
    [DataMember, JsonProperty("외국인한도")]
    public string? 외국인한도
    {
        get; set;
    }
    /// <summary>외국인한도증감</summary>
    [DataMember, JsonProperty("외국인한도증감")]
    public string? 외국인한도증감
    {
        get; set;
    }
    /// <summary>한도소진률</summary>
    [DataMember, JsonProperty("한도소진률")]
    public string? 한도소진률
    {
        get; set;
    }
}