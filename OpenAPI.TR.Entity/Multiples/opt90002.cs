using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>테마구성종목</summary>
public class MultiOpt90002
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
    /// <summary>등락기호</summary>
    [DataMember, JsonProperty("등락기호")]
    public string? 등락기호
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
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? 누적거래량
    {
        get; set;
    }
    /// <summary>매도호가</summary>
    [DataMember, JsonProperty("매도호가")]
    public string? 매도호가
    {
        get; set;
    }
    /// <summary>매도잔량</summary>
    [DataMember, JsonProperty("매도잔량")]
    public string? 매도잔량
    {
        get; set;
    }
    /// <summary>매수호가</summary>
    [DataMember, JsonProperty("매수호가")]
    public string? 매수호가
    {
        get; set;
    }
    /// <summary>매수잔량</summary>
    [DataMember, JsonProperty("매수잔량")]
    public string? 매수잔량
    {
        get; set;
    }
    /// <summary>기간수익률n</summary>
    [DataMember, JsonProperty("기간수익률n")]
    public string? 기간수익률n
    {
        get; set;
    }
}