using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELWLP보유일별추이</summary>
public class MultiOPT30003
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>대비구분</summary>
    [DataMember, JsonProperty("대비구분")]
    public string? MajorComposition
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
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
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금")]
    public string? TransactionPrice
    {
        get; set;
    }
    /// <summary>변동수량</summary>
    [DataMember, JsonProperty("변동수량")]
    public string? VariableQuantity
    {
        get; set;
    }
    /// <summary>LP보유수량</summary>
    [DataMember, JsonProperty("LP보유수량")]
    public string? LPHoldingQuantity
    {
        get; set;
    }
    /// <summary>비중</summary>
    [DataMember, JsonProperty("비중")]
    public string? Weight
    {
        get; set;
    }
}