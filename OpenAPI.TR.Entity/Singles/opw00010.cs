using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주문인출가능금액</summary>
public class SingleOpw00010
{
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
    /// <summary>증거금감면60주문가능금</summary>
    [DataMember, JsonProperty("증거금감면60주문가능금")]
    public string? DeductionOfDeposit60OrderableMoney
    {
        get; set;
    }
    /// <summary>증거금감면60주문가능수</summary>
    [DataMember, JsonProperty("증거금감면60주문가능수")]
    public string? NumberOfOrdersAvailableFor60DepositReduction
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
    /// <summary>전일재사용가능금액</summary>
    [DataMember, JsonProperty("전일재사용가능금액")]
    public string? AmountAvailableForReUseThePreviousDay
    {
        get; set;
    }
    /// <summary>금일재사용가능금액</summary>
    [DataMember, JsonProperty("금일재사용가능금액")]
    public string? AmountAvailableForReuseToday
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
    /// <summary>인출가능금액</summary>
    [DataMember, JsonProperty("인출가능금액")]
    public string? WithdrawableAmount
    {
        get; set;
    }
    /// <summary>익일인출가능금액</summary>
    [DataMember, JsonProperty("익일인출가능금액")]
    public string? NextDayWithdrawableAmount
    {
        get; set;
    }
    /// <summary>매입금액</summary>
    [DataMember, JsonProperty("매입금액")]
    public string? PurchaseAmount
    {
        get; set;
    }
    /// <summary>수수료</summary>
    [DataMember, JsonProperty("수수료")]
    public string? Fee
    {
        get; set;
    }
    /// <summary>매입정산금</summary>
    [DataMember, JsonProperty("매입정산금")]
    public string? PurchaseSettlementMoney
    {
        get; set;
    }
    /// <summary>D2추정예수금</summary>
    [DataMember, JsonProperty("D2추정예수금")]
    public string? D2EstimateDeposit
    {
        get; set;
    }
    /// <summary>증거금감면적용구분</summary>
    [DataMember, JsonProperty("증거금감면적용구분")]
    public string? ClassificationOfApplicationOfDepositReductionAndExemption
    {
        get; set;
    }
}