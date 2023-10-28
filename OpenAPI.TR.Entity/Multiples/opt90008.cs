using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목시간별프로그램매매추이</summary>
public class MultiOpt90008
{
    /// <summary>시간</summary>
    [DataMember, JsonProperty("시간")]
    public string? 시간
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
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? 거래량
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
    /// <summary>프로그램순매수금액증감</summary>
    [DataMember, JsonProperty("프로그램순매수금액증감")]
    public string? 프로그램순매수금액증감
    {
        get; set;
    }
    /// <summary>프로그램매도수량</summary>
    [DataMember, JsonProperty("프로그램매도수량")]
    public string? 프로그램매도수량
    {
        get; set;
    }
    /// <summary>프로그램매수수량</summary>
    [DataMember, JsonProperty("프로그램매수수량")]
    public string? 프로그램매수수량
    {
        get; set;
    }
    /// <summary>프로그램순매수수량</summary>
    [DataMember, JsonProperty("프로그램순매수수량")]
    public string? 프로그램순매수수량
    {
        get; set;
    }
    /// <summary>프로그램순매수수량증감</summary>
    [DataMember, JsonProperty("프로그램순매수수량증감")]
    public string? 프로그램순매수수량증감
    {
        get; set;
    }
    /// <summary>기준가시간</summary>
    [DataMember, JsonProperty("기준가시간")]
    public string? 기준가시간
    {
        get; set;
    }
    /// <summary>대차거래상환주수합</summary>
    [DataMember, JsonProperty("대차거래상환주수합")]
    public string? 대차거래상환주수합
    {
        get; set;
    }
    /// <summary>잔고수주합</summary>
    [DataMember, JsonProperty("잔고수주합")]
    public string? 잔고수주합
    {
        get; set;
    }
}