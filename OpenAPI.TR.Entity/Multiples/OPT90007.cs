using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>프로그램매매누적추이</summary>
public class MultiOPT90007
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>KOSPI200</summary>
    [DataMember, JsonProperty(nameof(KOSPI200))]
    public string? KOSPI200
    {
        get; set;
    }
    /// <summary>BASIS</summary>
    [DataMember, JsonProperty(nameof(BASIS))]
    public string? BASIS
    {
        get; set;
    }
    /// <summary>차익거래당일</summary>
    [DataMember, JsonProperty("차익거래당일")]
    public string? TheDayOfArbitrage
    {
        get; set;
    }
    /// <summary>차익거래누적</summary>
    [DataMember, JsonProperty("차익거래누적")]
    public string? AccumulationOfArbitrageTransactions
    {
        get; set;
    }
    /// <summary>비차익거래당일</summary>
    [DataMember, JsonProperty("비차익거래당일")]
    public string? NonProfitTransactionDate
    {
        get; set;
    }
    /// <summary>비차익거래누적</summary>
    [DataMember, JsonProperty("비차익거래누적")]
    public string? AccumulationOfNonProfitTransactions
    {
        get; set;
    }
    /// <summary>전체당일</summary>
    [DataMember, JsonProperty("전체당일")]
    public string? TheDayOfTheWholeDay
    {
        get; set;
    }
    /// <summary>전체누적</summary>
    [DataMember, JsonProperty("전체누적")]
    public string? TheTotalAccumulation
    {
        get; set;
    }
}