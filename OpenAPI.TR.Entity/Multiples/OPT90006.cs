using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>프로그램매매차익잔고추이</summary>
public class MultiOPT90006
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>매수차익거래수량</summary>
    [DataMember, JsonProperty("매수차익거래수량")]
    public string? AcquisitionMarginTradingVolume
    {
        get; set;
    }
    /// <summary>매수차익거래금액</summary>
    [DataMember, JsonProperty("매수차익거래금액")]
    public string? PurchaseMarginTransactionAmount
    {
        get; set;
    }
    /// <summary>매수차익거래증감액</summary>
    [DataMember, JsonProperty("매수차익거래증감액")]
    public string? IncreaseOrDecreaseInPurchaseMarginTransactions
    {
        get; set;
    }
    /// <summary>매도차익거래수량</summary>
    [DataMember, JsonProperty("매도차익거래수량")]
    public string? VolumeOfSellingMarginTransactions
    {
        get; set;
    }
    /// <summary>매도차익거래금액</summary>
    [DataMember, JsonProperty("매도차익거래금액")]
    public string? SaleMarginTransactionAmount
    {
        get; set;
    }
    /// <summary>매도차익거래증감액</summary>
    [DataMember, JsonProperty("매도차익거래증감액")]
    public string? IncreaseOrDecreaseInSalesMarginTransactions
    {
        get; set;
    }
}