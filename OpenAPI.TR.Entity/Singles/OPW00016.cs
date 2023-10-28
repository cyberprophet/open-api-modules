using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일별계좌수익률상세현황</summary>
public class SingleOPW00016
{
    /// <summary>관리사원번호</summary>
    [DataMember, JsonProperty("관리사원번호")]
    public string? 관리사원번호
    {
        get; set;
    }
    /// <summary>관리자명</summary>
    [DataMember, JsonProperty("관리자명")]
    public string? 관리자명
    {
        get; set;
    }
    /// <summary>관리자지점</summary>
    [DataMember, JsonProperty("관리자지점")]
    public string? 관리자지점
    {
        get; set;
    }
    /// <summary>예수금_초</summary>
    [DataMember, JsonProperty("예수금_초")]
    public string? 예수금_초
    {
        get; set;
    }
    /// <summary>예수금_말</summary>
    [DataMember, JsonProperty("예수금_말")]
    public string? 예수금_말
    {
        get; set;
    }
    /// <summary>유가증권평가금액_초</summary>
    [DataMember, JsonProperty("유가증권평가금액_초")]
    public string? 유가증권평가금액_초
    {
        get; set;
    }
    /// <summary>유가증권평가금액_말</summary>
    [DataMember, JsonProperty("유가증권평가금액_말")]
    public string? 유가증권평가금액_말
    {
        get; set;
    }
    /// <summary>대주담보금_초</summary>
    [DataMember, JsonProperty("대주담보금_초")]
    public string? 대주담보금_초
    {
        get; set;
    }
    /// <summary>대주담보금_말</summary>
    [DataMember, JsonProperty("대주담보금_말")]
    public string? 대주담보금_말
    {
        get; set;
    }
    /// <summary>신용융자금_초</summary>
    [DataMember, JsonProperty("신용융자금_초")]
    public string? 신용융자금_초
    {
        get; set;
    }
    /// <summary>신용융자금_말</summary>
    [DataMember, JsonProperty("신용융자금_말")]
    public string? 신용융자금_말
    {
        get; set;
    }
    /// <summary>현금미수금_초</summary>
    [DataMember, JsonProperty("현금미수금_초")]
    public string? 현금미수금_초
    {
        get; set;
    }
    /// <summary>현금미수금_말</summary>
    [DataMember, JsonProperty("현금미수금_말")]
    public string? 현금미수금_말
    {
        get; set;
    }
    /// <summary>원화대용금_초</summary>
    [DataMember, JsonProperty("원화대용금_초")]
    public string? 원화대용금_초
    {
        get; set;
    }
    /// <summary>원화대용금_말</summary>
    [DataMember, JsonProperty("원화대용금_말")]
    public string? 원화대용금_말
    {
        get; set;
    }
    /// <summary>대주평가금_초</summary>
    [DataMember, JsonProperty("대주평가금_초")]
    public string? 대주평가금_초
    {
        get; set;
    }
    /// <summary>대주평가금_말</summary>
    [DataMember, JsonProperty("대주평가금_말")]
    public string? 대주평가금_말
    {
        get; set;
    }
    /// <summary>권리평가금_초</summary>
    [DataMember, JsonProperty("권리평가금_초")]
    public string? 권리평가금_초
    {
        get; set;
    }
    /// <summary>권리평가금_말</summary>
    [DataMember, JsonProperty("권리평가금_말")]
    public string? 권리평가금_말
    {
        get; set;
    }
    /// <summary>대출금_초</summary>
    [DataMember, JsonProperty("대출금_초")]
    public string? 대출금_초
    {
        get; set;
    }
    /// <summary>대출금_말</summary>
    [DataMember, JsonProperty("대출금_말")]
    public string? 대출금_말
    {
        get; set;
    }
    /// <summary>기타대여금_초</summary>
    [DataMember, JsonProperty("기타대여금_초")]
    public string? 기타대여금_초
    {
        get; set;
    }
    /// <summary>기타대여금_말</summary>
    [DataMember, JsonProperty("기타대여금_말")]
    public string? 기타대여금_말
    {
        get; set;
    }
    /// <summary>신용이자미납금_초</summary>
    [DataMember, JsonProperty("신용이자미납금_초")]
    public string? 신용이자미납금_초
    {
        get; set;
    }
    /// <summary>신용이자미납금_말</summary>
    [DataMember, JsonProperty("신용이자미납금_말")]
    public string? 신용이자미납금_말
    {
        get; set;
    }
    /// <summary>신용이자_초</summary>
    [DataMember, JsonProperty("신용이자_초")]
    public string? 신용이자_초
    {
        get; set;
    }
    /// <summary>신용이자_말</summary>
    [DataMember, JsonProperty("신용이자_말")]
    public string? 신용이자_말
    {
        get; set;
    }
    /// <summary>순자산액계_초</summary>
    [DataMember, JsonProperty("순자산액계_초")]
    public string? 순자산액계_초
    {
        get; set;
    }
    /// <summary>순자산액계_말</summary>
    [DataMember, JsonProperty("순자산액계_말")]
    public string? 순자산액계_말
    {
        get; set;
    }
    /// <summary>투자원금평잔</summary>
    [DataMember, JsonProperty("투자원금평잔")]
    public string? 투자원금평잔
    {
        get; set;
    }
    /// <summary>평가손익</summary>
    [DataMember, JsonProperty("평가손익")]
    public string? 평가손익
    {
        get; set;
    }
    /// <summary>수익률</summary>
    [DataMember, JsonProperty("수익률")]
    public string? 수익률
    {
        get; set;
    }
    /// <summary>회전율</summary>
    [DataMember, JsonProperty("회전율")]
    public string? 회전율
    {
        get; set;
    }
    /// <summary>기간내총입금</summary>
    [DataMember, JsonProperty("기간내총입금")]
    public string? 기간내총입금
    {
        get; set;
    }
    /// <summary>기간내총출금</summary>
    [DataMember, JsonProperty("기간내총출금")]
    public string? 기간내총출금
    {
        get; set;
    }
    /// <summary>기간내총입고</summary>
    [DataMember, JsonProperty("기간내총입고")]
    public string? 기간내총입고
    {
        get; set;
    }
    /// <summary>기간내총출고</summary>
    [DataMember, JsonProperty("기간내총출고")]
    public string? 기간내총출고
    {
        get; set;
    }
    /// <summary>선물대용매도금액</summary>
    [DataMember, JsonProperty("선물대용매도금액")]
    public string? 선물대용매도금액
    {
        get; set;
    }
    /// <summary>위탁대용매도금액</summary>
    [DataMember, JsonProperty("위탁대용매도금액")]
    public string? 위탁대용매도금액
    {
        get; set;
    }
}