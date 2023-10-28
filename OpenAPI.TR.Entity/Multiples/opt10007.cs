using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>시세표성정보</summary>
public class MultiOpt10007
{
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>날짜</summary>
    [DataMember, JsonProperty("날짜")]
    public string? 날짜
    {
        get; set;
    }
    /// <summary>시간</summary>
    [DataMember, JsonProperty("시간")]
    public string? 시간
    {
        get; set;
    }
    /// <summary>전일종가</summary>
    [DataMember, JsonProperty("전일종가")]
    public string? 전일종가
    {
        get; set;
    }
    /// <summary>전일거래량</summary>
    [DataMember, JsonProperty("전일거래량")]
    public string? 전일거래량
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
    /// <summary>전일거래대금</summary>
    [DataMember, JsonProperty("전일거래대금")]
    public string? 전일거래대금
    {
        get; set;
    }
    /// <summary>상장주식수</summary>
    [DataMember, JsonProperty("상장주식수")]
    public string? 상장주식수
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>부호</summary>
    [DataMember, JsonProperty("부호")]
    public string? 부호
    {
        get; set;
    }
    /// <summary>등락률</summary>
    [DataMember, JsonProperty("등락률")]
    public string? 등락률
    {
        get; set;
    }
    /// <summary>전일비</summary>
    [DataMember, JsonProperty("전일비")]
    public string? 전일비
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
    /// <summary>체결량</summary>
    [DataMember, JsonProperty("체결량")]
    public string? 체결량
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? 거래량
    {
        get; set;
    }
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금")]
    public string? 거래대금
    {
        get; set;
    }
    /// <summary>예상체결가</summary>
    [DataMember, JsonProperty("예상체결가")]
    public string? 예상체결가
    {
        get; set;
    }
    /// <summary>예상체결량</summary>
    [DataMember, JsonProperty("예상체결량")]
    public string? 예상체결량
    {
        get; set;
    }
    /// <summary>예상매도우선호가</summary>
    [DataMember, JsonProperty("예상매도우선호가")]
    public string? 예상매도우선호가
    {
        get; set;
    }
    /// <summary>예상매수우선호가</summary>
    [DataMember, JsonProperty("예상매수우선호가")]
    public string? 예상매수우선호가
    {
        get; set;
    }
    /// <summary>거래시작일</summary>
    [DataMember, JsonProperty("거래시작일")]
    public string? 거래시작일
    {
        get; set;
    }
    /// <summary>행사가격</summary>
    [DataMember, JsonProperty("행사가격")]
    public string? 행사가격
    {
        get; set;
    }
    /// <summary>최고가</summary>
    [DataMember, JsonProperty("최고가")]
    public string? 최고가
    {
        get; set;
    }
    /// <summary>최저가</summary>
    [DataMember, JsonProperty("최저가")]
    public string? 최저가
    {
        get; set;
    }
    /// <summary>최고가일</summary>
    [DataMember, JsonProperty("최고가일")]
    public string? 최고가일
    {
        get; set;
    }
    /// <summary>최저가일</summary>
    [DataMember, JsonProperty("최저가일")]
    public string? 최저가일
    {
        get; set;
    }
    /// <summary>매도1호가</summary>
    [DataMember, JsonProperty("매도1호가")]
    public string? 매도1호가
    {
        get; set;
    }
    /// <summary>매도2호가</summary>
    [DataMember, JsonProperty("매도2호가")]
    public string? 매도2호가
    {
        get; set;
    }
    /// <summary>매도3호가</summary>
    [DataMember, JsonProperty("매도3호가")]
    public string? 매도3호가
    {
        get; set;
    }
    /// <summary>매도4호가</summary>
    [DataMember, JsonProperty("매도4호가")]
    public string? 매도4호가
    {
        get; set;
    }
    /// <summary>매도5호가</summary>
    [DataMember, JsonProperty("매도5호가")]
    public string? 매도5호가
    {
        get; set;
    }
    /// <summary>매도6호가</summary>
    [DataMember, JsonProperty("매도6호가")]
    public string? 매도6호가
    {
        get; set;
    }
    /// <summary>매도7호가</summary>
    [DataMember, JsonProperty("매도7호가")]
    public string? 매도7호가
    {
        get; set;
    }
    /// <summary>매도8호가</summary>
    [DataMember, JsonProperty("매도8호가")]
    public string? 매도8호가
    {
        get; set;
    }
    /// <summary>매도9호가</summary>
    [DataMember, JsonProperty("매도9호가")]
    public string? 매도9호가
    {
        get; set;
    }
    /// <summary>매도10호가</summary>
    [DataMember, JsonProperty("매도10호가")]
    public string? 매도10호가
    {
        get; set;
    }
    /// <summary>매수1호가</summary>
    [DataMember, JsonProperty("매수1호가")]
    public string? 매수1호가
    {
        get; set;
    }
    /// <summary>매수2호가</summary>
    [DataMember, JsonProperty("매수2호가")]
    public string? 매수2호가
    {
        get; set;
    }
    /// <summary>매수3호가</summary>
    [DataMember, JsonProperty("매수3호가")]
    public string? 매수3호가
    {
        get; set;
    }
    /// <summary>매수4호가</summary>
    [DataMember, JsonProperty("매수4호가")]
    public string? 매수4호가
    {
        get; set;
    }
    /// <summary>매수5호가</summary>
    [DataMember, JsonProperty("매수5호가")]
    public string? 매수5호가
    {
        get; set;
    }
    /// <summary>매수6호가</summary>
    [DataMember, JsonProperty("매수6호가")]
    public string? 매수6호가
    {
        get; set;
    }
    /// <summary>매수7호가</summary>
    [DataMember, JsonProperty("매수7호가")]
    public string? 매수7호가
    {
        get; set;
    }
    /// <summary>매수8호가</summary>
    [DataMember, JsonProperty("매수8호가")]
    public string? 매수8호가
    {
        get; set;
    }
    /// <summary>매수9호가</summary>
    [DataMember, JsonProperty("매수9호가")]
    public string? 매수9호가
    {
        get; set;
    }
    /// <summary>매수10호가</summary>
    [DataMember, JsonProperty("매수10호가")]
    public string? 매수10호가
    {
        get; set;
    }
    /// <summary>매도1호가잔량</summary>
    [DataMember, JsonProperty("매도1호가잔량")]
    public string? 매도1호가잔량
    {
        get; set;
    }
    /// <summary>매도2호가잔량</summary>
    [DataMember, JsonProperty("매도2호가잔량")]
    public string? 매도2호가잔량
    {
        get; set;
    }
    /// <summary>매도3호가잔량</summary>
    [DataMember, JsonProperty("매도3호가잔량")]
    public string? 매도3호가잔량
    {
        get; set;
    }
    /// <summary>매도4호가잔량</summary>
    [DataMember, JsonProperty("매도4호가잔량")]
    public string? 매도4호가잔량
    {
        get; set;
    }
    /// <summary>매도5호가잔량</summary>
    [DataMember, JsonProperty("매도5호가잔량")]
    public string? 매도5호가잔량
    {
        get; set;
    }
    /// <summary>매도6호가잔량</summary>
    [DataMember, JsonProperty("매도6호가잔량")]
    public string? 매도6호가잔량
    {
        get; set;
    }
    /// <summary>매도7호가잔량</summary>
    [DataMember, JsonProperty("매도7호가잔량")]
    public string? 매도7호가잔량
    {
        get; set;
    }
    /// <summary>매도8호가잔량</summary>
    [DataMember, JsonProperty("매도8호가잔량")]
    public string? 매도8호가잔량
    {
        get; set;
    }
    /// <summary>매도9호가잔량</summary>
    [DataMember, JsonProperty("매도9호가잔량")]
    public string? 매도9호가잔량
    {
        get; set;
    }
    /// <summary>매도10호가잔량</summary>
    [DataMember, JsonProperty("매도10호가잔량")]
    public string? 매도10호가잔량
    {
        get; set;
    }
    /// <summary>매수1호가잔량</summary>
    [DataMember, JsonProperty("매수1호가잔량")]
    public string? 매수1호가잔량
    {
        get; set;
    }
    /// <summary>매수2호가잔량</summary>
    [DataMember, JsonProperty("매수2호가잔량")]
    public string? 매수2호가잔량
    {
        get; set;
    }
    /// <summary>매수3호가잔량</summary>
    [DataMember, JsonProperty("매수3호가잔량")]
    public string? 매수3호가잔량
    {
        get; set;
    }
    /// <summary>매수4호가잔량</summary>
    [DataMember, JsonProperty("매수4호가잔량")]
    public string? 매수4호가잔량
    {
        get; set;
    }
    /// <summary>매수5호가잔량</summary>
    [DataMember, JsonProperty("매수5호가잔량")]
    public string? 매수5호가잔량
    {
        get; set;
    }
    /// <summary>매수6호가잔량</summary>
    [DataMember, JsonProperty("매수6호가잔량")]
    public string? 매수6호가잔량
    {
        get; set;
    }
    /// <summary>매수7호가잔량</summary>
    [DataMember, JsonProperty("매수7호가잔량")]
    public string? 매수7호가잔량
    {
        get; set;
    }
    /// <summary>매수8호가잔량</summary>
    [DataMember, JsonProperty("매수8호가잔량")]
    public string? 매수8호가잔량
    {
        get; set;
    }
    /// <summary>매수9호가잔량</summary>
    [DataMember, JsonProperty("매수9호가잔량")]
    public string? 매수9호가잔량
    {
        get; set;
    }
    /// <summary>매수10호가잔량</summary>
    [DataMember, JsonProperty("매수10호가잔량")]
    public string? 매수10호가잔량
    {
        get; set;
    }
    /// <summary>매도1호가직전대비</summary>
    [DataMember, JsonProperty("매도1호가직전대비")]
    public string? 매도1호가직전대비
    {
        get; set;
    }
    /// <summary>매도2호가직전대비</summary>
    [DataMember, JsonProperty("매도2호가직전대비")]
    public string? 매도2호가직전대비
    {
        get; set;
    }
    /// <summary>매도3호가직전대비</summary>
    [DataMember, JsonProperty("매도3호가직전대비")]
    public string? 매도3호가직전대비
    {
        get; set;
    }
    /// <summary>매도4호가직전대비</summary>
    [DataMember, JsonProperty("매도4호가직전대비")]
    public string? 매도4호가직전대비
    {
        get; set;
    }
    /// <summary>매도5호가직전대비</summary>
    [DataMember, JsonProperty("매도5호가직전대비")]
    public string? 매도5호가직전대비
    {
        get; set;
    }
    /// <summary>매도6호가직전대비</summary>
    [DataMember, JsonProperty("매도6호가직전대비")]
    public string? 매도6호가직전대비
    {
        get; set;
    }
    /// <summary>매도7호가직전대비</summary>
    [DataMember, JsonProperty("매도7호가직전대비")]
    public string? 매도7호가직전대비
    {
        get; set;
    }
    /// <summary>매도8호가직전대비</summary>
    [DataMember, JsonProperty("매도8호가직전대비")]
    public string? 매도8호가직전대비
    {
        get; set;
    }
    /// <summary>매도9호가직전대비</summary>
    [DataMember, JsonProperty("매도9호가직전대비")]
    public string? 매도9호가직전대비
    {
        get; set;
    }
    /// <summary>매도10호가직전대비</summary>
    [DataMember, JsonProperty("매도10호가직전대비")]
    public string? 매도10호가직전대비
    {
        get; set;
    }
    /// <summary>매수1호가직전대비</summary>
    [DataMember, JsonProperty("매수1호가직전대비")]
    public string? 매수1호가직전대비
    {
        get; set;
    }
    /// <summary>매수2호가직전대비</summary>
    [DataMember, JsonProperty("매수2호가직전대비")]
    public string? 매수2호가직전대비
    {
        get; set;
    }
    /// <summary>매수3호가직전대비</summary>
    [DataMember, JsonProperty("매수3호가직전대비")]
    public string? 매수3호가직전대비
    {
        get; set;
    }
    /// <summary>매수4호가직전대비</summary>
    [DataMember, JsonProperty("매수4호가직전대비")]
    public string? 매수4호가직전대비
    {
        get; set;
    }
    /// <summary>매수5호가직전대비</summary>
    [DataMember, JsonProperty("매수5호가직전대비")]
    public string? 매수5호가직전대비
    {
        get; set;
    }
    /// <summary>매수6호가직전대비</summary>
    [DataMember, JsonProperty("매수6호가직전대비")]
    public string? 매수6호가직전대비
    {
        get; set;
    }
    /// <summary>매수7호가직전대비</summary>
    [DataMember, JsonProperty("매수7호가직전대비")]
    public string? 매수7호가직전대비
    {
        get; set;
    }
    /// <summary>매수8호가직전대비</summary>
    [DataMember, JsonProperty("매수8호가직전대비")]
    public string? 매수8호가직전대비
    {
        get; set;
    }
    /// <summary>매수9호가직전대비</summary>
    [DataMember, JsonProperty("매수9호가직전대비")]
    public string? 매수9호가직전대비
    {
        get; set;
    }
    /// <summary>매수10호가직전대비</summary>
    [DataMember, JsonProperty("매수10호가직전대비")]
    public string? 매수10호가직전대비
    {
        get; set;
    }
    /// <summary>매도1호가건수</summary>
    [DataMember, JsonProperty("매도1호가건수")]
    public string? 매도1호가건수
    {
        get; set;
    }
    /// <summary>매도2호가건수</summary>
    [DataMember, JsonProperty("매도2호가건수")]
    public string? 매도2호가건수
    {
        get; set;
    }
    /// <summary>매도3호가건수</summary>
    [DataMember, JsonProperty("매도3호가건수")]
    public string? 매도3호가건수
    {
        get; set;
    }
    /// <summary>매도4호가건수</summary>
    [DataMember, JsonProperty("매도4호가건수")]
    public string? 매도4호가건수
    {
        get; set;
    }
    /// <summary>매도5호가건수</summary>
    [DataMember, JsonProperty("매도5호가건수")]
    public string? 매도5호가건수
    {
        get; set;
    }
    /// <summary>매수1호가건수</summary>
    [DataMember, JsonProperty("매수1호가건수")]
    public string? 매수1호가건수
    {
        get; set;
    }
    /// <summary>매수2호가건수</summary>
    [DataMember, JsonProperty("매수2호가건수")]
    public string? 매수2호가건수
    {
        get; set;
    }
    /// <summary>매수3호가건수</summary>
    [DataMember, JsonProperty("매수3호가건수")]
    public string? 매수3호가건수
    {
        get; set;
    }
    /// <summary>매수4호가건수</summary>
    [DataMember, JsonProperty("매수4호가건수")]
    public string? 매수4호가건수
    {
        get; set;
    }
    /// <summary>매수5호가건수</summary>
    [DataMember, JsonProperty("매수5호가건수")]
    public string? 매수5호가건수
    {
        get; set;
    }
    /// <summary>LP매도1호가잔량</summary>
    [DataMember, JsonProperty("LP매도1호가잔량")]
    public string? LP매도1호가잔량
    {
        get; set;
    }
    /// <summary>LP매도2호가잔량</summary>
    [DataMember, JsonProperty("LP매도2호가잔량")]
    public string? LP매도2호가잔량
    {
        get; set;
    }
    /// <summary>LP매도3호가잔량</summary>
    [DataMember, JsonProperty("LP매도3호가잔량")]
    public string? LP매도3호가잔량
    {
        get; set;
    }
    /// <summary>LP매도4호가잔량</summary>
    [DataMember, JsonProperty("LP매도4호가잔량")]
    public string? LP매도4호가잔량
    {
        get; set;
    }
    /// <summary>LP매도5호가잔량</summary>
    [DataMember, JsonProperty("LP매도5호가잔량")]
    public string? LP매도5호가잔량
    {
        get; set;
    }
    /// <summary>LP매도6호가잔량</summary>
    [DataMember, JsonProperty("LP매도6호가잔량")]
    public string? LP매도6호가잔량
    {
        get; set;
    }
    /// <summary>LP매도7호가잔량</summary>
    [DataMember, JsonProperty("LP매도7호가잔량")]
    public string? LP매도7호가잔량
    {
        get; set;
    }
    /// <summary>LP매도8호가잔량</summary>
    [DataMember, JsonProperty("LP매도8호가잔량")]
    public string? LP매도8호가잔량
    {
        get; set;
    }
    /// <summary>LP매도9호가잔량</summary>
    [DataMember, JsonProperty("LP매도9호가잔량")]
    public string? LP매도9호가잔량
    {
        get; set;
    }
    /// <summary>LP매도10호가잔량</summary>
    [DataMember, JsonProperty("LP매도10호가잔량")]
    public string? LP매도10호가잔량
    {
        get; set;
    }
    /// <summary>LP매수1호가잔량</summary>
    [DataMember, JsonProperty("LP매수1호가잔량")]
    public string? LP매수1호가잔량
    {
        get; set;
    }
    /// <summary>LP매수2호가잔량</summary>
    [DataMember, JsonProperty("LP매수2호가잔량")]
    public string? LP매수2호가잔량
    {
        get; set;
    }
    /// <summary>LP매수3호가잔량</summary>
    [DataMember, JsonProperty("LP매수3호가잔량")]
    public string? LP매수3호가잔량
    {
        get; set;
    }
    /// <summary>LP매수4호가잔량</summary>
    [DataMember, JsonProperty("LP매수4호가잔량")]
    public string? LP매수4호가잔량
    {
        get; set;
    }
    /// <summary>LP매수5호가잔량</summary>
    [DataMember, JsonProperty("LP매수5호가잔량")]
    public string? LP매수5호가잔량
    {
        get; set;
    }
    /// <summary>LP매수6호가잔량</summary>
    [DataMember, JsonProperty("LP매수6호가잔량")]
    public string? LP매수6호가잔량
    {
        get; set;
    }
    /// <summary>LP매수7호가잔량</summary>
    [DataMember, JsonProperty("LP매수7호가잔량")]
    public string? LP매수7호가잔량
    {
        get; set;
    }
    /// <summary>LP매수8호가잔량</summary>
    [DataMember, JsonProperty("LP매수8호가잔량")]
    public string? LP매수8호가잔량
    {
        get; set;
    }
    /// <summary>LP매수9호가잔량</summary>
    [DataMember, JsonProperty("LP매수9호가잔량")]
    public string? LP매수9호가잔량
    {
        get; set;
    }
    /// <summary>LP매수10호가잔량</summary>
    [DataMember, JsonProperty("LP매수10호가잔량")]
    public string? LP매수10호가잔량
    {
        get; set;
    }
    /// <summary>총매수잔량</summary>
    [DataMember, JsonProperty("총매수잔량")]
    public string? 총매수잔량
    {
        get; set;
    }
    /// <summary>총매도잔량</summary>
    [DataMember, JsonProperty("총매도잔량")]
    public string? 총매도잔량
    {
        get; set;
    }
    /// <summary>총매수건수</summary>
    [DataMember, JsonProperty("총매수건수")]
    public string? 총매수건수
    {
        get; set;
    }
    /// <summary>총매도건수</summary>
    [DataMember, JsonProperty("총매도건수")]
    public string? 총매도건수
    {
        get; set;
    }
}