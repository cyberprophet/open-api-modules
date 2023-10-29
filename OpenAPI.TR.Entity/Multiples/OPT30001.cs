using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW가격급등락</summary>
public class MultiOPT30001
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>순위</summary>
    [DataMember, JsonProperty("순위")]
    public string? Ranking
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
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
    /// <summary>거래종료ELW기준가</summary>
    [DataMember, JsonProperty("거래종료ELW기준가")]
    public string? TransactionTerminationELWBasePrice
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>기준대비</summary>
    [DataMember, JsonProperty("기준대비")]
    public string? ComparedToTheStandard
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? VolumeOfTransaction
    {
        get; set;
    }
    /// <summary>급등율</summary>
    [DataMember, JsonProperty("급등율")]
    public string? RateOfSurge
    {
        get; set;
    }
}