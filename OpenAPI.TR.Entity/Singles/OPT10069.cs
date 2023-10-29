using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>대차거래상위10종목합계</summary>
public class SingleOPT10069
{
    /// <summary>대차거래체결주수합</summary>
    [DataMember, JsonProperty("대차거래체결주수합")]
    public string? LoanTransactionSettlementNumber
    {
        get; set;
    }
    /// <summary>대차거래상환주수합</summary>
    [DataMember, JsonProperty("대차거래상환주수합")]
    public string? LoanTransactionConversionSum
    {
        get; set;
    }
    /// <summary>잔고주수합</summary>
    [DataMember, JsonProperty("잔고주수합")]
    public string? BalanceSheetSum
    {
        get; set;
    }
    /// <summary>잔고금액합</summary>
    [DataMember, JsonProperty("잔고금액합")]
    public string? BalanceAmountSum
    {
        get; set;
    }
    /// <summary>대차거래체결주수비율</summary>
    [DataMember, JsonProperty("대차거래체결주수비율")]
    public string? LoanTransactionClosingWeekRatio
    {
        get; set;
    }
    /// <summary>대차거래상환주수비율</summary>
    [DataMember, JsonProperty("대차거래상환주수비율")]
    public string? LoanTransactionRepaymentStockRatio
    {
        get; set;
    }
    /// <summary>잔고주수비율</summary>
    [DataMember, JsonProperty("잔고주수비율")]
    public string? BalanceOfWeeksRatio
    {
        get; set;
    }
    /// <summary>잔고금액비율</summary>
    [DataMember, JsonProperty("잔고금액비율")]
    public string? RatioOfBalanceAmount
    {
        get; set;
    }
}