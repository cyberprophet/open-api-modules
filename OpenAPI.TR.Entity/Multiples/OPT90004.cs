using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별프로그램매매현황</summary>
public class MultiOPT90004
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
    /// <summary>매수체결수량</summary>
    [DataMember, JsonProperty("매수체결수량")]
    public string? 매수체결수량
    {
        get; set;
    }
    /// <summary>매수체결금액</summary>
    [DataMember, JsonProperty("매수체결금액")]
    public string? 매수체결금액
    {
        get; set;
    }
    /// <summary>매도체결수량</summary>
    [DataMember, JsonProperty("매도체결수량")]
    public string? 매도체결수량
    {
        get; set;
    }
    /// <summary>매도체결금액</summary>
    [DataMember, JsonProperty("매도체결금액")]
    public string? 매도체결금액
    {
        get; set;
    }
    /// <summary>순매수대금</summary>
    [DataMember, JsonProperty("순매수대금")]
    public string? 순매수대금
    {
        get; set;
    }
    /// <summary>전체거래비율</summary>
    [DataMember, JsonProperty("전체거래비율")]
    public string? 전체거래비율
    {
        get; set;
    }
}