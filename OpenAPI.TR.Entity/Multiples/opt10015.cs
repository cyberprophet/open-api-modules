using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일별거래상세</summary>
public class MultiOpt10015
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? 일자
    {
        get; set;
    }
    /// <summary>종가</summary>
    [DataMember, JsonProperty("종가")]
    public string? 종가
    {
        get; set;
    }
    /// <summary>전일대비기호</summary>
    [DataMember, JsonProperty("전일대비기호")]
    public string? 전일대비기호
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
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금")]
    public string? 거래대금
    {
        get; set;
    }
    /// <summary>장전거래량</summary>
    [DataMember, JsonProperty("장전거래량")]
    public string? 장전거래량
    {
        get; set;
    }
    /// <summary>장전거래비중</summary>
    [DataMember, JsonProperty("장전거래비중")]
    public string? 장전거래비중
    {
        get; set;
    }
    /// <summary>장중거래량</summary>
    [DataMember, JsonProperty("장중거래량")]
    public string? 장중거래량
    {
        get; set;
    }
    /// <summary>장중거래비중</summary>
    [DataMember, JsonProperty("장중거래비중")]
    public string? 장중거래비중
    {
        get; set;
    }
    /// <summary>장후거래량</summary>
    [DataMember, JsonProperty("장후거래량")]
    public string? 장후거래량
    {
        get; set;
    }
    /// <summary>장후거래비중</summary>
    [DataMember, JsonProperty("장후거래비중")]
    public string? 장후거래비중
    {
        get; set;
    }
    /// <summary>합계3</summary>
    [DataMember, JsonProperty("합계3")]
    public string? 합계3
    {
        get; set;
    }
    /// <summary>기간중거래량</summary>
    [DataMember, JsonProperty("기간중거래량")]
    public string? 기간중거래량
    {
        get; set;
    }
    /// <summary>체결강도</summary>
    [DataMember, JsonProperty("체결강도")]
    public string? 체결강도
    {
        get; set;
    }
    /// <summary>외인보유</summary>
    [DataMember, JsonProperty("외인보유")]
    public string? 외인보유
    {
        get; set;
    }
    /// <summary>외인비중</summary>
    [DataMember, JsonProperty("외인비중")]
    public string? 외인비중
    {
        get; set;
    }
    /// <summary>외인순매수</summary>
    [DataMember, JsonProperty("외인순매수")]
    public string? 외인순매수
    {
        get; set;
    }
    /// <summary>기관순매수</summary>
    [DataMember, JsonProperty("기관순매수")]
    public string? 기관순매수
    {
        get; set;
    }
    /// <summary>개인순매수</summary>
    [DataMember, JsonProperty("개인순매수")]
    public string? 개인순매수
    {
        get; set;
    }
    /// <summary>외국계</summary>
    [DataMember, JsonProperty("외국계")]
    public string? 외국계
    {
        get; set;
    }
    /// <summary>신용잔고율</summary>
    [DataMember, JsonProperty("신용잔고율")]
    public string? 신용잔고율
    {
        get; set;
    }
    /// <summary>프로그램</summary>
    [DataMember, JsonProperty("프로그램")]
    public string? 프로그램
    {
        get; set;
    }
    /// <summary>장전거래대금</summary>
    [DataMember, JsonProperty("장전거래대금")]
    public string? 장전거래대금
    {
        get; set;
    }
    /// <summary>장전거래대금비중</summary>
    [DataMember, JsonProperty("장전거래대금비중")]
    public string? 장전거래대금비중
    {
        get; set;
    }
    /// <summary>장중거래대금</summary>
    [DataMember, JsonProperty("장중거래대금")]
    public string? 장중거래대금
    {
        get; set;
    }
    /// <summary>장중거래대금비중</summary>
    [DataMember, JsonProperty("장중거래대금비중")]
    public string? 장중거래대금비중
    {
        get; set;
    }
    /// <summary>장후거래대금</summary>
    [DataMember, JsonProperty("장후거래대금")]
    public string? 장후거래대금
    {
        get; set;
    }
    /// <summary>장후거래대금비중</summary>
    [DataMember, JsonProperty("장후거래대금비중")]
    public string? 장후거래대금비중
    {
        get; set;
    }
}