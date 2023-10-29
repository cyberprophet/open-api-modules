using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>동일순매매순위</summary>
public class MultiOpt10062
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>순위</summary>
    [DataMember, JsonProperty("순위")]
    public string? Ranking
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
    /// <summary>기관순매매수량</summary>
    [DataMember, JsonProperty("기관순매매수량")]
    public string? InstitutionalNetSalesVolume
    {
        get; set;
    }
    /// <summary>기관순매매금액</summary>
    [DataMember, JsonProperty("기관순매매금액")]
    public string? InstitutionalNetSalesAmount
    {
        get; set;
    }
    /// <summary>기관순매매평균가</summary>
    [DataMember, JsonProperty("기관순매매평균가")]
    public string? AverageSellingPriceOfTrachea
    {
        get; set;
    }
    /// <summary>외인순매매수량</summary>
    [DataMember, JsonProperty("외인순매매수량")]
    public string? NetForeignTradeVolume
    {
        get; set;
    }
    /// <summary>외인순매매금액</summary>
    [DataMember, JsonProperty("외인순매매금액")]
    public string? NetForeignTradeAmount
    {
        get; set;
    }
    /// <summary>외인순매매평균가</summary>
    [DataMember, JsonProperty("외인순매매평균가")]
    public string? TheAveragePriceOfNetForeigners
    {
        get; set;
    }
    /// <summary>순매매수량</summary>
    [DataMember, JsonProperty("순매매수량")]
    public string? NetSalesVolume
    {
        get; set;
    }
    /// <summary>순매매금액</summary>
    [DataMember, JsonProperty("순매매금액")]
    public string? NetTradingAmount
    {
        get; set;
    }
}