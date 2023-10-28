using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>외국계창구매매상위</summary>
public class MultiOpt10037
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
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? 등락율
    {
        get; set;
    }
    /// <summary>매도거래량</summary>
    [DataMember, JsonProperty("매도거래량")]
    public string? 매도거래량
    {
        get; set;
    }
    /// <summary>매수거래량</summary>
    [DataMember, JsonProperty("매수거래량")]
    public string? 매수거래량
    {
        get; set;
    }
    /// <summary>순매수거래량</summary>
    [DataMember, JsonProperty("순매수거래량")]
    public string? 순매수거래량
    {
        get; set;
    }
    /// <summary>순매수대금</summary>
    [DataMember, JsonProperty("순매수대금")]
    public string? 순매수대금
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? 거래량
    {
        get; set;
    }
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금")]
    public string? 거래대금
    {
        get; set;
    }
}