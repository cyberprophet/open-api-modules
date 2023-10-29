using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>관심종목프로그램정보</summary>
public class MultiOPTKWPRO
{
    /// <summary>차익매도량</summary>
    [DataMember, JsonProperty("차익매도량")]
    public string? ProfitTakingAmount
    {
        get; set;
    }
    /// <summary>차익매도대금</summary>
    [DataMember, JsonProperty("차익매도대금")]
    public string? ProfitTaking
    {
        get; set;
    }
    /// <summary>차익매도비율</summary>
    [DataMember, JsonProperty("차익매도비율")]
    public string? SellTakingRatio
    {
        get; set;
    }
    /// <summary>차익매수량</summary>
    [DataMember, JsonProperty("차익매수량")]
    public string? TheAmountOfProfitTaking
    {
        get; set;
    }
    /// <summary>차익매수대금</summary>
    [DataMember, JsonProperty("차익매수대금")]
    public string? ProfitTakingPrice
    {
        get; set;
    }
    /// <summary>차익매수비율</summary>
    [DataMember, JsonProperty("차익매수비율")]
    public string? BuyTakingRatio
    {
        get; set;
    }
    /// <summary>차익순매수금액</summary>
    [DataMember, JsonProperty("차익순매수금액")]
    public string? NetProfitPurchaseAmount
    {
        get; set;
    }
    /// <summary>비차익매도량</summary>
    [DataMember, JsonProperty("비차익매도량")]
    public string? NonMarginSellingVolume
    {
        get; set;
    }
    /// <summary>비차익매도대금</summary>
    [DataMember, JsonProperty("비차익매도대금")]
    public string? NonProfitSellingPrice
    {
        get; set;
    }
    /// <summary>비차익매도비율</summary>
    [DataMember, JsonProperty("비차익매도비율")]
    public string? NonProfitSellingRatio
    {
        get; set;
    }
    /// <summary>비차익매수량</summary>
    [DataMember, JsonProperty("비차익매수량")]
    public string? NonProfitablePurchaseVolume
    {
        get; set;
    }
    /// <summary>비차익매수대금</summary>
    [DataMember, JsonProperty("비차익매수대금")]
    public string? NonProfitablePurchasePrice
    {
        get; set;
    }
    /// <summary>비차익매수비율</summary>
    [DataMember, JsonProperty("비차익매수비율")]
    public string? NonProfitBuyingRatio
    {
        get; set;
    }
    /// <summary>비차익순매수금액</summary>
    [DataMember, JsonProperty("비차익순매수금액")]
    public string? NonProfitNetPurchaseAmount
    {
        get; set;
    }
    /// <summary>합계매도량</summary>
    [DataMember, JsonProperty("합계매도량")]
    public string? TotalSellingVolume
    {
        get; set;
    }
    /// <summary>합계매도대금</summary>
    [DataMember, JsonProperty("합계매도대금")]
    public string? TotalSellingPrice
    {
        get; set;
    }
    /// <summary>합계매수량</summary>
    [DataMember, JsonProperty("합계매수량")]
    public string? TotalPurchaseVolume
    {
        get; set;
    }
    /// <summary>합계매수대금</summary>
    [DataMember, JsonProperty("합계매수대금")]
    public string? TotalPurchasePrice
    {
        get; set;
    }
    /// <summary>합계순매수</summary>
    [DataMember, JsonProperty("합계순매수")]
    public string? TotalNetPurchase
    {
        get; set;
    }
}