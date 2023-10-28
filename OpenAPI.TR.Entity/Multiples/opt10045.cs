using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별기관매매추이</summary>
public class MultiOpt10045
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
    /// <summary>기관기간누적</summary>
    [DataMember, JsonProperty("기관기간누적")]
    public string? 기관기간누적
    {
        get; set;
    }
    /// <summary>기관일별순매매수량</summary>
    [DataMember, JsonProperty("기관일별순매매수량")]
    public string? 기관일별순매매수량
    {
        get; set;
    }
    /// <summary>외인기간누적</summary>
    [DataMember, JsonProperty("외인기간누적")]
    public string? 외인기간누적
    {
        get; set;
    }
    /// <summary>외인일별순매매수량</summary>
    [DataMember, JsonProperty("외인일별순매매수량")]
    public string? 외인일별순매매수량
    {
        get; set;
    }
    /// <summary>한도소진율</summary>
    [DataMember, JsonProperty("한도소진율")]
    public string? 한도소진율
    {
        get; set;
    }
}