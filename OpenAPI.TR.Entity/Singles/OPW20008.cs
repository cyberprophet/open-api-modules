using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌별결제예상내역조회</summary>
public class SingleOPW20008
{
    /// <summary>계좌명</summary>
    [DataMember, JsonProperty("계좌명")]
    public string? 계좌명
    {
        get; set;
    }
    /// <summary>예탁총액</summary>
    [DataMember, JsonProperty("예탁총액")]
    public string? 예탁총액
    {
        get; set;
    }
    /// <summary>추정예탁총액</summary>
    [DataMember, JsonProperty("추정예탁총액")]
    public string? 추정예탁총액
    {
        get; set;
    }
    /// <summary>예탁현금</summary>
    [DataMember, JsonProperty("예탁현금")]
    public string? 예탁현금
    {
        get; set;
    }
    /// <summary>추정예탁현금</summary>
    [DataMember, JsonProperty("추정예탁현금")]
    public string? 추정예탁현금
    {
        get; set;
    }
    /// <summary>선물당일차금</summary>
    [DataMember, JsonProperty("선물당일차금")]
    public string? 선물당일차금
    {
        get; set;
    }
    /// <summary>선물갱신차금</summary>
    [DataMember, JsonProperty("선물갱신차금")]
    public string? 선물갱신차금
    {
        get; set;
    }
    /// <summary>선물최종결제차금</summary>
    [DataMember, JsonProperty("선물최종결제차금")]
    public string? 선물최종결제차금
    {
        get; set;
    }
    /// <summary>선물예상정산손익</summary>
    [DataMember, JsonProperty("선물예상정산손익")]
    public string? 선물예상정산손익
    {
        get; set;
    }
    /// <summary>옵션매수대금</summary>
    [DataMember, JsonProperty("옵션매수대금")]
    public string? 옵션매수대금
    {
        get; set;
    }
    /// <summary>옵션매도대금</summary>
    [DataMember, JsonProperty("옵션매도대금")]
    public string? 옵션매도대금
    {
        get; set;
    }
    /// <summary>옵션행사차금</summary>
    [DataMember, JsonProperty("옵션행사차금")]
    public string? 옵션행사차금
    {
        get; set;
    }
    /// <summary>옵션배정차금</summary>
    [DataMember, JsonProperty("옵션배정차금")]
    public string? 옵션배정차금
    {
        get; set;
    }
    /// <summary>주식옵션행사대금</summary>
    [DataMember, JsonProperty("주식옵션행사대금")]
    public string? 주식옵션행사대금
    {
        get; set;
    }
    /// <summary>주식옵션배정대금</summary>
    [DataMember, JsonProperty("주식옵션배정대금")]
    public string? 주식옵션배정대금
    {
        get; set;
    }
    /// <summary>인수도대금</summary>
    [DataMember, JsonProperty("인수도대금")]
    public string? 인수도대금
    {
        get; set;
    }
    /// <summary>전일대용매도체결금액</summary>
    [DataMember, JsonProperty("전일대용매도체결금액")]
    public string? 전일대용매도체결금액
    {
        get; set;
    }
    /// <summary>금일대용매도체결금액</summary>
    [DataMember, JsonProperty("금일대용매도체결금액")]
    public string? 금일대용매도체결금액
    {
        get; set;
    }
    /// <summary>선물수수료</summary>
    [DataMember, JsonProperty("선물수수료")]
    public string? 선물수수료
    {
        get; set;
    }
    /// <summary>옵션수수료</summary>
    [DataMember, JsonProperty("옵션수수료")]
    public string? 옵션수수료
    {
        get; set;
    }
    /// <summary>결제가격수신여부</summary>
    [DataMember, JsonProperty("결제가격수신여부")]
    public string? 결제가격수신여부
    {
        get; set;
    }
    /// <summary>유지증거금총액</summary>
    [DataMember, JsonProperty("유지증거금총액")]
    public string? 유지증거금총액
    {
        get; set;
    }
    /// <summary>유지증거금총액부족액</summary>
    [DataMember, JsonProperty("유지증거금총액부족액")]
    public string? 유지증거금총액부족액
    {
        get; set;
    }
    /// <summary>유지증거금현금부족액</summary>
    [DataMember, JsonProperty("유지증거금현금부족액")]
    public string? 유지증거금현금부족액
    {
        get; set;
    }
    /// <summary>옵션잔고평가손익</summary>
    [DataMember, JsonProperty("옵션잔고평가손익")]
    public string? 옵션잔고평가손익
    {
        get; set;
    }
    /// <summary>예탁대용</summary>
    [DataMember, JsonProperty("예탁대용")]
    public string? 예탁대용
    {
        get; set;
    }
    /// <summary>익일결제예정금액</summary>
    [DataMember, JsonProperty("익일결제예정금액")]
    public string? 익일결제예정금액
    {
        get; set;
    }
}