using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>장중투자자별매매</summary>
public class MultiOpt10063
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? ThePresentPrice
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
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? FluctuationRate
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? AccumulatedTradingVolume
    {
        get; set;
    }
    /// <summary>순매수금액</summary>
    [DataMember, JsonProperty("순매수금액")]
    public string? NetPurchaseAmount
    {
        get; set;
    }
    /// <summary>이전순매수금액</summary>
    [DataMember, JsonProperty("이전순매수금액")]
    public string? PreviousNetPurchaseAmount
    {
        get; set;
    }
    /// <summary>순매수금액증감</summary>
    [DataMember, JsonProperty("순매수금액증감")]
    public string? IncreaseOrDecreaseInNetPurchaseAmount
    {
        get; set;
    }
    /// <summary>매수금액</summary>
    [DataMember, JsonProperty("매수금액")]
    public string? PurchaseAmount
    {
        get; set;
    }
    /// <summary>매수금액증감</summary>
    [DataMember, JsonProperty("매수금액증감")]
    public string? IncreaseOrDecreaseInPurchaseAmount
    {
        get; set;
    }
    /// <summary>매도금액</summary>
    [DataMember, JsonProperty("매도금액")]
    public string? SellingAmount
    {
        get; set;
    }
    /// <summary>매도금액증감</summary>
    [DataMember, JsonProperty("매도금액증감")]
    public string? IncreaseOrDecreaseInSellingAmount
    {
        get; set;
    }
    /// <summary>순매수수량</summary>
    [DataMember, JsonProperty("순매수수량")]
    public string? NetPurchaseQuantity
    {
        get; set;
    }
    /// <summary>이점시전순매수수량</summary>
    [DataMember, JsonProperty("이점시전순매수수량")]
    public string? NetPurchaseQuantityBeforeBenefit
    {
        get; set;
    }
    /// <summary>순매수증감</summary>
    [DataMember, JsonProperty("순매수증감")]
    public string? AnIncreaseOrDecreaseInNetBuying
    {
        get; set;
    }
    /// <summary>매수수량</summary>
    [DataMember, JsonProperty("매수수량")]
    public string? PurchaseQuantity
    {
        get; set;
    }
    /// <summary>매수수량증감</summary>
    [DataMember, JsonProperty("매수수량증감")]
    public string? IncreaseOrDecreaseTheNumberOfPurchases
    {
        get; set;
    }
    /// <summary>매도수량</summary>
    [DataMember, JsonProperty("매도수량")]
    public string? SalesVolume
    {
        get; set;
    }
    /// <summary>매도수량증감</summary>
    [DataMember, JsonProperty("매도수량증감")]
    public string? IncreaseInSalesVolume
    {
        get; set;
    }
}