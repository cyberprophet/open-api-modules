using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식거래원</summary>
public class MultiOpt10002
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
    /// <summary>등락부호</summary>
    [DataMember, JsonProperty("등락부호")]
    public string? FluctuationSign
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public string? AStandardPrice
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
    /// <summary>매도거래원명1</summary>
    [DataMember, JsonProperty("매도거래원명1")]
    public string? NameOfSeller1
    {
        get; set;
    }
    /// <summary>매도거래원1</summary>
    [DataMember, JsonProperty("매도거래원1")]
    public string? SellingAgent1
    {
        get; set;
    }
    /// <summary>매도거래량1</summary>
    [DataMember, JsonProperty("매도거래량1")]
    public string? SalesVolume1
    {
        get; set;
    }
    /// <summary>매수거래원명1</summary>
    [DataMember, JsonProperty("매수거래원명1")]
    public string? PurchaseAccountName1
    {
        get; set;
    }
    /// <summary>매수거래원1</summary>
    [DataMember, JsonProperty("매수거래원1")]
    public string? Buyer1
    {
        get; set;
    }
    /// <summary>매수거래량1</summary>
    [DataMember, JsonProperty("매수거래량1")]
    public string? PurchaseVolume1
    {
        get; set;
    }
    /// <summary>매도거래원명2</summary>
    [DataMember, JsonProperty("매도거래원명2")]
    public string? NameOfSeller2
    {
        get; set;
    }
    /// <summary>매도거래원2</summary>
    [DataMember, JsonProperty("매도거래원2")]
    public string? SellingAgent2
    {
        get; set;
    }
    /// <summary>매도거래량2</summary>
    [DataMember, JsonProperty("매도거래량2")]
    public string? SalesVolume2
    {
        get; set;
    }
    /// <summary>매수거래원명2</summary>
    [DataMember, JsonProperty("매수거래원명2")]
    public string? PurchaseAccountName2
    {
        get; set;
    }
    /// <summary>매수거래원2</summary>
    [DataMember, JsonProperty("매수거래원2")]
    public string? Buyer2
    {
        get; set;
    }
    /// <summary>매수거래량2</summary>
    [DataMember, JsonProperty("매수거래량2")]
    public string? PurchaseVolume2
    {
        get; set;
    }
    /// <summary>매도거래원명3</summary>
    [DataMember, JsonProperty("매도거래원명3")]
    public string? NameOfSeller3
    {
        get; set;
    }
    /// <summary>매도거래원3</summary>
    [DataMember, JsonProperty("매도거래원3")]
    public string? SellingAgent3
    {
        get; set;
    }
    /// <summary>매도거래량3</summary>
    [DataMember, JsonProperty("매도거래량3")]
    public string? SalesVolume3
    {
        get; set;
    }
    /// <summary>매수거래원명3</summary>
    [DataMember, JsonProperty("매수거래원명3")]
    public string? NameOfBuyer3
    {
        get; set;
    }
    /// <summary>매수거래원3</summary>
    [DataMember, JsonProperty("매수거래원3")]
    public string? Buyer3
    {
        get; set;
    }
    /// <summary>매수거래량3</summary>
    [DataMember, JsonProperty("매수거래량3")]
    public string? PurchaseVolume3
    {
        get; set;
    }
    /// <summary>매도거래원명4</summary>
    [DataMember, JsonProperty("매도거래원명4")]
    public string? NameOfSeller4
    {
        get; set;
    }
    /// <summary>매도거래원4</summary>
    [DataMember, JsonProperty("매도거래원4")]
    public string? SellingAgent4
    {
        get; set;
    }
    /// <summary>매도거래량4</summary>
    [DataMember, JsonProperty("매도거래량4")]
    public string? SalesVolume4
    {
        get; set;
    }
    /// <summary>매수거래원명4</summary>
    [DataMember, JsonProperty("매수거래원명4")]
    public string? PurchaseAccountName4
    {
        get; set;
    }
    /// <summary>매수거래원4</summary>
    [DataMember, JsonProperty("매수거래원4")]
    public string? Buyer4
    {
        get; set;
    }
    /// <summary>매수거래량4</summary>
    [DataMember, JsonProperty("매수거래량4")]
    public string? PurchaseVolume4
    {
        get; set;
    }
    /// <summary>매도거래원명5</summary>
    [DataMember, JsonProperty("매도거래원명5")]
    public string? NameOfSeller5
    {
        get; set;
    }
    /// <summary>매도거래원5</summary>
    [DataMember, JsonProperty("매도거래원5")]
    public string? Salesperson5
    {
        get; set;
    }
    /// <summary>매도거래량5</summary>
    [DataMember, JsonProperty("매도거래량5")]
    public string? SalesVolume5
    {
        get; set;
    }
    /// <summary>매수거래원명5</summary>
    [DataMember, JsonProperty("매수거래원명5")]
    public string? PurchaseAccountName5
    {
        get; set;
    }
    /// <summary>매수거래원5</summary>
    [DataMember, JsonProperty("매수거래원5")]
    public string? Buyer5
    {
        get; set;
    }
    /// <summary>매수거래량5</summary>
    [DataMember, JsonProperty("매수거래량5")]
    public string? PurchaseVolume5
    {
        get; set;
    }
}