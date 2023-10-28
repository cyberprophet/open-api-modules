using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>신용비율상위</summary>
public class MultiOpt10033
{
    /// <summary>종목정보</summary>
    [DataMember, JsonProperty("종목정보")]
    public string? 종목정보
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
    /// <summary>신용비율</summary>
    [DataMember, JsonProperty("신용비율")]
    public string? 신용비율
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
}