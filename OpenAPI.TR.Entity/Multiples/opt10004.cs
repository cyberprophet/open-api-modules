using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식호가</summary>
public class MultiOpt10004
{
    /// <summary>호가잔량기준시간</summary>
    [DataMember, JsonProperty("호가잔량기준시간")]
    public string? DemandRemainingStandardTime
    {
        get; set;
    }
    /// <summary>매도10차선잔량대비</summary>
    [DataMember, JsonProperty("매도10차선잔량대비")]
    public string? ComparedTo10LaneRemainingSales
    {
        get; set;
    }
    /// <summary>매도10차선잔량</summary>
    [DataMember, JsonProperty("매도10차선잔량")]
    public string? _10LaneRemainingForSale
    {
        get; set;
    }
    /// <summary>매도10차선호가</summary>
    [DataMember, JsonProperty("매도10차선호가")]
    public string? _10thSellingPreference
    {
        get; set;
    }
    /// <summary>매도9차선잔량대비</summary>
    [DataMember, JsonProperty("매도9차선잔량대비")]
    public string? ComparedTo9LaneRemainingSales
    {
        get; set;
    }
    /// <summary>매도9차선잔량</summary>
    [DataMember, JsonProperty("매도9차선잔량")]
    public string? _9thLaneRemainingForSale
    {
        get; set;
    }
    /// <summary>매도9차선호가</summary>
    [DataMember, JsonProperty("매도9차선호가")]
    public string? _9thSellingPreference
    {
        get; set;
    }
    /// <summary>매도8차선잔량대비</summary>
    [DataMember, JsonProperty("매도8차선잔량대비")]
    public string? ComparedTo8LaneRemainingSales
    {
        get; set;
    }
    /// <summary>매도8차선잔량</summary>
    [DataMember, JsonProperty("매도8차선잔량")]
    public string? _8LaneRemainingForSale
    {
        get; set;
    }
    /// <summary>매도8차선호가</summary>
    [DataMember, JsonProperty("매도8차선호가")]
    public string? _8thPreferenceForSelling
    {
        get; set;
    }
    /// <summary>매도7차선잔량대비</summary>
    [DataMember, JsonProperty("매도7차선잔량대비")]
    public string? ComparedTo7LaneRemainingSales
    {
        get; set;
    }
    /// <summary>매도7차선잔량</summary>
    [DataMember, JsonProperty("매도7차선잔량")]
    public string? SevenlaneSellingRemainingCapacity
    {
        get; set;
    }
    /// <summary>매도7차선호가</summary>
    [DataMember, JsonProperty("매도7차선호가")]
    public string? _7thPreferenceForSellingPrice
    {
        get; set;
    }
    /// <summary>매도6차선잔량대비</summary>
    [DataMember, JsonProperty("매도6차선잔량대비")]
    public string? ComparedTo6LaneRemainingSales
    {
        get; set;
    }
    /// <summary>매도6우선잔량</summary>
    [DataMember, JsonProperty("매도6우선잔량")]
    public string? Selling6PreferredRemainingVolume
    {
        get; set;
    }
    /// <summary>매도6차선호가</summary>
    [DataMember, JsonProperty("매도6차선호가")]
    public string? _6thPreferenceForSellingPrice
    {
        get; set;
    }
    /// <summary>매도5차선잔량대비</summary>
    [DataMember, JsonProperty("매도5차선잔량대비")]
    public string? ComparedTo5LaneRemainingSales
    {
        get; set;
    }
    /// <summary>매도5차선잔량</summary>
    [DataMember, JsonProperty("매도5차선잔량")]
    public string? FivelaneSellingRemainingCapacity
    {
        get; set;
    }
    /// <summary>매도5차선호가</summary>
    [DataMember, JsonProperty("매도5차선호가")]
    public string? _5thPreferencePrice
    {
        get; set;
    }
    /// <summary>매도4차선잔량대비</summary>
    [DataMember, JsonProperty("매도4차선잔량대비")]
    public string? ComparedTo4LaneRemainingSales
    {
        get; set;
    }
    /// <summary>매도4차선잔량</summary>
    [DataMember, JsonProperty("매도4차선잔량")]
    public string? _4laneSellingRemainingCapacity
    {
        get; set;
    }
    /// <summary>매도4차선호가</summary>
    [DataMember, JsonProperty("매도4차선호가")]
    public string? _4thSellingPreference
    {
        get; set;
    }
    /// <summary>매도3차선잔량대비</summary>
    [DataMember, JsonProperty("매도3차선잔량대비")]
    public string? ComparedToTheThreelaneBalance
    {
        get; set;
    }
    /// <summary>매도3차선잔량</summary>
    [DataMember, JsonProperty("매도3차선잔량")]
    public string? _3rdLaneRemainingForSale
    {
        get; set;
    }
    /// <summary>매도3차선호가</summary>
    [DataMember, JsonProperty("매도3차선호가")]
    public string? _3rdPreferredPriceForSale
    {
        get; set;
    }
    /// <summary>매도2차선잔량대비</summary>
    [DataMember, JsonProperty("매도2차선잔량대비")]
    public string? ComparedToTheTwolaneBalanceOfSales
    {
        get; set;
    }
    /// <summary>매도2차선잔량</summary>
    [DataMember, JsonProperty("매도2차선잔량")]
    public string? TwolaneSellingRemainingCapacity
    {
        get; set;
    }
    /// <summary>매도2차선호가</summary>
    [DataMember, JsonProperty("매도2차선호가")]
    public string? SecondarySellingPrice
    {
        get; set;
    }
    /// <summary>매도1차선잔량대비</summary>
    [DataMember, JsonProperty("매도1차선잔량대비")]
    public string? ComparedToTheRemainingAmountOfTheFirstLaneOfSale
    {
        get; set;
    }
    /// <summary>매도최우선잔량</summary>
    [DataMember, JsonProperty("매도최우선잔량")]
    public string? SalesHighestPriorityRemainingAmount
    {
        get; set;
    }
    /// <summary>매도최우선호가</summary>
    [DataMember, JsonProperty("매도최우선호가")]
    public string? TheHighestSellingPrice
    {
        get; set;
    }
    /// <summary>매수최우선호가</summary>
    [DataMember, JsonProperty("매수최우선호가")]
    public string? TheHighestPurchasePrice
    {
        get; set;
    }
    /// <summary>매수최우선잔량</summary>
    [DataMember, JsonProperty("매수최우선잔량")]
    public string? PurchaseHighestPriorityRemainingAmount
    {
        get; set;
    }
    /// <summary>매수1차선잔량대비</summary>
    [DataMember, JsonProperty("매수1차선잔량대비")]
    public string? ComparedToTheRemainingAmountOfTheFirstLaneOfPurchase
    {
        get; set;
    }
    /// <summary>매수2차선호가</summary>
    [DataMember, JsonProperty("매수2차선호가")]
    public string? SecondPreferenceForBuyingPrice
    {
        get; set;
    }
    /// <summary>매수2차선잔량</summary>
    [DataMember, JsonProperty("매수2차선잔량")]
    public string? TwoLanesOfBuyRemainingCapacity
    {
        get; set;
    }
    /// <summary>매수2차선잔량대비</summary>
    [DataMember, JsonProperty("매수2차선잔량대비")]
    public string? ComparedToTheRemainingAmountOfTwoLanesForPurchase
    {
        get; set;
    }
    /// <summary>매수3차선호가</summary>
    [DataMember, JsonProperty("매수3차선호가")]
    public string? _3rdPreferenceForBuying
    {
        get; set;
    }
    /// <summary>매수3차선잔량</summary>
    [DataMember, JsonProperty("매수3차선잔량")]
    public string? ThreelaneSpareCapacity
    {
        get; set;
    }
    /// <summary>매수3차선잔량대비</summary>
    [DataMember, JsonProperty("매수3차선잔량대비")]
    public string? ComparedToTheRemainingAmountOfThreeLanesForPurchase
    {
        get; set;
    }
    /// <summary>매수4차선호가</summary>
    [DataMember, JsonProperty("매수4차선호가")]
    public string? Purchase4thPreferencePrice
    {
        get; set;
    }
    /// <summary>매수4차선잔량</summary>
    [DataMember, JsonProperty("매수4차선잔량")]
    public string? FourLanesOfBuyingRemainingCapacity
    {
        get; set;
    }
    /// <summary>매수4차선잔량대비</summary>
    [DataMember, JsonProperty("매수4차선잔량대비")]
    public string? ComparedToTheRemainingCapacityOfFourLanesForPurchase
    {
        get; set;
    }
    /// <summary>매수5차선호가</summary>
    [DataMember, JsonProperty("매수5차선호가")]
    public string? _5thPreferenceForBuyingPrice
    {
        get; set;
    }
    /// <summary>매수5차선잔량</summary>
    [DataMember, JsonProperty("매수5차선잔량")]
    public string? FiveLanesOfPurchaseRemainingCapacity
    {
        get; set;
    }
    /// <summary>매수5차선잔량대비</summary>
    [DataMember, JsonProperty("매수5차선잔량대비")]
    public string? ComparedToTheRemainingAmountOf5LanesForPurchase
    {
        get; set;
    }
    /// <summary>매수6우선호가</summary>
    [DataMember, JsonProperty("매수6우선호가")]
    public string? Buy6PreferredPrice
    {
        get; set;
    }
    /// <summary>매수6우선잔량</summary>
    [DataMember, JsonProperty("매수6우선잔량")]
    public string? _6PreferredRemainingCapacity
    {
        get; set;
    }
    /// <summary>매수6차선잔량대비</summary>
    [DataMember, JsonProperty("매수6차선잔량대비")]
    public string? ComparedToTheAmountOfRemaining6LanesForPurchase
    {
        get; set;
    }
    /// <summary>매수7차선호가</summary>
    [DataMember, JsonProperty("매수7차선호가")]
    public string? _7thPreferenceForBuyingPrice
    {
        get; set;
    }
    /// <summary>매수7차선잔량</summary>
    [DataMember, JsonProperty("매수7차선잔량")]
    public string? SevenLanesOfBuyingRemainingCapacity
    {
        get; set;
    }
    /// <summary>매수7차선잔량대비</summary>
    [DataMember, JsonProperty("매수7차선잔량대비")]
    public string? ComparedToTheRemainingCapacityOf7LanesForPurchase
    {
        get; set;
    }
    /// <summary>매수8차선호가</summary>
    [DataMember, JsonProperty("매수8차선호가")]
    public string? _8thPreferenceForBuyingPrice
    {
        get; set;
    }
    /// <summary>매수8차선잔량</summary>
    [DataMember, JsonProperty("매수8차선잔량")]
    public string? _8thLaneRemainingCapacity
    {
        get; set;
    }
    /// <summary>매수8차선잔량대비</summary>
    [DataMember, JsonProperty("매수8차선잔량대비")]
    public string? ComparedTo8LaneRemainingCapacity
    {
        get; set;
    }
    /// <summary>매수9차선호가</summary>
    [DataMember, JsonProperty("매수9차선호가")]
    public string? _9thPurchasePreference
    {
        get; set;
    }
    /// <summary>매수9차선잔량</summary>
    [DataMember, JsonProperty("매수9차선잔량")]
    public string? _9thLaneRemainingCapacity
    {
        get; set;
    }
    /// <summary>매수9차선잔량대비</summary>
    [DataMember, JsonProperty("매수9차선잔량대비")]
    public string? ComparedTo9LaneRemainingCapacity
    {
        get; set;
    }
    /// <summary>매수10차선호가</summary>
    [DataMember, JsonProperty("매수10차선호가")]
    public string? _10thPurchasePreference
    {
        get; set;
    }
    /// <summary>매수10차선잔량</summary>
    [DataMember, JsonProperty("매수10차선잔량")]
    public string? TenLanesOfPurchaseRemainingCapacity
    {
        get; set;
    }
    /// <summary>매수10차선잔량대비</summary>
    [DataMember, JsonProperty("매수10차선잔량대비")]
    public string? ComparedToTheRemaining10LanesOf10LanesForPurchase
    {
        get; set;
    }
    /// <summary>총매도잔량직전대비</summary>
    [DataMember, JsonProperty("총매도잔량직전대비")]
    public string? TotalSalesBacklogComparedToJustBefore
    {
        get; set;
    }
    /// <summary>총매도잔량</summary>
    [DataMember, JsonProperty("총매도잔량")]
    public string? TotalRemainingSales
    {
        get; set;
    }
    /// <summary>총매수잔량</summary>
    [DataMember, JsonProperty("총매수잔량")]
    public string? TotalPurchaseBacklog
    {
        get; set;
    }
    /// <summary>총매수잔량직전대비</summary>
    [DataMember, JsonProperty("총매수잔량직전대비")]
    public string? TotalPurchaseRemainingAmountComparedToImmediatelyBefore
    {
        get; set;
    }
    /// <summary>시간외매도잔량대비</summary>
    [DataMember, JsonProperty("시간외매도잔량대비")]
    public string? ComparedToAfterhoursSalesRemaining
    {
        get; set;
    }
    /// <summary>시간외매도잔량</summary>
    [DataMember, JsonProperty("시간외매도잔량")]
    public string? OutofhoursSellingRemainingAmount
    {
        get; set;
    }
    /// <summary>시간외매수잔량</summary>
    [DataMember, JsonProperty("시간외매수잔량")]
    public string? OutofhoursPurchaseRemaining
    {
        get; set;
    }
    /// <summary>시간외매수잔량대비</summary>
    [DataMember, JsonProperty("시간외매수잔량대비")]
    public string? ComparedToTheAmountOfAfterhoursPurchaseRemaining
    {
        get; set;
    }
}