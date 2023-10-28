using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌별주문체결내역상세</summary>
public class MultiOPW00007
{
    /// <summary>주문번호</summary>
    [DataMember, JsonProperty("주문번호")]
    public string? 주문번호
    {
        get; set;
    }
    /// <summary>종목번호</summary>
    [DataMember, JsonProperty("종목번호")]
    public string? 종목번호
    {
        get; set;
    }
    /// <summary>매매구분</summary>
    [DataMember, JsonProperty("매매구분")]
    public string? 매매구분
    {
        get; set;
    }
    /// <summary>신용구분</summary>
    [DataMember, JsonProperty("신용구분")]
    public string? 신용구분
    {
        get; set;
    }
    /// <summary>주문수량</summary>
    [DataMember, JsonProperty("주문수량")]
    public string? 주문수량
    {
        get; set;
    }
    /// <summary>주문단가</summary>
    [DataMember, JsonProperty("주문단가")]
    public string? 주문단가
    {
        get; set;
    }
    /// <summary>확인수량</summary>
    [DataMember, JsonProperty("확인수량")]
    public string? 확인수량
    {
        get; set;
    }
    /// <summary>접수구분</summary>
    [DataMember, JsonProperty("접수구분")]
    public string? 접수구분
    {
        get; set;
    }
    /// <summary>반대여부</summary>
    [DataMember, JsonProperty("반대여부")]
    public string? 반대여부
    {
        get; set;
    }
    /// <summary>주문시간</summary>
    [DataMember, JsonProperty("주문시간")]
    public string? 주문시간
    {
        get; set;
    }
    /// <summary>원주문</summary>
    [DataMember, JsonProperty("원주문")]
    public string? 원주문
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>주문구분</summary>
    [DataMember, JsonProperty("주문구분")]
    public string? 주문구분
    {
        get; set;
    }
    /// <summary>대출일</summary>
    [DataMember, JsonProperty("대출일")]
    public string? 대출일
    {
        get; set;
    }
    /// <summary>체결수량</summary>
    [DataMember, JsonProperty("체결수량")]
    public string? 체결수량
    {
        get; set;
    }
    /// <summary>체결단가</summary>
    [DataMember, JsonProperty("체결단가")]
    public string? 체결단가
    {
        get; set;
    }
    /// <summary>주문잔량</summary>
    [DataMember, JsonProperty("주문잔량")]
    public string? 주문잔량
    {
        get; set;
    }
    /// <summary>통신구분</summary>
    [DataMember, JsonProperty("통신구분")]
    public string? 통신구분
    {
        get; set;
    }
    /// <summary>정정취소</summary>
    [DataMember, JsonProperty("정정취소")]
    public string? 정정취소
    {
        get; set;
    }
    /// <summary>확인시간</summary>
    [DataMember, JsonProperty("확인시간")]
    public string? 확인시간
    {
        get; set;
    }
}