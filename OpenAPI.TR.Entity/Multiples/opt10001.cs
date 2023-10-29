using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>프로그램매매추이</summary>
public class MultiOpt10001
{
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? ConcludingTime
    {
        get; set;
    }
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>차익거래매도</summary>
    [DataMember, JsonProperty("차익거래매도")]
    public string? ArbitrageSale
    {
        get; set;
    }
    /// <summary>차익거래매수</summary>
    [DataMember, JsonProperty("차익거래매수")]
    public string? ArbitrageBuying
    {
        get; set;
    }
    /// <summary>차익거래순매수</summary>
    [DataMember, JsonProperty("차익거래순매수")]
    public string? NetPurchaseOfArbitrage
    {
        get; set;
    }
    /// <summary>비차익거래매도</summary>
    [DataMember, JsonProperty("비차익거래매도")]
    public string? NonMarginTransactionSales
    {
        get; set;
    }
    /// <summary>비차익거래매수</summary>
    [DataMember, JsonProperty("비차익거래매수")]
    public string? NonMarginTransactionPurchase
    {
        get; set;
    }
    /// <summary>비차익거래순매수</summary>
    [DataMember, JsonProperty("비차익거래순매수")]
    public string? NetPurchaseOfNonMarginTransactions
    {
        get; set;
    }
    /// <summary>차익거래매도수량</summary>
    [DataMember, JsonProperty("차익거래매도수량")]
    public string? AmountOfArbitrageSale
    {
        get; set;
    }
    /// <summary>차익거래매수수량</summary>
    [DataMember, JsonProperty("차익거래매수수량")]
    public string? AmountOfArbitragePurchase
    {
        get; set;
    }
    /// <summary>차익거래순매수수량</summary>
    [DataMember, JsonProperty("차익거래순매수수량")]
    public string? NetPurchaseVolumeOfArbitrageTransactions
    {
        get; set;
    }
    /// <summary>비차익거래매도수량</summary>
    [DataMember, JsonProperty("비차익거래매도수량")]
    public string? NonMarginTransactionSalesVolume
    {
        get; set;
    }
    /// <summary>비차익거래매수수량</summary>
    [DataMember, JsonProperty("비차익거래매수수량")]
    public string? NonMarginTransactionPurchaseQuantity
    {
        get; set;
    }
    /// <summary>비차익거래순매수수량</summary>
    [DataMember, JsonProperty("비차익거래순매수수량")]
    public string? NetPurchaseVolumeOfNonMarginTransactions
    {
        get; set;
    }
    /// <summary>전체매도</summary>
    [DataMember, JsonProperty("전체매도")]
    public string? TotalSale
    {
        get; set;
    }
    /// <summary>전체매수</summary>
    [DataMember, JsonProperty("전체매수")]
    public string? AnAllOut
    {
        get; set;
    }
    /// <summary>전체순매수</summary>
    [DataMember, JsonProperty("전체순매수")]
    public string? OverallNetPurchase
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
}