using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>장중투자자별매매</summary>
public class MultiOpt10063
{
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
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? 누적거래량
    {
        get; set;
    }
    /// <summary>순매수금액</summary>
    [DataMember, JsonProperty("순매수금액")]
    public string? 순매수금액
    {
        get; set;
    }
    /// <summary>이전순매수금액</summary>
    [DataMember, JsonProperty("이전순매수금액")]
    public string? 이전순매수금액
    {
        get; set;
    }
    /// <summary>순매수금액증감</summary>
    [DataMember, JsonProperty("순매수금액증감")]
    public string? 순매수금액증감
    {
        get; set;
    }
    /// <summary>매수금액</summary>
    [DataMember, JsonProperty("매수금액")]
    public string? 매수금액
    {
        get; set;
    }
    /// <summary>매수금액증감</summary>
    [DataMember, JsonProperty("매수금액증감")]
    public string? 매수금액증감
    {
        get; set;
    }
    /// <summary>매도금액</summary>
    [DataMember, JsonProperty("매도금액")]
    public string? 매도금액
    {
        get; set;
    }
    /// <summary>매도금액증감</summary>
    [DataMember, JsonProperty("매도금액증감")]
    public string? 매도금액증감
    {
        get; set;
    }
    /// <summary>순매수수량</summary>
    [DataMember, JsonProperty("순매수수량")]
    public string? 순매수수량
    {
        get; set;
    }
    /// <summary>이점시전순매수수량</summary>
    [DataMember, JsonProperty("이점시전순매수수량")]
    public string? 이점시전순매수수량
    {
        get; set;
    }
    /// <summary>순매수증감</summary>
    [DataMember, JsonProperty("순매수증감")]
    public string? 순매수증감
    {
        get; set;
    }
    /// <summary>매수수량</summary>
    [DataMember, JsonProperty("매수수량")]
    public string? 매수수량
    {
        get; set;
    }
    /// <summary>매수수량증감</summary>
    [DataMember, JsonProperty("매수수량증감")]
    public string? 매수수량증감
    {
        get; set;
    }
    /// <summary>매도수량</summary>
    [DataMember, JsonProperty("매도수량")]
    public string? 매도수량
    {
        get; set;
    }
    /// <summary>매도수량증감</summary>
    [DataMember, JsonProperty("매도수량증감")]
    public string? 매도수량증감
    {
        get; set;
    }
}