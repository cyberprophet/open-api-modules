using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>신용매매동향</summary>
public class MultiOpt10013
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
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
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? VolumeOfTransaction
    {
        get; set;
    }
    /// <summary>신규</summary>
    [DataMember, JsonProperty("신규")]
    public string? New
    {
        get; set;
    }
    /// <summary>상환</summary>
    [DataMember, JsonProperty("상환")]
    public string? Redemption
    {
        get; set;
    }
    /// <summary>잔고</summary>
    [DataMember, JsonProperty("잔고")]
    public string? Balance
    {
        get; set;
    }
    /// <summary>금액</summary>
    [DataMember, JsonProperty("금액")]
    public string? Amount
    {
        get; set;
    }
    /// <summary>대비</summary>
    [DataMember, JsonProperty("대비")]
    public string? Contrast
    {
        get; set;
    }
    /// <summary>공여율</summary>
    [DataMember, JsonProperty("공여율")]
    public string? RateOfContribution
    {
        get; set;
    }
    /// <summary>잔고율</summary>
    [DataMember, JsonProperty("잔고율")]
    public string? BalanceRate
    {
        get; set;
    }
}