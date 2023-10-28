using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>공매도추이</summary>
public class MultiOpt10014
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
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? 거래량
    {
        get; set;
    }
    /// <summary>공매도량</summary>
    [DataMember, JsonProperty("공매도량")]
    public string? 공매도량
    {
        get; set;
    }
    /// <summary>매매비중</summary>
    [DataMember, JsonProperty("매매비중")]
    public string? 매매비중
    {
        get; set;
    }
    /// <summary>공매도거래대금</summary>
    [DataMember, JsonProperty("공매도거래대금")]
    public string? 공매도거래대금
    {
        get; set;
    }
    /// <summary>공매도평균가</summary>
    [DataMember, JsonProperty("공매도평균가")]
    public string? 공매도평균가
    {
        get; set;
    }
}