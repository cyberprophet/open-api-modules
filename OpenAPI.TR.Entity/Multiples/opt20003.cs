using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>전업종지수</summary>
public class MultiOpt20003
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>대비기호</summary>
    [DataMember, JsonProperty("대비기호")]
    public string? ContrastSymbol
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>등락률</summary>
    [DataMember, JsonProperty("등락률")]
    public string? FluctuationRate
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? VolumeOfTransaction
    {
        get; set;
    }
    /// <summary>비중</summary>
    [DataMember, JsonProperty("비중")]
    public string? Weight
    {
        get; set;
    }
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금")]
    public string? TransactionPrice
    {
        get; set;
    }
    /// <summary>상한</summary>
    [DataMember, JsonProperty("상한")]
    public string? Spoiled
    {
        get; set;
    }
    /// <summary>상승</summary>
    [DataMember, JsonProperty("상승")]
    public string? Rising
    {
        get; set;
    }
    /// <summary>보합</summary>
    [DataMember, JsonProperty("보합")]
    public string? Flat
    {
        get; set;
    }
    /// <summary>하락</summary>
    [DataMember, JsonProperty("하락")]
    public string? Falling
    {
        get; set;
    }
    /// <summary>하한</summary>
    [DataMember, JsonProperty("하한")]
    public string? LowerLimit
    {
        get; set;
    }
    /// <summary>상장종목수</summary>
    [DataMember, JsonProperty("상장종목수")]
    public string? ListedNumberOfStocks
    {
        get; set;
    }
}