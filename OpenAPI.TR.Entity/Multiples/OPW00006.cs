using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>관리자별주문체결내역</summary>
public class MultiOPW00006
{
    /// <summary>주문번호</summary>
    [DataMember, JsonProperty("주문번호")]
    public string? 주문번호
    {
        get; set;
    }
    /// <summary>원주문번호</summary>
    [DataMember, JsonProperty("원주문번호")]
    public string? 원주문번호
    {
        get; set;
    }
    /// <summary>모주문번호</summary>
    [DataMember, JsonProperty("모주문번호")]
    public string? 모주문번호
    {
        get; set;
    }
    /// <summary>계좌번호</summary>
    [DataMember, JsonProperty("계좌번호")]
    public string? 계좌번호
    {
        get; set;
    }
    /// <summary>계좌명</summary>
    [DataMember, JsonProperty("계좌명")]
    public string? 계좌명
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>정정구분</summary>
    [DataMember, JsonProperty("정정구분")]
    public string? 정정구분
    {
        get; set;
    }
    /// <summary>매도수구분</summary>
    [DataMember, JsonProperty("매도수구분")]
    public string? 매도수구분
    {
        get; set;
    }
    /// <summary>주문구분</summary>
    [DataMember, JsonProperty("주문구분")]
    public string? 주문구분
    {
        get; set;
    }
    /// <summary>통신주문구분</summary>
    [DataMember, JsonProperty("통신주문구분")]
    public string? 통신주문구분
    {
        get; set;
    }
    /// <summary>주문수량</summary>
    [DataMember, JsonProperty("주문수량")]
    public string? 주문수량
    {
        get; set;
    }
    /// <summary>주문지수</summary>
    [DataMember, JsonProperty("주문지수")]
    public string? 주문지수
    {
        get; set;
    }
    /// <summary>주문잔량</summary>
    [DataMember, JsonProperty("주문잔량")]
    public string? 주문잔량
    {
        get; set;
    }
    /// <summary>체결수량</summary>
    [DataMember, JsonProperty("체결수량")]
    public string? 체결수량
    {
        get; set;
    }
    /// <summary>체결지수</summary>
    [DataMember, JsonProperty("체결지수")]
    public string? 체결지수
    {
        get; set;
    }
    /// <summary>접수여부</summary>
    [DataMember, JsonProperty("접수여부")]
    public string? 접수여부
    {
        get; set;
    }
    /// <summary>체결번호</summary>
    [DataMember, JsonProperty("체결번호")]
    public string? 체결번호
    {
        get; set;
    }
}