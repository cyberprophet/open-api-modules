using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF수익율</summary>
public class MultiOPT40001
{
    /// <summary>ETF수익률</summary>
    [DataMember, JsonProperty("ETF수익률")]
    public string? ETFYield
    {
        get; set;
    }
    /// <summary>체결수익률</summary>
    [DataMember, JsonProperty("체결수익률")]
    public string? ConclusionReturn
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