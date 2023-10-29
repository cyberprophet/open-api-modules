using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>신용보증금율별주문가능수량조회</summary>
public class SingleOPW00012
{
    /// <summary>종목보증금율</summary>
    [DataMember, JsonProperty("종목보증금율")]
    public string? DepositRate
    {
        get; set;
    }
    /// <summary>종목보증금율명</summary>
    [DataMember, JsonProperty("종목보증금율명")]
    public string? NameOfStockDepositRateName
    {
        get; set;
    }
    /// <summary>보증금30주문가능금액</summary>
    [DataMember, JsonProperty("보증금30주문가능금액")]
    public string? Deposit30OrderableAmount
    {
        get; set;
    }
    /// <summary>보증금30주문가능수량</summary>
    [DataMember, JsonProperty("보증금30주문가능수량")]
    public string? Deposit30OrderableQuantity
    {
        get; set;
    }
    /// <summary>보증금30전일재사용금액</summary>
    [DataMember, JsonProperty("보증금30전일재사용금액")]
    public string? ReUseAmount30DaysBeforeDeposit
    {
        get; set;
    }
    /// <summary>보증금30금일재사용금액</summary>
    [DataMember, JsonProperty("보증금30금일재사용금액")]
    public string? Deposit30GoldDaysReUseAmount
    {
        get; set;
    }
    /// <summary>보증금40주문가능금액</summary>
    [DataMember, JsonProperty("보증금40주문가능금액")]
    public string? Deposit40OrderableAmount
    {
        get; set;
    }
    /// <summary>보증금40주문가능수량</summary>
    [DataMember, JsonProperty("보증금40주문가능수량")]
    public string? Deposit40OrderableQuantity
    {
        get; set;
    }
    /// <summary>보증금40전일재사용금액</summary>
    [DataMember, JsonProperty("보증금40전일재사용금액")]
    public string? ReUseAmountBeforeDeposit40
    {
        get; set;
    }
    /// <summary>보증금40금일재사용금액</summary>
    [DataMember, JsonProperty("보증금40금일재사용금액")]
    public string? Deposit40GoldDaysReUseAmount
    {
        get; set;
    }
    /// <summary>보증금50주문가능금액</summary>
    [DataMember, JsonProperty("보증금50주문가능금액")]
    public string? Deposit50OrderableAmount
    {
        get; set;
    }
    /// <summary>보증금50주문가능수량</summary>
    [DataMember, JsonProperty("보증금50주문가능수량")]
    public string? Deposit50OrderableQuantity
    {
        get; set;
    }
    /// <summary>보증금50전일재사용금액</summary>
    [DataMember, JsonProperty("보증금50전일재사용금액")]
    public string? ReUseAmountBeforeDeposit50
    {
        get; set;
    }
    /// <summary>보증금50금일재사용금액</summary>
    [DataMember, JsonProperty("보증금50금일재사용금액")]
    public string? Deposit50GoldDaysReUseAmount
    {
        get; set;
    }
    /// <summary>보증금60주문가능금액</summary>
    [DataMember, JsonProperty("보증금60주문가능금액")]
    public string? Deposit60AmountAvailableToOrder
    {
        get; set;
    }
    /// <summary>보증금60주문가능수량</summary>
    [DataMember, JsonProperty("보증금60주문가능수량")]
    public string? Deposit60OrderableQuantity
    {
        get; set;
    }
    /// <summary>보증금60전일재사용금액</summary>
    [DataMember, JsonProperty("보증금60전일재사용금액")]
    public string? ReUseAmountBeforeDeposit60
    {
        get; set;
    }
    /// <summary>보증금60금일재사용금액</summary>
    [DataMember, JsonProperty("보증금60금일재사용금액")]
    public string? Deposit60GoldDaysReUseAmount
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
    /// <summary>미수가능금액</summary>
    [DataMember, JsonProperty("미수가능금액")]
    public string? AmountReceivable
    {
        get; set;
    }
    /// <summary>미수가능수량</summary>
    [DataMember, JsonProperty("미수가능수량")]
    public string? UnavailableQuantity
    {
        get; set;
    }
    /// <summary>미수불가금액</summary>
    [DataMember, JsonProperty("미수불가금액")]
    public string? UnpaidAmount
    {
        get; set;
    }
    /// <summary>미수불가수량</summary>
    [DataMember, JsonProperty("미수불가수량")]
    public string? UnpaidQuantity
    {
        get; set;
    }
}