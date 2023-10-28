using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>콜종목결제월별시세</summary>
public class MultiOPT50021
{
    /// <summary>지수환산</summary>
    [DataMember, JsonProperty("지수환산")]
    public string? 지수환산
    {
        get; set;
    }
    /// <summary>ATM구분</summary>
    [DataMember, JsonProperty("ATM구분")]
    public string? ATM구분
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>행사가</summary>
    [DataMember, JsonProperty("행사가")]
    public string? 행사가
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
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가")]
    public string? 시가
    {
        get; set;
    }
    /// <summary>기준가대비시가등락율</summary>
    [DataMember, JsonProperty("기준가대비시가등락율")]
    public string? 기준가대비시가등락율
    {
        get; set;
    }
    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가")]
    public string? 고가
    {
        get; set;
    }
    /// <summary>기준가대비고가등락율</summary>
    [DataMember, JsonProperty("기준가대비고가등락율")]
    public string? 기준가대비고가등락율
    {
        get; set;
    }
    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가")]
    public string? 저가
    {
        get; set;
    }
    /// <summary>기준가대비저가등락율</summary>
    [DataMember, JsonProperty("기준가대비저가등락율")]
    public string? 기준가대비저가등락율
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public string? 기준가
    {
        get; set;
    }
    /// <summary>매도호가</summary>
    [DataMember, JsonProperty("매도호가")]
    public string? 매도호가
    {
        get; set;
    }
    /// <summary>매도호가수량</summary>
    [DataMember, JsonProperty("매도호가수량")]
    public string? 매도호가수량
    {
        get; set;
    }
    /// <summary>매수호가</summary>
    [DataMember, JsonProperty("매수호가")]
    public string? 매수호가
    {
        get; set;
    }
    /// <summary>매수호가수량</summary>
    [DataMember, JsonProperty("매수호가수량")]
    public string? 매수호가수량
    {
        get; set;
    }
    /// <summary>매도호가총잔량</summary>
    [DataMember, JsonProperty("매도호가총잔량")]
    public string? 매도호가총잔량
    {
        get; set;
    }
    /// <summary>매수호가총잔량</summary>
    [DataMember, JsonProperty("매수호가총잔량")]
    public string? 매수호가총잔량
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? 누적거래량
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
    /// <summary>괴리율</summary>
    [DataMember, JsonProperty("괴리율")]
    public string? 괴리율
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
    /// <summary>내재가치</summary>
    [DataMember, JsonProperty("내재가치")]
    public string? 내재가치
    {
        get; set;
    }
    /// <summary>시간가치</summary>
    [DataMember, JsonProperty("시간가치")]
    public string? 시간가치
    {
        get; set;
    }
    /// <summary>델타</summary>
    [DataMember, JsonProperty("델타")]
    public string? 델타
    {
        get; set;
    }
    /// <summary>감마</summary>
    [DataMember, JsonProperty("감마")]
    public string? 감마
    {
        get; set;
    }
    /// <summary>세타</summary>
    [DataMember, JsonProperty("세타")]
    public string? 세타
    {
        get; set;
    }
    /// <summary>베가</summary>
    [DataMember, JsonProperty("베가")]
    public string? 베가
    {
        get; set;
    }
    /// <summary>로</summary>
    [DataMember, JsonProperty("로")]
    public string? 로
    {
        get; set;
    }
}