using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종현재가_시간별</summary>
public class MultiOpt20001
{
    /// <summary>시간n</summary>
    [DataMember, JsonProperty("시간n")]
    public string? TimeN
    {
        get; set;
    }
    /// <summary>현재가n</summary>
    [DataMember, JsonProperty("현재가n")]
    public string? CurrentPriceN
    {
        get; set;
    }
    /// <summary>전일대비기호n</summary>
    [DataMember, JsonProperty("전일대비기호n")]
    public string? SymbolsNComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>전일대비n</summary>
    [DataMember, JsonProperty("전일대비n")]
    public string? ComparedToThePreviousDayN
    {
        get; set;
    }
    /// <summary>등락률n</summary>
    [DataMember, JsonProperty("등락률n")]
    public string? FluctuationRateN
    {
        get; set;
    }
    /// <summary>거래량n</summary>
    [DataMember, JsonProperty("거래량n")]
    public string? TransactionVolumeN
    {
        get; set;
    }
    /// <summary>누적거래량n</summary>
    [DataMember, JsonProperty("누적거래량n")]
    public string? AccumulatedTradingVolumeN
    {
        get; set;
    }
}