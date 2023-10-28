using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW종목상세</summary>
public class MultiOPT30007
{
    /// <summary>기초자산코드</summary>
    [DataMember, JsonProperty("기초자산코드")]
    public string? 기초자산코드
    {
        get; set;
    }
    /// <summary>발행사명</summary>
    [DataMember, JsonProperty("발행사명")]
    public string? 발행사명
    {
        get; set;
    }
    /// <summary>회차</summary>
    [DataMember, JsonProperty("회차")]
    public string? 회차
    {
        get; set;
    }
    /// <summary>기초자산명</summary>
    [DataMember, JsonProperty("기초자산명")]
    public string? 기초자산명
    {
        get; set;
    }
    /// <summary>콜풋구분</summary>
    [DataMember, JsonProperty("콜풋구분")]
    public string? 콜풋구분
    {
        get; set;
    }
    /// <summary>신주인수권행사종료일</summary>
    [DataMember, JsonProperty("신주인수권행사종료일")]
    public string? 신주인수권행사종료일
    {
        get; set;
    }
    /// <summary>잔존일수</summary>
    [DataMember, JsonProperty("잔존일수")]
    public string? 잔존일수
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
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? 누적거래량
    {
        get; set;
    }
    /// <summary>거래량대비</summary>
    [DataMember, JsonProperty("거래량대비")]
    public string? 거래량대비
    {
        get; set;
    }
    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금")]
    public string? 누적거래대금
    {
        get; set;
    }
    /// <summary>매도호가</summary>
    [DataMember, JsonProperty("매도호가")]
    public string? 매도호가
    {
        get; set;
    }
    /// <summary>매수호가</summary>
    [DataMember, JsonProperty("매수호가")]
    public string? 매수호가
    {
        get; set;
    }
    /// <summary>패리티</summary>
    [DataMember, JsonProperty("패리티")]
    public string? 패리티
    {
        get; set;
    }
    /// <summary>기어링비율</summary>
    [DataMember, JsonProperty("기어링비율")]
    public string? 기어링비율
    {
        get; set;
    }
    /// <summary>손익분기율</summary>
    [DataMember, JsonProperty("손익분기율")]
    public string? 손익분기율
    {
        get; set;
    }
    /// <summary>자본지지점</summary>
    [DataMember, JsonProperty("자본지지점")]
    public string? 자본지지점
    {
        get; set;
    }
    /// <summary>이론가</summary>
    [DataMember, JsonProperty("이론가")]
    public string? 이론가
    {
        get; set;
    }
    /// <summary>내재변동성</summary>
    [DataMember, JsonProperty("내재변동성")]
    public string? 내재변동성
    {
        get; set;
    }
    /// <summary>델타</summary>
    [DataMember, JsonProperty("델타")]
    public string? 델타
    {
        get; set;
    }
    /// <summary>레버리지</summary>
    [DataMember, JsonProperty("레버리지")]
    public string? 레버리지
    {
        get; set;
    }
    /// <summary>LP보유비율</summary>
    [DataMember, JsonProperty("LP보유비율")]
    public string? LP보유비율
    {
        get; set;
    }
    /// <summary>행사가격</summary>
    [DataMember, JsonProperty("행사가격")]
    public string? 행사가격
    {
        get; set;
    }
    /// <summary>전환비율</summary>
    [DataMember, JsonProperty("전환비율")]
    public string? 전환비율
    {
        get; set;
    }
    /// <summary>최종거래일</summary>
    [DataMember, JsonProperty("최종거래일")]
    public string? 최종거래일
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>조기종료여부</summary>
    [DataMember, JsonProperty("조기종료여부")]
    public string? 조기종료여부
    {
        get; set;
    }
    /// <summary>KO접근도</summary>
    [DataMember, JsonProperty("KO접근도")]
    public string? KO접근도
    {
        get; set;
    }
}