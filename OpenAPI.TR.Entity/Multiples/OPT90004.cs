using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별프로그램매매현황</summary>
public class MultiOPT90004
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
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>등락기호</summary>
    [DataMember, JsonProperty("등락기호")]
    public string? FluctuationSymbol
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>매수체결수량</summary>
    [DataMember, JsonProperty("매수체결수량")]
    public string? PurchaseConclusionQuantity
    {
        get; set;
    }
    /// <summary>매수체결금액</summary>
    [DataMember, JsonProperty("매수체결금액")]
    public string? PurchaseConclusionAmount
    {
        get; set;
    }
    /// <summary>매도체결수량</summary>
    [DataMember, JsonProperty("매도체결수량")]
    public string? NumberOfSalesVolume
    {
        get; set;
    }
    /// <summary>매도체결금액</summary>
    [DataMember, JsonProperty("매도체결금액")]
    public string? SaleClosingAmount
    {
        get; set;
    }
    /// <summary>순매수대금</summary>
    [DataMember, JsonProperty("순매수대금")]
    public string? NetPurchasePrice
    {
        get; set;
    }
    /// <summary>전체거래비율</summary>
    [DataMember, JsonProperty("전체거래비율")]
    public string? TotalTransactionRatio
    {
        get; set;
    }
}