using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>시간외단일가</summary>
public class MultiOpt10087
{
    /// <summary>호가잔량기준시간</summary>
    [DataMember, JsonProperty("호가잔량기준시간")]
    public string? DemandRemainingStandardTime
    {
        get; set;
    }
    /// <summary>시간외단일가_매도호가직전대비5</summary>
    [DataMember, JsonProperty("시간외단일가_매도호가직전대비5")]
    public string? SingleAfterHoursPriceSalePrice5ComparedToJustBefore
    {
        get; set;
    }
    /// <summary>시간외단일가_매도호가직전대비4</summary>
    [DataMember, JsonProperty("시간외단일가_매도호가직전대비4")]
    public string? SingleAfterHoursPriceSalePrice4ComparedToJustBefore
    {
        get; set;
    }
    /// <summary>시간외단일가_매도호가직전대비3</summary>
    [DataMember, JsonProperty("시간외단일가_매도호가직전대비3")]
    public string? SingleAfterHoursPriceSalePrice3ComparedToImmediatelyBefore
    {
        get; set;
    }
    /// <summary>시간외단일가_매도호가직전대비2</summary>
    [DataMember, JsonProperty("시간외단일가_매도호가직전대비2")]
    public string? SingleAfterHoursPriceSalePrice2ComparedToImmediatelyBefore
    {
        get; set;
    }
    /// <summary>시간외단일가_매도호가직전대비1</summary>
    [DataMember, JsonProperty("시간외단일가_매도호가직전대비1")]
    public string? SingleAfterHoursPriceSalePrice1ComparedToImmediatelyBefore
    {
        get; set;
    }
    /// <summary>시간외단일가_매도호가수량5</summary>
    [DataMember, JsonProperty("시간외단일가_매도호가수량5")]
    public string? SingleAfterHoursPriceSoldNumber5
    {
        get; set;
    }
    /// <summary>시간외단일가_매도호가수량4</summary>
    [DataMember, JsonProperty("시간외단일가_매도호가수량4")]
    public string? SingleAfterHoursPriceSoldNumber4
    {
        get; set;
    }
    /// <summary>시간외단일가_매도호가수량3</summary>
    [DataMember, JsonProperty("시간외단일가_매도호가수량3")]
    public string? SingleAfterHoursPriceSalesVolume3
    {
        get; set;
    }
    /// <summary>시간외단일가_매도호가수량2</summary>
    [DataMember, JsonProperty("시간외단일가_매도호가수량2")]
    public string? SingleAfterHoursPriceSoldNumber2
    {
        get; set;
    }
    /// <summary>시간외단일가_매도호가수량1</summary>
    [DataMember, JsonProperty("시간외단일가_매도호가수량1")]
    public string? SingleAfterHoursPriceSoldNumber1
    {
        get; set;
    }
    /// <summary>시간외단일가_매도호가5</summary>
    [DataMember, JsonProperty("시간외단일가_매도호가5")]
    public string? SingleAfterHoursPriceSalePrice5
    {
        get; set;
    }
    /// <summary>시간외단일가_매도호가4</summary>
    [DataMember, JsonProperty("시간외단일가_매도호가4")]
    public string? SingleAfterHoursPriceSalePrice4
    {
        get; set;
    }
    /// <summary>시간외단일가_매도호가3</summary>
    [DataMember, JsonProperty("시간외단일가_매도호가3")]
    public string? SingleAfterHoursPriceSalePrice3
    {
        get; set;
    }
    /// <summary>시간외단일가_매도호가2</summary>
    [DataMember, JsonProperty("시간외단일가_매도호가2")]
    public string? SingleAfterHoursPriceSalePrice2
    {
        get; set;
    }
    /// <summary>시간외단일가_매도호가1</summary>
    [DataMember, JsonProperty("시간외단일가_매도호가1")]
    public string? SingleAfterHoursPriceSellingPrice1
    {
        get; set;
    }
    /// <summary>시간외단일가_매수호가1</summary>
    [DataMember, JsonProperty("시간외단일가_매수호가1")]
    public string? SingleAfterHoursPriceBuyingPrice1
    {
        get; set;
    }
    /// <summary>시간외단일가_매수호가2</summary>
    [DataMember, JsonProperty("시간외단일가_매수호가2")]
    public string? SingleAfterHoursPriceBuyPrice2
    {
        get; set;
    }
    /// <summary>시간외단일가_매수호가3</summary>
    [DataMember, JsonProperty("시간외단일가_매수호가3")]
    public string? SingleAfterHoursPriceBuyingPrice3
    {
        get; set;
    }
    /// <summary>시간외단일가_매수호가4</summary>
    [DataMember, JsonProperty("시간외단일가_매수호가4")]
    public string? SingleAfterHoursPriceBuyPrice4
    {
        get; set;
    }
    /// <summary>시간외단일가_매수호가5</summary>
    [DataMember, JsonProperty("시간외단일가_매수호가5")]
    public string? SingleAfterHoursPriceBuyPrice5
    {
        get; set;
    }
    /// <summary>시간외단일가_매수호가수량1</summary>
    [DataMember, JsonProperty("시간외단일가_매수호가수량1")]
    public string? SingleAfterHoursPriceBuyNumber1
    {
        get; set;
    }
    /// <summary>시간외단일가_매수호가수량2</summary>
    [DataMember, JsonProperty("시간외단일가_매수호가수량2")]
    public string? SingleAfterHoursPriceBuyNumber2
    {
        get; set;
    }
    /// <summary>시간외단일가_매수호가수량3</summary>
    [DataMember, JsonProperty("시간외단일가_매수호가수량3")]
    public string? SingleAfterHoursPriceBuyNumber3
    {
        get; set;
    }
    /// <summary>시간외단일가_매수호가수량4</summary>
    [DataMember, JsonProperty("시간외단일가_매수호가수량4")]
    public string? SingleAfterHoursPriceBuyNumber4
    {
        get; set;
    }
    /// <summary>시간외단일가_매수호가수량5</summary>
    [DataMember, JsonProperty("시간외단일가_매수호가수량5")]
    public string? SingleAfterHoursPriceBuyNumber5
    {
        get; set;
    }
    /// <summary>시간외단일가_매수호가직전대비1</summary>
    [DataMember, JsonProperty("시간외단일가_매수호가직전대비1")]
    public string? SingleAfterHoursPriceBuyingPrice1ComparedToImmediatelyBefore
    {
        get; set;
    }
    /// <summary>시간외단일가_매수호가직전대비2</summary>
    [DataMember, JsonProperty("시간외단일가_매수호가직전대비2")]
    public string? SingleAfterHoursPriceBuyingPrice2ComparedToImmediatelyBefore
    {
        get; set;
    }
    /// <summary>시간외단일가_매수호가직전대비3</summary>
    [DataMember, JsonProperty("시간외단일가_매수호가직전대비3")]
    public string? SingleAfterHoursPriceBuyingPrice3ComparedToJustBefore
    {
        get; set;
    }
    /// <summary>시간외단일가_매수호가직전대비4</summary>
    [DataMember, JsonProperty("시간외단일가_매수호가직전대비4")]
    public string? SingleAfterHoursPriceBuyingPrice4ComparedToJustBefore
    {
        get; set;
    }
    /// <summary>시간외단일가_매수호가직전대비5</summary>
    [DataMember, JsonProperty("시간외단일가_매수호가직전대비5")]
    public string? SingleAfterHoursPriceBuyingPrice5ComparedToJustBefore
    {
        get; set;
    }
    /// <summary>시간외단일가_매도호가총잔량</summary>
    [DataMember, JsonProperty("시간외단일가_매도호가총잔량")]
    public string? SingleAfterHoursPriceSellPriceTotalRemaining
    {
        get; set;
    }
    /// <summary>시간외단일가_매수호가총잔량</summary>
    [DataMember, JsonProperty("시간외단일가_매수호가총잔량")]
    public string? SinglePriceAfterHourTotalAmountOfPurchasePriceRemaining
    {
        get; set;
    }
    /// <summary>매도호가총잔량직전대비</summary>
    [DataMember, JsonProperty("매도호가총잔량직전대비")]
    public string? SellingPriceComparedToTotalRemainingVolumeJustBefore
    {
        get; set;
    }
    /// <summary>매도호가총잔량</summary>
    [DataMember, JsonProperty("매도호가총잔량")]
    public string? TotalBacklogOfSellingPrices
    {
        get; set;
    }
    /// <summary>매수호가총잔량</summary>
    [DataMember, JsonProperty("매수호가총잔량")]
    public string? TotalRemainingAmountOfTheBuyersAskingPrice
    {
        get; set;
    }
    /// <summary>매수호가총잔량직전대비</summary>
    [DataMember, JsonProperty("매수호가총잔량직전대비")]
    public string? BuyingPriceComparedToTotalRemainingVolumeJustBefore
    {
        get; set;
    }
    /// <summary>시간외매도호가총잔량직전대비</summary>
    [DataMember, JsonProperty("시간외매도호가총잔량직전대비")]
    public string? AfterHoursSellingPriceComparedToJustBeforeTheTotalRemainingAmount
    {
        get; set;
    }
    /// <summary>시간외매도호가총잔량</summary>
    [DataMember, JsonProperty("시간외매도호가총잔량")]
    public string? TotalOutOfHoursSellingPriceRemaining
    {
        get; set;
    }
    /// <summary>시간외매수호가총잔량</summary>
    [DataMember, JsonProperty("시간외매수호가총잔량")]
    public string? TotalOutOfHoursPurchasePriceRemaining
    {
        get; set;
    }
    /// <summary>시간외매수호가총잔량직전대비</summary>
    [DataMember, JsonProperty("시간외매수호가총잔량직전대비")]
    public string? AfterHoursBuyingComparedToJustBeforeTheTotalRemainingAmount
    {
        get; set;
    }
    /// <summary>시간외단일가_현재가</summary>
    [DataMember, JsonProperty("시간외단일가_현재가")]
    public string? SingleAfterHoursPriceCurrentPrice
    {
        get; set;
    }
    /// <summary>시간외단일가_전일대비기호</summary>
    [DataMember, JsonProperty("시간외단일가_전일대비기호")]
    public string? SingleAfterHoursPriceSymbolComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>시간외단일가_전일대비</summary>
    [DataMember, JsonProperty("시간외단일가_전일대비")]
    public string? SingleAfterHoursPriceComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>시간외단일가_등락률</summary>
    [DataMember, JsonProperty("시간외단일가_등락률")]
    public string? AfterHoursSinglePriceEntertainmentRate
    {
        get; set;
    }
    /// <summary>시간외단일가_누적거래량</summary>
    [DataMember, JsonProperty("시간외단일가_누적거래량")]
    public string? AfterHoursSinglePriceAccumulatedTradingVolume
    {
        get; set;
    }
}