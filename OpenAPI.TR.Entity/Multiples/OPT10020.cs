using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>호가잔량상위</summary>
public class MultiOPT10020
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
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? 거래량
    {
        get; set;
    }
    /// <summary>총매도잔량</summary>
    [DataMember, JsonProperty("총매도잔량")]
    public string? 총매도잔량
    {
        get; set;
    }
    /// <summary>총매수잔량</summary>
    [DataMember, JsonProperty("총매수잔량")]
    public string? 총매수잔량
    {
        get; set;
    }
    /// <summary>순매수잔량</summary>
    [DataMember, JsonProperty("순매수잔량")]
    public string? 순매수잔량
    {
        get; set;
    }
    /// <summary>매수비율</summary>
    [DataMember, JsonProperty("매수비율")]
    public string? 매수비율
    {
        get; set;
    }
}