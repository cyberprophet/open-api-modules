using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>테마그룹별</summary>
public class MultiOPT90001
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>테마명</summary>
    [DataMember, JsonProperty("테마명")]
    public string? ThemeName
    {
        get; set;
    }
    /// <summary>종목수</summary>
    [DataMember, JsonProperty("종목수")]
    public string? NumberOfEvents
    {
        get; set;
    }
    /// <summary>등락기호</summary>
    [DataMember, JsonProperty("등락기호")]
    public string? FluctuationSymbol
    {
        get; set;
    }
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? FluctuationRate
    {
        get; set;
    }
    /// <summary>상승종목수</summary>
    [DataMember, JsonProperty("상승종목수")]
    public string? UpTick
    {
        get; set;
    }
    /// <summary>하락종목수</summary>
    [DataMember, JsonProperty("하락종목수")]
    public string? FallingStocks
    {
        get; set;
    }
    /// <summary>기간수익률</summary>
    [DataMember, JsonProperty("기간수익률")]
    public string? TermRateOfReturn
    {
        get; set;
    }
    /// <summary>주요종목</summary>
    [DataMember, JsonProperty("주요종목")]
    public string? MajorEvents
    {
        get; set;
    }
}