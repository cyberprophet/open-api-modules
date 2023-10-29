using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별예수금현황</summary>
public class MultiOpw00001
{
    /// <summary>통화코드</summary>
    [DataMember, JsonProperty("통화코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>외화예수금</summary>
    [DataMember, JsonProperty("외화예수금")]
    public string? ForeignCurrencyDeposits
    {
        get; set;
    }
    /// <summary>원화대용평가금</summary>
    [DataMember, JsonProperty("원화대용평가금")]
    public string? AppreciationOfWon
    {
        get; set;
    }
    /// <summary>해외주식증거금</summary>
    [DataMember, JsonProperty("해외주식증거금")]
    public string? ForeignStockDeposits
    {
        get; set;
    }
    /// <summary>출금가능금액(예수금)</summary>
    [DataMember, JsonProperty("출금가능금액(예수금)")]
    public string? AmountAvailableForWithdrawal
    {
        get; set;
    }
    /// <summary>주문가능금액(예수금)</summary>
    [DataMember, JsonProperty("주문가능금액(예수금)")]
    public string? OrderableAmount
    {
        get; set;
    }
    /// <summary>외화미수(합계)</summary>
    [DataMember, JsonProperty("외화미수(합계)")]
    public string? AttemptedForeignCurrency
    {
        get; set;
    }
    /// <summary>외화현금미수금</summary>
    [DataMember, JsonProperty("외화현금미수금")]
    public string? ForeignCashReceivables
    {
        get; set;
    }
    /// <summary>연체료</summary>
    [DataMember, JsonProperty("연체료")]
    public string? LateFee
    {
        get; set;
    }
    /// <summary>d+1외화예수금</summary>
    [DataMember, JsonProperty("d+1외화예수금")]
    public string? D1ForeignCurrencyDeposits
    {
        get; set;
    }
    /// <summary>d+2외화예수금</summary>
    [DataMember, JsonProperty("d+2외화예수금")]
    public string? D2ForeignCurrencyDeposits
    {
        get; set;
    }
    /// <summary>d+3외화예수금</summary>
    [DataMember, JsonProperty("d+3외화예수금")]
    public string? D3ForeignCurrencyDeposits
    {
        get; set;
    }
    /// <summary>d+4외화예수금</summary>
    [DataMember, JsonProperty("d+4외화예수금")]
    public string? D4ForeignCurrencyDeposits
    {
        get; set;
    }
}