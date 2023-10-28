using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵잔고</summary>
public class MultiOPT50027
{
    /// <summary>계좌번호</summary>
    [DataMember, JsonProperty("계좌번호")]
    public string? 계좌번호
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
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
    /// <summary>보유수량</summary>
    [DataMember, JsonProperty("보유수량")]
    public string? 보유수량
    {
        get; set;
    }
    /// <summary>매입단가</summary>
    [DataMember, JsonProperty("매입단가")]
    public string? 매입단가
    {
        get; set;
    }
    /// <summary>총매입가</summary>
    [DataMember, JsonProperty("총매입가")]
    public string? 총매입가
    {
        get; set;
    }
    /// <summary>주문가능수량</summary>
    [DataMember, JsonProperty("주문가능수량")]
    public string? 주문가능수량
    {
        get; set;
    }
    /// <summary>당일매도수량</summary>
    [DataMember, JsonProperty("당일매도수량")]
    public string? 당일매도수량
    {
        get; set;
    }
    /// <summary>당일매도금액</summary>
    [DataMember, JsonProperty("당일매도금액")]
    public string? 당일매도금액
    {
        get; set;
    }
    /// <summary>당일매수수량</summary>
    [DataMember, JsonProperty("당일매수수량")]
    public string? 당일매수수량
    {
        get; set;
    }
    /// <summary>당일매수금액</summary>
    [DataMember, JsonProperty("당일매수금액")]
    public string? 당일매수금액
    {
        get; set;
    }
    /// <summary>당일매매수수료</summary>
    [DataMember, JsonProperty("당일매매수수료")]
    public string? 당일매매수수료
    {
        get; set;
    }
    /// <summary>당일매매세금</summary>
    [DataMember, JsonProperty("당일매매세금")]
    public string? 당일매매세금
    {
        get; set;
    }
    /// <summary>당일HTS매도수수료</summary>
    [DataMember, JsonProperty("당일HTS매도수수료")]
    public string? 당일HTS매도수수료
    {
        get; set;
    }
    /// <summary>당일HTS매수수수료</summary>
    [DataMember, JsonProperty("당일HTS매수수수료")]
    public string? 당일HTS매수수수료
    {
        get; set;
    }
    /// <summary>D+2매수정산금</summary>
    [DataMember, JsonProperty("D+2매수정산금")]
    public string? D2매수정산금
    {
        get; set;
    }
    /// <summary>당일매도손익</summary>
    [DataMember, JsonProperty("당일매도손익")]
    public string? 당일매도손익
    {
        get; set;
    }
    /// <summary>당일순매수량</summary>
    [DataMember, JsonProperty("당일순매수량")]
    public string? 당일순매수량
    {
        get; set;
    }
    /// <summary>매매구분</summary>
    [DataMember, JsonProperty("매매구분")]
    public string? 매매구분
    {
        get; set;
    }
    /// <summary>당일총매도손익</summary>
    [DataMember, JsonProperty("당일총매도손익")]
    public string? 당일총매도손익
    {
        get; set;
    }
    /// <summary>예수금</summary>
    [DataMember, JsonProperty("예수금")]
    public string? 예수금
    {
        get; set;
    }
    /// <summary>최우선매도호가</summary>
    [DataMember, JsonProperty("최우선매도호가")]
    public string? 최우선매도호가
    {
        get; set;
    }
    /// <summary>최우선매수호가</summary>
    [DataMember, JsonProperty("최우선매수호가")]
    public string? 최우선매수호가
    {
        get; set;
    }
    /// <summary>결제잔고</summary>
    [DataMember, JsonProperty("결제잔고")]
    public string? 결제잔고
    {
        get; set;
    }
    /// <summary>결제금액</summary>
    [DataMember, JsonProperty("결제금액")]
    public string? 결제금액
    {
        get; set;
    }
    /// <summary>전일매도수량</summary>
    [DataMember, JsonProperty("전일매도수량")]
    public string? 전일매도수량
    {
        get; set;
    }
    /// <summary>전일매수수량</summary>
    [DataMember, JsonProperty("전일매수수량")]
    public string? 전일매수수량
    {
        get; set;
    }
    /// <summary>전일매도금액</summary>
    [DataMember, JsonProperty("전일매도금액")]
    public string? 전일매도금액
    {
        get; set;
    }
    /// <summary>전일매수금액</summary>
    [DataMember, JsonProperty("전일매수금액")]
    public string? 전일매수금액
    {
        get; set;
    }
    /// <summary>전일순매수량</summary>
    [DataMember, JsonProperty("전일순매수량")]
    public string? 전일순매수량
    {
        get; set;
    }
    /// <summary>손익율</summary>
    [DataMember, JsonProperty("손익율")]
    public string? 손익율
    {
        get; set;
    }
    /// <summary>신용금액</summary>
    [DataMember, JsonProperty("신용금액")]
    public string? 신용금액
    {
        get; set;
    }
    /// <summary>신용이자</summary>
    [DataMember, JsonProperty("신용이자")]
    public string? 신용이자
    {
        get; set;
    }
    /// <summary>만기일</summary>
    [DataMember, JsonProperty("만기일")]
    public string? 만기일
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public string? 기준가
    {
        get; set;
    }
    /// <summary>하한가</summary>
    [DataMember, JsonProperty("하한가")]
    public string? 하한가
    {
        get; set;
    }
    /// <summary>상한가</summary>
    [DataMember, JsonProperty("상한가")]
    public string? 상한가
    {
        get; set;
    }
    /// <summary>담보대출수량</summary>
    [DataMember, JsonProperty("담보대출수량")]
    public string? 담보대출수량
    {
        get; set;
    }
    /// <summary>연누적거래대금</summary>
    [DataMember, JsonProperty("연누적거래대금")]
    public string? 연누적거래대금
    {
        get; set;
    }
}