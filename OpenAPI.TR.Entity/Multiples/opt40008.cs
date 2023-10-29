using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF순매수수량배열</summary>
public class MultiOpt40008
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>현재가n</summary>
    [DataMember, JsonProperty("현재가n")]
    public string? CurrentPriceN
    {
        get; set;
    }
    /// <summary>대비기호n</summary>
    [DataMember, JsonProperty("대비기호n")]
    public string? ContrastSymbolN
    {
        get; set;
    }
    /// <summary>전일대비n</summary>
    [DataMember, JsonProperty("전일대비n")]
    public string? ComparedToThePreviousDayN
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? AccumulatedTradingVolume
    {
        get; set;
    }
    /// <summary>외인순매수수량</summary>
    [DataMember, JsonProperty("외인순매수수량")]
    public string? NetPurchaseQuantityForForeigners
    {
        get; set;
    }
    /// <summary>기관순매수수량</summary>
    [DataMember, JsonProperty("기관순매수수량")]
    public string? InstitutionalNetPurchaseQuantity
    {
        get; set;
    }
}