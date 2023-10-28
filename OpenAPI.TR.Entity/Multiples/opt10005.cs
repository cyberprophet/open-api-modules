using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식일주월시분</summary>
public class MultiOpt10005
{
    /// <summary>날짜</summary>
    [DataMember, JsonProperty("날짜")]
    public string? 날짜
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
    /// <summary>종가</summary>
    [DataMember, JsonProperty("종가")]
    public string? 종가
    {
        get; set;
    }
    /// <summary>대비</summary>
    [DataMember, JsonProperty("대비")]
    public string? 대비
    {
        get; set;
    }
    /// <summary>등락률</summary>
    [DataMember, JsonProperty("등락률")]
    public string? 등락률
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
}