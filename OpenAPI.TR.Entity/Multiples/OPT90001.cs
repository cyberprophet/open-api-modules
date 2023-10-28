using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>테마그룹별</summary>
public class MultiOPT90001
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>테마명</summary>
    [DataMember, JsonProperty("테마명")]
    public string? 테마명
    {
        get; set;
    }
    /// <summary>종목수</summary>
    [DataMember, JsonProperty("종목수")]
    public string? 종목수
    {
        get; set;
    }
    /// <summary>등락기호</summary>
    [DataMember, JsonProperty("등락기호")]
    public string? 등락기호
    {
        get; set;
    }
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? 등락율
    {
        get; set;
    }
    /// <summary>상승종목수</summary>
    [DataMember, JsonProperty("상승종목수")]
    public string? 상승종목수
    {
        get; set;
    }
    /// <summary>하락종목수</summary>
    [DataMember, JsonProperty("하락종목수")]
    public string? 하락종목수
    {
        get; set;
    }
    /// <summary>기간수익률</summary>
    [DataMember, JsonProperty("기간수익률")]
    public string? 기간수익률
    {
        get; set;
    }
    /// <summary>주요종목</summary>
    [DataMember, JsonProperty("주요종목")]
    public string? 주요종목
    {
        get; set;
    }
}