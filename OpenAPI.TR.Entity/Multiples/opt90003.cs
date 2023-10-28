using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>프로그램순매수상위50</summary>
public class MultiOpt90003
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
    /// <summary>등락기호</summary>
    [DataMember, JsonProperty("등락기호")]
    public string? 등락기호
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
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? 누적거래량
    {
        get; set;
    }
    /// <summary>프로그램매도금액</summary>
    [DataMember, JsonProperty("프로그램매도금액")]
    public string? 프로그램매도금액
    {
        get; set;
    }
    /// <summary>프로그램매수금액</summary>
    [DataMember, JsonProperty("프로그램매수금액")]
    public string? 프로그램매수금액
    {
        get; set;
    }
    /// <summary>프로그램순매수금액</summary>
    [DataMember, JsonProperty("프로그램순매수금액")]
    public string? 프로그램순매수금액
    {
        get; set;
    }
}