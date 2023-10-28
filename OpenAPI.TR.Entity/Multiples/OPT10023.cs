using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>거래량급증</summary>
public class MultiOPT10023
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
    /// <summary>등락률</summary>
    [DataMember, JsonProperty("등락률")]
    public string? 등락률
    {
        get; set;
    }
    /// <summary>이전거래량</summary>
    [DataMember, JsonProperty("이전거래량")]
    public string? 이전거래량
    {
        get; set;
    }
    /// <summary>현재거래량</summary>
    [DataMember, JsonProperty("현재거래량")]
    public string? 현재거래량
    {
        get; set;
    }
    /// <summary>급증량</summary>
    [DataMember, JsonProperty("급증량")]
    public string? 급증량
    {
        get; set;
    }
    /// <summary>급증률</summary>
    [DataMember, JsonProperty("급증률")]
    public string? 급증률
    {
        get; set;
    }
}