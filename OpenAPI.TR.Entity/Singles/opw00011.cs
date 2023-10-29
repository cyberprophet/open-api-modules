using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>증거금율별주문가능수량조회</summary>
public class SingleOpw00011
{
    /// <summary>종목증거금율</summary>
    [DataMember, JsonProperty("종목증거금율")]
    public string? StockMarginRate
    {
        get; set;
    }
    /// <summary>계좌증거금율</summary>
    [DataMember, JsonProperty("계좌증거금율")]
    public string? AccountMarginRate
    {
        get; set;
    }
    /// <summary>적용증거금율</summary>
    [DataMember, JsonProperty("적용증거금율")]
    public string? ApplicableMarginRate
    {
        get; set;
    }
    /// <summary>증거금20주문가능금액</summary>
    [DataMember, JsonProperty("증거금20주문가능금액")]
    public string? EvidenceFee20OrderableAmount
    {
        get; set;
    }
    /// <summary>증거금20주문가능수량</summary>
    [DataMember, JsonProperty("증거금20주문가능수량")]
    public string? EvidenceFee20OrderableQuantity
    {
        get; set;
    }
    /// <summary>증거금20전일재사용금액</summary>
    [DataMember, JsonProperty("증거금20전일재사용금액")]
    public string? AmountOfEvidenceReUse20DaysAgo
    {
        get; set;
    }
    /// <summary>증거금20금일재사용금액</summary>
    [DataMember, JsonProperty("증거금20금일재사용금액")]
    public string? EvidenceMoney20GoldDaysReUseAmount
    {
        get; set;
    }
    /// <summary>증거금30주문가능금액</summary>
    [DataMember, JsonProperty("증거금30주문가능금액")]
    public string? EvidenceFee30OrderableAmount
    {
        get; set;
    }
    /// <summary>증거금30주문가능수량</summary>
    [DataMember, JsonProperty("증거금30주문가능수량")]
    public string? EvidenceFee30OrderableQuantity
    {
        get; set;
    }
    /// <summary>증거금30전일재사용금액</summary>
    [DataMember, JsonProperty("증거금30전일재사용금액")]
    public string? ReUseAmount30DaysPriorToTheEvidence
    {
        get; set;
    }
    /// <summary>증거금30금일재사용금액</summary>
    [DataMember, JsonProperty("증거금30금일재사용금액")]
    public string? EvidenceMoney30DaysOfReUseAmount
    {
        get; set;
    }
    /// <summary>증거금40주문가능금액</summary>
    [DataMember, JsonProperty("증거금40주문가능금액")]
    public string? EvidenceMoney40OrderableAmount
    {
        get; set;
    }
    /// <summary>증거금40주문가능수량</summary>
    [DataMember, JsonProperty("증거금40주문가능수량")]
    public string? EvidenceFee40OrderableQuantity
    {
        get; set;
    }
    /// <summary>증거금40전일재사용금액</summary>
    [DataMember, JsonProperty("증거금40전일재사용금액")]
    public string? AmountOfEvidenceReUse40DaysAgo
    {
        get; set;
    }
    /// <summary>증거금40금일재사용금액</summary>
    [DataMember, JsonProperty("증거금40금일재사용금액")]
    public string? EvidenceMoney40GoldDaysReUseAmount
    {
        get; set;
    }
    /// <summary>증거금50주문가능금액</summary>
    [DataMember, JsonProperty("증거금50주문가능금액")]
    public string? Evidence50OrderableAmount
    {
        get; set;
    }
    /// <summary>증거금50주문가능수량</summary>
    [DataMember, JsonProperty("증거금50주문가능수량")]
    public string? Confidence50OrderableQuantity
    {
        get; set;
    }
    /// <summary>증거금50전일재사용금액</summary>
    [DataMember, JsonProperty("증거금50전일재사용금액")]
    public string? AmountOfEvidenceReUsed50DaysAgo
    {
        get; set;
    }
    /// <summary>증거금50금일재사용금액</summary>
    [DataMember, JsonProperty("증거금50금일재사용금액")]
    public string? Deposit50DaysReUseAmount
    {
        get; set;
    }
    /// <summary>증거금60주문가능금액</summary>
    [DataMember, JsonProperty("증거금60주문가능금액")]
    public string? Evidence60OrderableAmount
    {
        get; set;
    }
    /// <summary>증거금60주문가능수량</summary>
    [DataMember, JsonProperty("증거금60주문가능수량")]
    public string? EvidenceFee60OrderableQuantity
    {
        get; set;
    }
    /// <summary>증거금60전일재사용금액</summary>
    [DataMember, JsonProperty("증거금60전일재사용금액")]
    public string? AmountOfReUseOnThe60thDayOfEvidence
    {
        get; set;
    }
    /// <summary>증거금60금일재사용금액</summary>
    [DataMember, JsonProperty("증거금60금일재사용금액")]
    public string? Deposit60GoldDaysReUseAmount
    {
        get; set;
    }
    /// <summary>증거금100주문가능금액</summary>
    [DataMember, JsonProperty("증거금100주문가능금액")]
    public string? AmountAvailableForOrderOf100Evidence
    {
        get; set;
    }
    /// <summary>증거금100주문가능수량</summary>
    [DataMember, JsonProperty("증거금100주문가능수량")]
    public string? EvidenceFee100OrderableQuantity
    {
        get; set;
    }
    /// <summary>증거금100전일재사용금액</summary>
    [DataMember, JsonProperty("증거금100전일재사용금액")]
    public string? ReUseAmount100DaysPriorToTheDeposit
    {
        get; set;
    }
    /// <summary>증거금100금일재사용금액</summary>
    [DataMember, JsonProperty("증거금100금일재사용금액")]
    public string? Deposit100DaysReUseAmount
    {
        get; set;
    }
    /// <summary>미수불가주문가능금액</summary>
    [DataMember, JsonProperty("미수불가주문가능금액")]
    public string? AmountAvailableForNonDeliverableOrder
    {
        get; set;
    }
    /// <summary>미수불가주문가능수량</summary>
    [DataMember, JsonProperty("미수불가주문가능수량")]
    public string? NumberOfOrdersNotAvailable
    {
        get; set;
    }
    /// <summary>미수불가전일재사용금액</summary>
    [DataMember, JsonProperty("미수불가전일재사용금액")]
    public string? UnattemptedDateReUseAmount
    {
        get; set;
    }
    /// <summary>미수불가금일재사용금액</summary>
    [DataMember, JsonProperty("미수불가금일재사용금액")]
    public string? AmountUsedAgainOnTheDayOfNonPayment
    {
        get; set;
    }
    /// <summary>예수금</summary>
    [DataMember, JsonProperty("예수금")]
    public string? Deposit
    {
        get; set;
    }
    /// <summary>대용금</summary>
    [DataMember, JsonProperty("대용금")]
    public string? SubstituteMoney
    {
        get; set;
    }
    /// <summary>미수금</summary>
    [DataMember, JsonProperty("미수금")]
    public string? Outstanding
    {
        get; set;
    }
    /// <summary>주문가능대용</summary>
    [DataMember, JsonProperty("주문가능대용")]
    public string? CanBeOrdered
    {
        get; set;
    }
    /// <summary>주문가능현금</summary>
    [DataMember, JsonProperty("주문가능현금")]
    public string? CashAvailableForOrderable
    {
        get; set;
    }
}