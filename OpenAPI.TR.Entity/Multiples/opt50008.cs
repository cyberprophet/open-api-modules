using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>투자자별매도수금액</summary>
public class MultiOpt50008
{
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? ConcludingTime
    {
        get; set;
    }
    /// <summary>투자자별매도금액</summary>
    [DataMember, JsonProperty("투자자별매도금액")]
    public string? AmountSoldByInvestor
    {
        get; set;
    }
    /// <summary>투자자별매수금액</summary>
    [DataMember, JsonProperty("투자자별매수금액")]
    public string? PurchaseAmountByInvestor
    {
        get; set;
    }
    /// <summary>투자자별순매수금액</summary>
    [DataMember, JsonProperty("투자자별순매수금액")]
    public string? NetPurchaseAmountByInvestor
    {
        get; set;
    }
}