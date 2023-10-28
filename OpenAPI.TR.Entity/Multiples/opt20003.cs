using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>전업종지수</summary>
public class MultiOpt20003
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
    /// <summary>비중</summary>
    [DataMember, JsonProperty("비중")]
    public string? 비중
    {
        get; set;
    }
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금")]
    public string? 거래대금
    {
        get; set;
    }
    /// <summary>상한</summary>
    [DataMember, JsonProperty("상한")]
    public string? 상한
    {
        get; set;
    }
    /// <summary>상승</summary>
    [DataMember, JsonProperty("상승")]
    public string? 상승
    {
        get; set;
    }
    /// <summary>보합</summary>
    [DataMember, JsonProperty("보합")]
    public string? 보합
    {
        get; set;
    }
    /// <summary>하락</summary>
    [DataMember, JsonProperty("하락")]
    public string? 하락
    {
        get; set;
    }
    /// <summary>하한</summary>
    [DataMember, JsonProperty("하한")]
    public string? 하한
    {
        get; set;
    }
    /// <summary>상장종목수</summary>
    [DataMember, JsonProperty("상장종목수")]
    public string? 상장종목수
    {
        get; set;
    }
}