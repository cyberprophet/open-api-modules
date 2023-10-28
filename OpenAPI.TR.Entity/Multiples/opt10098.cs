using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>시간외단일가등락율순위</summary>
public class MultiOpt10098
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
    /// <summary>등락률</summary>
    [DataMember, JsonProperty("등락률")]
    public string? 등락률
    {
        get; set;
    }
    /// <summary>매도총잔량</summary>
    [DataMember, JsonProperty("매도총잔량")]
    public string? 매도총잔량
    {
        get; set;
    }
    /// <summary>매수총잔량</summary>
    [DataMember, JsonProperty("매수총잔량")]
    public string? 매수총잔량
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? 누적거래량
    {
        get; set;
    }
    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금")]
    public string? 누적거래대금
    {
        get; set;
    }
    /// <summary>당일종가</summary>
    [DataMember, JsonProperty("당일종가")]
    public string? 당일종가
    {
        get; set;
    }
    /// <summary>당일종가등락률</summary>
    [DataMember, JsonProperty("당일종가등락률")]
    public string? 당일종가등락률
    {
        get; set;
    }
}