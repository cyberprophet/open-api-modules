using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>외인한도소진율증가상위</summary>
public class MultiOpt10036
{
    /// <summary>순위</summary>
    [DataMember, JsonProperty("순위")]
    public string? 순위
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>전일대비기호</summary>
    [DataMember, JsonProperty("전일대비기호")]
    public string? 전일대비기호
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
    /// <summary>보유주식수</summary>
    [DataMember, JsonProperty("보유주식수")]
    public string? 보유주식수
    {
        get; set;
    }
    /// <summary>취득가능주식수</summary>
    [DataMember, JsonProperty("취득가능주식수")]
    public string? 취득가능주식수
    {
        get; set;
    }
    /// <summary>기준한도소진율</summary>
    [DataMember, JsonProperty("기준한도소진율")]
    public string? 기준한도소진율
    {
        get; set;
    }
    /// <summary>한도소진율</summary>
    [DataMember, JsonProperty("한도소진율")]
    public string? 한도소진율
    {
        get; set;
    }
    /// <summary>소진율증가</summary>
    [DataMember, JsonProperty("소진율증가")]
    public string? 소진율증가
    {
        get; set;
    }
}