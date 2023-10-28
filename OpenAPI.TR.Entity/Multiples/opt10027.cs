using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>전일대비등락률상위</summary>
public class MultiOpt10027
{
    /// <summary>종목분류</summary>
    [DataMember, JsonProperty("종목분류")]
    public string? 종목분류
    {
        get; set;
    }
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
    /// <summary>등락률</summary>
    [DataMember, JsonProperty("등락률")]
    public string? 등락률
    {
        get; set;
    }
    /// <summary>매도잔량</summary>
    [DataMember, JsonProperty("매도잔량")]
    public string? 매도잔량
    {
        get; set;
    }
    /// <summary>매수잔량</summary>
    [DataMember, JsonProperty("매수잔량")]
    public string? 매수잔량
    {
        get; set;
    }
    /// <summary>현재거래량</summary>
    [DataMember, JsonProperty("현재거래량")]
    public string? 현재거래량
    {
        get; set;
    }
    /// <summary>체결강도</summary>
    [DataMember, JsonProperty("체결강도")]
    public string? 체결강도
    {
        get; set;
    }
    /// <summary>횟수</summary>
    [DataMember, JsonProperty("횟수")]
    public string? 횟수
    {
        get; set;
    }
}