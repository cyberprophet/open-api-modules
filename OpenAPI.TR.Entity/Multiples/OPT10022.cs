using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>잔량율급증</summary>
public class MultiOPT10022
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
    public string? ThePresentPrice
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
    /// <summary>기준률</summary>
    [DataMember, JsonProperty("기준률")]
    public string? ReferenceRate
    {
        get; set;
    }
    /// <summary>현재비율</summary>
    [DataMember, JsonProperty("현재비율")]
    public string? CurrentRatio
    {
        get; set;
    }
    /// <summary>급증률</summary>
    [DataMember, JsonProperty("급증률")]
    public string? SurgeRate
    {
        get; set;
    }
    /// <summary>총매도잔량</summary>
    [DataMember, JsonProperty("총매도잔량")]
    public string? TotalRemainingSales
    {
        get; set;
    }
    /// <summary>총매수잔량</summary>
    [DataMember, JsonProperty("총매수잔량")]
    public string? TotalPurchaseBacklog
    {
        get; set;
    }
}