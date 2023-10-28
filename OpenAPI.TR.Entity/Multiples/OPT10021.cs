using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>호가잔량급증</summary>
public class MultiOPT10021
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
    /// <summary>기준률</summary>
    [DataMember, JsonProperty("기준률")]
    public string? 기준률
    {
        get; set;
    }
    /// <summary>현재</summary>
    [DataMember, JsonProperty("현재")]
    public string? 현재
    {
        get; set;
    }
    /// <summary>급증수량</summary>
    [DataMember, JsonProperty("급증수량")]
    public string? 급증수량
    {
        get; set;
    }
    /// <summary>급증률</summary>
    [DataMember, JsonProperty("급증률")]
    public string? 급증률
    {
        get; set;
    }
    /// <summary>총매수량</summary>
    [DataMember, JsonProperty("총매수량")]
    public string? 총매수량
    {
        get; set;
    }
}