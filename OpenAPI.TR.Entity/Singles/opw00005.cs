using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>체결잔고</summary>
public class SingleOpw00005
{
    /// <summary>예수금</summary>
    [DataMember, JsonProperty("예수금")]
    public string? 예수금
    {
        get; set;
    }
    /// <summary>예수금D+1</summary>
    [DataMember, JsonProperty("예수금D+1")]
    public string? 예수금D1
    {
        get; set;
    }
    /// <summary>예수금D+2</summary>
    [DataMember, JsonProperty("예수금D+2")]
    public string? 예수금D2
    {
        get; set;
    }
    /// <summary>출금가능금액</summary>
    [DataMember, JsonProperty("출금가능금액")]
    public string? 출금가능금액
    {
        get; set;
    }
    /// <summary>미수확보금</summary>
    [DataMember, JsonProperty("미수확보금")]
    public string? 미수확보금
    {
        get; set;
    }
    /// <summary>대용금</summary>
    [DataMember, JsonProperty("대용금")]
    public string? 대용금
    {
        get; set;
    }
    /// <summary>권리대용금</summary>
    [DataMember, JsonProperty("권리대용금")]
    public string? 권리대용금
    {
        get; set;
    }
    /// <summary>주문가능현금</summary>
    [DataMember, JsonProperty("주문가능현금")]
    public string? 주문가능현금
    {
        get; set;
    }
    /// <summary>현금미수금</summary>
    [DataMember, JsonProperty("현금미수금")]
    public string? 현금미수금
    {
        get; set;
    }
    /// <summary>신용이자미납금</summary>
    [DataMember, JsonProperty("신용이자미납금")]
    public string? 신용이자미납금
    {
        get; set;
    }
    /// <summary>기타대여금</summary>
    [DataMember, JsonProperty("기타대여금")]
    public string? 기타대여금
    {
        get; set;
    }
    /// <summary>미상환융자금</summary>
    [DataMember, JsonProperty("미상환융자금")]
    public string? 미상환융자금
    {
        get; set;
    }
    /// <summary>증거금현금</summary>
    [DataMember, JsonProperty("증거금현금")]
    public string? 증거금현금
    {
        get; set;
    }
    /// <summary>증거금대용</summary>
    [DataMember, JsonProperty("증거금대용")]
    public string? 증거금대용
    {
        get; set;
    }
    /// <summary>주식매수총액</summary>
    [DataMember, JsonProperty("주식매수총액")]
    public string? 주식매수총액
    {
        get; set;
    }
    /// <summary>평가금액합계</summary>
    [DataMember, JsonProperty("평가금액합계")]
    public string? 평가금액합계
    {
        get; set;
    }
    /// <summary>총손익합계</summary>
    [DataMember, JsonProperty("총손익합계")]
    public string? 총손익합계
    {
        get; set;
    }
    /// <summary>총손익률</summary>
    [DataMember, JsonProperty("총손익률")]
    public string? 총손익률
    {
        get; set;
    }
    /// <summary>총재매수가능금액</summary>
    [DataMember, JsonProperty("총재매수가능금액")]
    public string? 총재매수가능금액
    {
        get; set;
    }
    /// <summary>20주문가능금액</summary>
    [DataMember, JsonProperty("20주문가능금액")]
    public string? _20주문가능금액
    {
        get;
        set;
    }
    /// <summary>30주문가능금액</summary>
    [DataMember, JsonProperty("30주문가능금액")]
    public string? _30주문가능금액
    {
        get;
        set;
    }
    /// <summary>40주문가능금액</summary>
    [DataMember, JsonProperty("40주문가능금액")]
    public string? _40주문가능금액
    {
        get;
        set;
    }
    /// <summary>50주문가능금액</summary>
    [DataMember, JsonProperty("50주문가능금액")]
    public string? _50주문가능금액
    {
        get;
        set;
    }
    /// <summary>60주문가능금액</summary>
    [DataMember, JsonProperty("60주문가능금액")]
    public string? _60주문가능금액
    {
        get;
        set;
    }
    /// <summary>100주문가능금액</summary>
    [DataMember, JsonProperty("100주문가능금액")]
    public string? _100주문가능금액
    {
        get;
        set;
    }
    /// <summary>신용융자합계</summary>
    [DataMember, JsonProperty("신용융자합계")]
    public string? 신용융자합계
    {
        get; set;
    }
    /// <summary>신용융자대주합계</summary>
    [DataMember, JsonProperty("신용융자대주합계")]
    public string? 신용융자대주합계
    {
        get; set;
    }
    /// <summary>신용담보비율</summary>
    [DataMember, JsonProperty("신용담보비율")]
    public string? 신용담보비율
    {
        get; set;
    }
    /// <summary>예탁담보대출금액</summary>
    [DataMember, JsonProperty("예탁담보대출금액")]
    public string? 예탁담보대출금액
    {
        get; set;
    }
    /// <summary>매도담보대출금액</summary>
    [DataMember, JsonProperty("매도담보대출금액")]
    public string? 매도담보대출금액
    {
        get; set;
    }
    /// <summary>조회건수</summary>
    [DataMember, JsonProperty("조회건수")]
    public string? 조회건수
    {
        get; set;
    }
}