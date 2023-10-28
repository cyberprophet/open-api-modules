using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵현재가정보</summary>
public class SingleOpt50001
{
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
    /// <summary>거래량대비</summary>
    [DataMember, JsonProperty("거래량대비")]
    public string? 거래량대비
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public string? 기준가
    {
        get; set;
    }
    /// <summary>이론가</summary>
    [DataMember, JsonProperty("이론가")]
    public string? 이론가
    {
        get; set;
    }
    /// <summary>이론베이시스</summary>
    [DataMember, JsonProperty("이론베이시스")]
    public string? 이론베이시스
    {
        get; set;
    }
    /// <summary>괴리도</summary>
    [DataMember, JsonProperty("괴리도")]
    public string? 괴리도
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
    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금")]
    public string? 누적거래대금
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
    /// <summary>CB상한가</summary>
    [DataMember, JsonProperty("CB상한가")]
    public string? CB상한가
    {
        get; set;
    }
    /// <summary>CB하한가</summary>
    [DataMember, JsonProperty("CB하한가")]
    public string? CB하한가
    {
        get; set;
    }
    /// <summary>대용가</summary>
    [DataMember, JsonProperty("대용가")]
    public string? 대용가
    {
        get; set;
    }
    /// <summary>최종거래일</summary>
    [DataMember, JsonProperty("최종거래일")]
    public string? 최종거래일
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
    /// <summary>상장중최고가</summary>
    [DataMember, JsonProperty("상장중최고가")]
    public string? 상장중최고가
    {
        get; set;
    }
    /// <summary>상장중최고가대비율</summary>
    [DataMember, JsonProperty("상장중최고가대비율")]
    public string? 상장중최고가대비율
    {
        get; set;
    }
    /// <summary>상장중최고가일</summary>
    [DataMember, JsonProperty("상장중최고가일")]
    public string? 상장중최고가일
    {
        get; set;
    }
    /// <summary>상장중최저가</summary>
    [DataMember, JsonProperty("상장중최저가")]
    public string? 상장중최저가
    {
        get; set;
    }
    /// <summary>상장중최저가대비율</summary>
    [DataMember, JsonProperty("상장중최저가대비율")]
    public string? 상장중최저가대비율
    {
        get; set;
    }
    /// <summary>상장중최저가일</summary>
    [DataMember, JsonProperty("상장중최저가일")]
    public string? 상장중최저가일
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>호가시간</summary>
    [DataMember, JsonProperty("호가시간")]
    public string? 호가시간
    {
        get; set;
    }
    /// <summary>매도수익율5</summary>
    [DataMember, JsonProperty("매도수익율5")]
    public string? 매도수익율5
    {
        get; set;
    }
    /// <summary>매도건수5</summary>
    [DataMember, JsonProperty("매도건수5")]
    public string? 매도건수5
    {
        get; set;
    }
    /// <summary>매도수량5</summary>
    [DataMember, JsonProperty("매도수량5")]
    public string? 매도수량5
    {
        get; set;
    }
    /// <summary>매도수익율4</summary>
    [DataMember, JsonProperty("매도수익율4")]
    public string? 매도수익율4
    {
        get; set;
    }
    /// <summary>매도건수4</summary>
    [DataMember, JsonProperty("매도건수4")]
    public string? 매도건수4
    {
        get; set;
    }
    /// <summary>매도수량4</summary>
    [DataMember, JsonProperty("매도수량4")]
    public string? 매도수량4
    {
        get; set;
    }
    /// <summary>매도호가4</summary>
    [DataMember, JsonProperty("매도호가4")]
    public string? 매도호가4
    {
        get; set;
    }
    /// <summary>매도호가5</summary>
    [DataMember, JsonProperty("매도호가5")]
    public string? 매도호가5
    {
        get; set;
    }
    /// <summary>매도수익율3</summary>
    [DataMember, JsonProperty("매도수익율3")]
    public string? 매도수익율3
    {
        get; set;
    }
    /// <summary>매도건수3</summary>
    [DataMember, JsonProperty("매도건수3")]
    public string? 매도건수3
    {
        get; set;
    }
    /// <summary>매도수량3</summary>
    [DataMember, JsonProperty("매도수량3")]
    public string? 매도수량3
    {
        get; set;
    }
    /// <summary>매도호가3</summary>
    [DataMember, JsonProperty("매도호가3")]
    public string? 매도호가3
    {
        get; set;
    }
    /// <summary>매도수익율2</summary>
    [DataMember, JsonProperty("매도수익율2")]
    public string? 매도수익율2
    {
        get; set;
    }
    /// <summary>매도건수2</summary>
    [DataMember, JsonProperty("매도건수2")]
    public string? 매도건수2
    {
        get; set;
    }
    /// <summary>매도수량2</summary>
    [DataMember, JsonProperty("매도수량2")]
    public string? 매도수량2
    {
        get; set;
    }
    /// <summary>매도호가2</summary>
    [DataMember, JsonProperty("매도호가2")]
    public string? 매도호가2
    {
        get; set;
    }
    /// <summary>매도수익율1</summary>
    [DataMember, JsonProperty("매도수익율1")]
    public string? 매도수익율1
    {
        get; set;
    }
    /// <summary>매도건수1</summary>
    [DataMember, JsonProperty("매도건수1")]
    public string? 매도건수1
    {
        get; set;
    }
    /// <summary>매도수량1</summary>
    [DataMember, JsonProperty("매도수량1")]
    public string? 매도수량1
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
    /// <summary>매수수량1</summary>
    [DataMember, JsonProperty("매수수량1")]
    public string? 매수수량1
    {
        get; set;
    }
    /// <summary>매수건수1</summary>
    [DataMember, JsonProperty("매수건수1")]
    public string? 매수건수1
    {
        get; set;
    }
    /// <summary>매수수익율1</summary>
    [DataMember, JsonProperty("매수수익율1")]
    public string? 매수수익율1
    {
        get; set;
    }
    /// <summary>매수호가2</summary>
    [DataMember, JsonProperty("매수호가2")]
    public string? 매수호가2
    {
        get; set;
    }
    /// <summary>매수수량2</summary>
    [DataMember, JsonProperty("매수수량2")]
    public string? 매수수량2
    {
        get; set;
    }
    /// <summary>매수건수2</summary>
    [DataMember, JsonProperty("매수건수2")]
    public string? 매수건수2
    {
        get; set;
    }
    /// <summary>매수수익율2</summary>
    [DataMember, JsonProperty("매수수익율2")]
    public string? 매수수익율2
    {
        get; set;
    }
    /// <summary>매수호가3</summary>
    [DataMember, JsonProperty("매수호가3")]
    public string? 매수호가3
    {
        get; set;
    }
    /// <summary>매수수량3</summary>
    [DataMember, JsonProperty("매수수량3")]
    public string? 매수수량3
    {
        get; set;
    }
    /// <summary>매수건수3</summary>
    [DataMember, JsonProperty("매수건수3")]
    public string? 매수건수3
    {
        get; set;
    }
    /// <summary>매수수익율3</summary>
    [DataMember, JsonProperty("매수수익율3")]
    public string? 매수수익율3
    {
        get; set;
    }
    /// <summary>매수호가4</summary>
    [DataMember, JsonProperty("매수호가4")]
    public string? 매수호가4
    {
        get; set;
    }
    /// <summary>매수수량4</summary>
    [DataMember, JsonProperty("매수수량4")]
    public string? 매수수량4
    {
        get; set;
    }
    /// <summary>매수건수4</summary>
    [DataMember, JsonProperty("매수건수4")]
    public string? 매수건수4
    {
        get; set;
    }
    /// <summary>매수수익율4</summary>
    [DataMember, JsonProperty("매수수익율4")]
    public string? 매수수익율4
    {
        get; set;
    }
    /// <summary>매수호가5</summary>
    [DataMember, JsonProperty("매수호가5")]
    public string? 매수호가5
    {
        get; set;
    }
    /// <summary>매수수량5</summary>
    [DataMember, JsonProperty("매수수량5")]
    public string? 매수수량5
    {
        get; set;
    }
    /// <summary>매수건수5</summary>
    [DataMember, JsonProperty("매수건수5")]
    public string? 매수건수5
    {
        get; set;
    }
    /// <summary>매수수익율5</summary>
    [DataMember, JsonProperty("매수수익율5")]
    public string? 매수수익율5
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
    /// <summary>2차저항</summary>
    [DataMember, JsonProperty("2차저항")]
    public string? _2차저항
    {
        get; set;
    }
    /// <summary>1차저항</summary>
    [DataMember, JsonProperty("1차저항")]
    public string? _1차저항
    {
        get; set;
    }
    /// <summary>피봇</summary>
    [DataMember, JsonProperty("피봇")]
    public string? 피봇
    {
        get; set;
    }
    /// <summary>1차저지</summary>
    [DataMember, JsonProperty("1차저지")]
    public string? _1차저지
    {
        get;
        set;
    }
    /// <summary>2차저지</summary>
    [DataMember, JsonProperty("2차저지")]
    public string? _2차저지
    {
        get;
        set;
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
    /// <summary>매도호가총건수</summary>
    [DataMember, JsonProperty("매도호가총건수")]
    public string? 매도호가총건수
    {
        get; set;
    }
    /// <summary>매도호가총잔량</summary>
    [DataMember, JsonProperty("매도호가총잔량")]
    public string? 매도호가총잔량
    {
        get; set;
    }
    /// <summary>순매수잔량</summary>
    [DataMember, JsonProperty("순매수잔량")]
    public string? 순매수잔량
    {
        get; set;
    }
    /// <summary>매수호가총잔량</summary>
    [DataMember, JsonProperty("매수호가총잔량")]
    public string? 매수호가총잔량
    {
        get; set;
    }
    /// <summary>매수호가총건수</summary>
    [DataMember, JsonProperty("매수호가총건수")]
    public string? 매수호가총건수
    {
        get; set;
    }
    /// <summary>매도호가총잔량직전대비</summary>
    [DataMember, JsonProperty("매도호가총잔량직전대비")]
    public string? 매도호가총잔량직전대비
    {
        get; set;
    }
    /// <summary>매수호가총잔량직전대비</summary>
    [DataMember, JsonProperty("매수호가총잔량직전대비")]
    public string? 매수호가총잔량직전대비
    {
        get; set;
    }
    /// <summary>예상체결가</summary>
    [DataMember, JsonProperty("예상체결가")]
    public string? 예상체결가
    {
        get; set;
    }
    /// <summary>예상체결가전일종가대비기호</summary>
    [DataMember, JsonProperty("예상체결가전일종가대비기호")]
    public string? 예상체결가전일종가대비기호
    {
        get; set;
    }
    /// <summary>예상체결가전일종가대비</summary>
    [DataMember, JsonProperty("예상체결가전일종가대비")]
    public string? 예상체결가전일종가대비
    {
        get; set;
    }
    /// <summary>예상체결가전일종가대비등락율</summary>
    [DataMember, JsonProperty("예상체결가전일종가대비등락율")]
    public string? 예상체결가전일종가대비등락율
    {
        get; set;
    }
    /// <summary>이자율</summary>
    [DataMember, JsonProperty("이자율")]
    public string? 이자율
    {
        get; set;
    }
}