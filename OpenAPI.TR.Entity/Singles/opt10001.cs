using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식기본정보</summary>
public class SingleOpt10001
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
    /// <summary>결산월</summary>
    [DataMember, JsonProperty("결산월")]
    public string? 결산월
    {
        get; set;
    }
    /// <summary>액면가</summary>
    [DataMember, JsonProperty("액면가")]
    public string? 액면가
    {
        get; set;
    }
    /// <summary>자본금</summary>
    [DataMember, JsonProperty("자본금")]
    public string? 자본금
    {
        get; set;
    }
    /// <summary>상장주식</summary>
    [DataMember, JsonProperty("상장주식")]
    public string? 상장주식
    {
        get; set;
    }
    /// <summary>신용비율</summary>
    [DataMember, JsonProperty("신용비율")]
    public string? 신용비율
    {
        get; set;
    }
    /// <summary>연중최고</summary>
    [DataMember, JsonProperty("연중최고")]
    public string? 연중최고
    {
        get; set;
    }
    /// <summary>연중최저</summary>
    [DataMember, JsonProperty("연중최저")]
    public string? 연중최저
    {
        get; set;
    }
    /// <summary>시가총액</summary>
    [DataMember, JsonProperty("시가총액")]
    public string? 시가총액
    {
        get; set;
    }
    /// <summary>시가총액비중</summary>
    [DataMember, JsonProperty("시가총액비중")]
    public string? 시가총액비중
    {
        get; set;
    }
    /// <summary>외인소진률</summary>
    [DataMember, JsonProperty("외인소진률")]
    public string? 외인소진률
    {
        get; set;
    }
    /// <summary>대용가</summary>
    [DataMember, JsonProperty("대용가")]
    public string? 대용가
    {
        get; set;
    }
    /// <summary>PER</summary>
    [DataMember, JsonProperty("PER")]
    public string? PER
    {
        get; set;
    }
    /// <summary>EPS</summary>
    [DataMember, JsonProperty("EPS")]
    public string? EPS
    {
        get; set;
    }
    /// <summary>ROE</summary>
    [DataMember, JsonProperty("ROE")]
    public string? ROE
    {
        get; set;
    }
    /// <summary>PBR</summary>
    [DataMember, JsonProperty("PBR")]
    public string? PBR
    {
        get; set;
    }
    /// <summary>EV</summary>
    [DataMember, JsonProperty("EV")]
    public string? EV
    {
        get; set;
    }
    /// <summary>BPS</summary>
    [DataMember, JsonProperty("BPS")]
    public string? BPS
    {
        get; set;
    }
    /// <summary>매출액</summary>
    [DataMember, JsonProperty("매출액")]
    public string? 매출액
    {
        get; set;
    }
    /// <summary>영업이익</summary>
    [DataMember, JsonProperty("영업이익")]
    public string? 영업이익
    {
        get; set;
    }
    /// <summary>당기순이익</summary>
    [DataMember, JsonProperty("당기순이익")]
    public string? 당기순이익
    {
        get; set;
    }
    /// <summary>250최고</summary>
    [DataMember, JsonProperty("250최고")]
    public string? 최고
    {
        get; set;
    }
    /// <summary>250최저</summary>
    [DataMember, JsonProperty("250최저")]
    public string? 최저
    {
        get; set;
    }
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가")]
    public string? 시가
    {
        get; set;
    }
    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가")]
    public string? 고가
    {
        get; set;
    }
    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가")]
    public string? 저가
    {
        get; set;
    }
    /// <summary>상한가</summary>
    [DataMember, JsonProperty("상한가")]
    public string? 상한가
    {
        get; set;
    }
    /// <summary>하한가</summary>
    [DataMember, JsonProperty("하한가")]
    public string? 하한가
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public string? 기준가
    {
        get; set;
    }
    /// <summary>예상체결가</summary>
    [DataMember, JsonProperty("예상체결가")]
    public string? 예상체결가
    {
        get; set;
    }
    /// <summary>예상체결수량</summary>
    [DataMember, JsonProperty("예상체결수량")]
    public string? 예상체결수량
    {
        get; set;
    }
    /// <summary>250최고가일</summary>
    [DataMember, JsonProperty("250최고가일")]
    public string? 최고가일
    {
        get; set;
    }
    /// <summary>250최고가대비율</summary>
    [DataMember, JsonProperty("250최고가대비율")]
    public string? 최고가대비율
    {
        get;
        set;
    }
    /// <summary>250최저가일</summary>
    [DataMember, JsonProperty("250최저가일")]
    public string? 최저가일
    {
        get;
        set;
    }
    /// <summary>250최저가대비율</summary>
    [DataMember, JsonProperty("250최저가대비율")]
    public string? 최저가대비율
    {
        get;
        set;
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
    /// <summary>거래대비</summary>
    [DataMember, JsonProperty("거래대비")]
    public string? 거래대비
    {
        get; set;
    }
    /// <summary>액면가단위</summary>
    [DataMember, JsonProperty("액면가단위")]
    public string? 액면가단위
    {
        get; set;
    }
    /// <summary>유통주식</summary>
    [DataMember, JsonProperty("유통주식")]
    public string? 유통주식
    {
        get; set;
    }
    /// <summary>유통비율</summary>
    [DataMember, JsonProperty("유통비율")]
    public string? 유통비율
    {
        get; set;
    }
}