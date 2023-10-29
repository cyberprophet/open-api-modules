using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>대차거래추이</summary>
public class MultiOpt20068
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>대차거래체결주수</summary>
    [DataMember, JsonProperty("대차거래체결주수")]
    public string? LoanTransactionClosingWeeks
    {
        get; set;
    }
    /// <summary>대차거래상환주수</summary>
    [DataMember, JsonProperty("대차거래상환주수")]
    public string? LoanTransactionRepaymentWeeks
    {
        get; set;
    }
    /// <summary>대차거래증감</summary>
    [DataMember, JsonProperty("대차거래증감")]
    public string? IncreaseOrDecreaseInLoanTransactions
    {
        get; set;
    }
    /// <summary>잔고주수</summary>
    [DataMember, JsonProperty("잔고주수")]
    public string? BalanceOfWeeks
    {
        get; set;
    }
    /// <summary>잔고금액</summary>
    [DataMember, JsonProperty("잔고금액")]
    public string? BalanceAmount
    {
        get; set;
    }
}