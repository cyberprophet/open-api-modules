using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별계좌평가현황</summary>
public class MultiOPW00004
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
    /// <summary>보유수량</summary>
    [DataMember, JsonProperty("보유수량")]
    public string? 보유수량
    {
        get; set;
    }
    /// <summary>평균단가</summary>
    [DataMember, JsonProperty("평균단가")]
    public string? 평균단가
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>평가금액</summary>
    [DataMember, JsonProperty("평가금액")]
    public string? 평가금액
    {
        get; set;
    }
    /// <summary>손익금액</summary>
    [DataMember, JsonProperty("손익금액")]
    public string? 손익금액
    {
        get; set;
    }
    /// <summary>손익율</summary>
    [DataMember, JsonProperty("손익율")]
    public string? 손익율
    {
        get; set;
    }
    /// <summary>대출일</summary>
    [DataMember, JsonProperty("대출일")]
    public string? 대출일
    {
        get; set;
    }
    /// <summary>매입금액</summary>
    [DataMember, JsonProperty("매입금액")]
    public string? 매입금액
    {
        get; set;
    }
    /// <summary>결제잔고</summary>
    [DataMember, JsonProperty("결제잔고")]
    public string? 결제잔고
    {
        get; set;
    }
    /// <summary>전일매수수량</summary>
    [DataMember, JsonProperty("전일매수수량")]
    public string? 전일매수수량
    {
        get; set;
    }
    /// <summary>전일매도수량</summary>
    [DataMember, JsonProperty("전일매도수량")]
    public string? 전일매도수량
    {
        get; set;
    }
    /// <summary>금일매수수량</summary>
    [DataMember, JsonProperty("금일매수수량")]
    public string? 금일매수수량
    {
        get; set;
    }
    /// <summary>금일매도수량</summary>
    [DataMember, JsonProperty("금일매도수량")]
    public string? 금일매도수량
    {
        get; set;
    }
}