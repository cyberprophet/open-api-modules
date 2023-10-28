using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별체결잔고</summary>
public class MultiOpw00005
{
    /// <summary>신용구분</summary>
    [DataMember, JsonProperty("신용구분")]
    public string? 신용구분
    {
        get; set;
    }
    /// <summary>대출일</summary>
    [DataMember, JsonProperty("대출일")]
    public string? 대출일
    {
        get; set;
    }
    /// <summary>만기일</summary>
    [DataMember, JsonProperty("만기일")]
    public string? 만기일
    {
        get; set;
    }
    /// <summary>종목번호</summary>
    [DataMember, JsonProperty("종목번호")]
    public string? 종목번호
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>결제잔고</summary>
    [DataMember, JsonProperty("결제잔고")]
    public string? 결제잔고
    {
        get; set;
    }
    /// <summary>현재잔고</summary>
    [DataMember, JsonProperty("현재잔고")]
    public string? 현재잔고
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>매입단가</summary>
    [DataMember, JsonProperty("매입단가")]
    public string? 매입단가
    {
        get; set;
    }
    /// <summary>매입금액</summary>
    [DataMember, JsonProperty("매입금액")]
    public string? 매입금액
    {
        get; set;
    }
    /// <summary>평가금액</summary>
    [DataMember, JsonProperty("평가금액")]
    public string? 평가금액
    {
        get; set;
    }
    /// <summary>평가손익</summary>
    [DataMember, JsonProperty("평가손익")]
    public string? 평가손익
    {
        get; set;
    }
    /// <summary>손익률</summary>
    [DataMember, JsonProperty("손익률")]
    public string? 손익률
    {
        get; set;
    }
}