using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>기관외국인연속매매현황</summary>
public class MultiOpt10131
{
    /// <summary>순위</summary>
    [DataMember, JsonProperty("순위")]
    public string? Ranking
    {
        get; set;
    }
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
    /// <summary>기간중주가등락률</summary>
    [DataMember, JsonProperty("기간중주가등락률")]
    public string? PeriodStockPriceFluctuationRate
    {
        get; set;
    }
    /// <summary>기관순매매금액</summary>
    [DataMember, JsonProperty("기관순매매금액")]
    public string? InstitutionalNetSalesAmount
    {
        get; set;
    }
    /// <summary>기관순매매량</summary>
    [DataMember, JsonProperty("기관순매매량")]
    public string? NetTrachealTradeVolume
    {
        get; set;
    }
    /// <summary>기관계연속순매수일수</summary>
    [DataMember, JsonProperty("기관계연속순매수일수")]
    public string? NumberOfConsecutiveDaysOfInstitutionalNetBuying
    {
        get; set;
    }
    /// <summary>기관계연속순매수량</summary>
    [DataMember, JsonProperty("기관계연속순매수량")]
    public string? ContinuousPurchaseVolumeOfEngineSystem
    {
        get; set;
    }
    /// <summary>기관계연속순매수금액</summary>
    [DataMember, JsonProperty("기관계연속순매수금액")]
    public string? ContinuousPurchaseAmountOfEngineSystem
    {
        get; set;
    }
    /// <summary>외국인순매매량</summary>
    [DataMember, JsonProperty("외국인순매매량")]
    public string? NetForeignTradeVolume
    {
        get; set;
    }
    /// <summary>외국인순매매액</summary>
    [DataMember, JsonProperty("외국인순매매액")]
    public string? NetForeignTrade
    {
        get; set;
    }
    /// <summary>외국인연속순매수일수</summary>
    [DataMember, JsonProperty("외국인연속순매수일수")]
    public string? NumberOfConsecutiveNetBuyingDaysForForeigners
    {
        get; set;
    }
    /// <summary>외국인연속순매수량</summary>
    [DataMember, JsonProperty("외국인연속순매수량")]
    public string? ForeignersNetBuyingVolumeInARow
    {
        get; set;
    }
    /// <summary>외국인연속순매수금액</summary>
    [DataMember, JsonProperty("외국인연속순매수금액")]
    public string? NetPurchaseAmountOfForeignersContinuously
    {
        get; set;
    }
    /// <summary>순매매량</summary>
    [DataMember, JsonProperty("순매매량")]
    public string? NetTradingVolume
    {
        get; set;
    }
    /// <summary>순매매액</summary>
    [DataMember, JsonProperty("순매매액")]
    public string? NetSellingAmount
    {
        get; set;
    }
    /// <summary>합계연속순매수일수</summary>
    [DataMember, JsonProperty("합계연속순매수일수")]
    public string? TotalNumberOfConsecutiveNetBuyingDays
    {
        get; set;
    }
    /// <summary>합계연속순매매수량</summary>
    [DataMember, JsonProperty("합계연속순매매수량")]
    public string? TotalContinuousNetSalesVolume
    {
        get; set;
    }
    /// <summary>합계연속순매수금액</summary>
    [DataMember, JsonProperty("합계연속순매수금액")]
    public string? TotalContinuousNetPurchaseAmount
    {
        get; set;
    }
}