using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>거래원매물대분석</summary>
public class MultiOpt10043
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>종가</summary>
    [DataMember, JsonProperty("종가")]
    public string? ClosingPrice
    {
        get; set;
    }
    /// <summary>대비기호</summary>
    [DataMember, JsonProperty("대비기호")]
    public string? ContrastSymbol
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>매도량</summary>
    [DataMember, JsonProperty("매도량")]
    public string? SellingVolume
    {
        get; set;
    }
    /// <summary>매수량</summary>
    [DataMember, JsonProperty("매수량")]
    public string? TheAmountOfGoods
    {
        get; set;
    }
    /// <summary>순매수수량</summary>
    [DataMember, JsonProperty("순매수수량")]
    public string? NetPurchaseQuantity
    {
        get; set;
    }
    /// <summary>거래량합</summary>
    [DataMember, JsonProperty("거래량합")]
    public string? TotalVolumeOfTransactions
    {
        get; set;
    }
    /// <summary>거래비중</summary>
    [DataMember, JsonProperty("거래비중")]
    public string? TransactionWeight
    {
        get; set;
    }
}