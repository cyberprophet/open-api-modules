using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>예상체결등락률상위</summary>
public class MultiOpt10029
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
    /// <summary>예상체결가</summary>
    [DataMember, JsonProperty("예상체결가")]
    public string? AnEstimatedClosingPrice
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public string? StandardPrice
    {
        get; set;
    }
    /// <summary>전일대비기호</summary>
    [DataMember, JsonProperty("전일대비기호")]
    public string? SignsComparedToThePreviousDay
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
    /// <summary>예상체결량</summary>
    [DataMember, JsonProperty("예상체결량")]
    public string? EstimatedAmountOfEngagement
    {
        get; set;
    }
    /// <summary>매도잔량</summary>
    [DataMember, JsonProperty("매도잔량")]
    public string? SalesBacklog
    {
        get; set;
    }
    /// <summary>매도호가</summary>
    [DataMember, JsonProperty("매도호가")]
    public string? SellingPrice
    {
        get; set;
    }
    /// <summary>매수호가</summary>
    [DataMember, JsonProperty("매수호가")]
    public string? BuyInPrice
    {
        get; set;
    }
    /// <summary>매수잔량</summary>
    [DataMember, JsonProperty("매수잔량")]
    public string? BuyRemainingAmount
    {
        get; set;
    }
}