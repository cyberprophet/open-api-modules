using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>당일매매일지단일</summary>
public class SingleOpt10170
{
    /// <summary>총매도금액</summary>
    [DataMember, JsonProperty("총매도금액")]
    public string? TotalSellingAmount
    {
        get; set;
    }
    /// <summary>총매수금액</summary>
    [DataMember, JsonProperty("총매수금액")]
    public string? TotalPurchaseAmount
    {
        get; set;
    }
    /// <summary>총수수료_세금</summary>
    [DataMember, JsonProperty("총수수료_세금")]
    public string? TotalFeesTaxes
    {
        get; set;
    }
    /// <summary>총정산금액</summary>
    [DataMember, JsonProperty("총정산금액")]
    public string? TotalSettlementAmount
    {
        get; set;
    }
    /// <summary>총손익금액</summary>
    [DataMember, JsonProperty("총손익금액")]
    public string? TotalProfitAndLoss
    {
        get; set;
    }
    /// <summary>총수익률</summary>
    [DataMember, JsonProperty("총수익률")]
    public string? TotalReturn
    {
        get; set;
    }
}