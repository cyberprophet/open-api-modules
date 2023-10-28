using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물전체시세</summary>
public class SingleOPTFOFID
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
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? 전일대비
    {
        get; set;
    }
    /// <summary>매도호가2</summary>
    [DataMember, JsonProperty("매도호가2")]
    public string? 매도호가2
    {
        get; set;
    }
    /// <summary>매도호가1</summary>
    [DataMember, JsonProperty("매도호가1")]
    public string? 매도호가1
    {
        get; set;
    }
    /// <summary>매수호가1</summary>
    [DataMember, JsonProperty("매수호가1")]
    public string? 매수호가1
    {
        get; set;
    }
    /// <summary>매수호가2</summary>
    [DataMember, JsonProperty("매수호가2")]
    public string? 매수호가2
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? 거래량
    {
        get; set;
    }
    /// <summary>거래량전일대비</summary>
    [DataMember, JsonProperty("거래량전일대비")]
    public string? 거래량전일대비
    {
        get; set;
    }
    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금")]
    public string? 누적거래대금
    {
        get; set;
    }
    /// <summary>미결제약정</summary>
    [DataMember, JsonProperty("미결제약정")]
    public string? 미결제약정
    {
        get; set;
    }
    /// <summary>미결제약정전일대비</summary>
    [DataMember, JsonProperty("미결제약정전일대비")]
    public string? 미결제약정전일대비
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
    /// <summary>이론가</summary>
    [DataMember, JsonProperty("이론가")]
    public string? 이론가
    {
        get; set;
    }
    /// <summary>괴리율</summary>
    [DataMember, JsonProperty("괴리율")]
    public string? 괴리율
    {
        get; set;
    }
    /// <summary>시장베이시스</summary>
    [DataMember, JsonProperty("시장베이시스")]
    public string? 시장베이시스
    {
        get; set;
    }
    /// <summary>이론베이시스</summary>
    [DataMember, JsonProperty("이론베이시스")]
    public string? 이론베이시스
    {
        get; set;
    }
    /// <summary>행사가</summary>
    [DataMember, JsonProperty("행사가")]
    public string? 행사가
    {
        get; set;
    }
    /// <summary>지수환산</summary>
    [DataMember, JsonProperty("지수환산")]
    public string? 지수환산
    {
        get; set;
    }
    /// <summary>대비기호</summary>
    [DataMember, JsonProperty("대비기호")]
    public string? 대비기호
    {
        get; set;
    }
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? 등락율
    {
        get; set;
    }
    /// <summary>매수수량</summary>
    [DataMember, JsonProperty("매수수량")]
    public string? 매수수량
    {
        get; set;
    }
    /// <summary>매수호가총건수</summary>
    [DataMember, JsonProperty("매수호가총건수")]
    public string? 매수호가총건수
    {
        get; set;
    }
    /// <summary>매도호가총건수</summary>
    [DataMember, JsonProperty("매도호가총건수")]
    public string? 매도호가총건수
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public string? 기준가
    {
        get; set;
    }
    /// <summary>잔존일수</summary>
    [DataMember, JsonProperty("잔존일수")]
    public string? 잔존일수
    {
        get; set;
    }
    /// <summary>영업일기준잔존일</summary>
    [DataMember, JsonProperty("영업일기준잔존일")]
    public string? 영업일기준잔존일
    {
        get; set;
    }
}