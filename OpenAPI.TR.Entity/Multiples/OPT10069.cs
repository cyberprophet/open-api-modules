using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>대차거래상위10종목</summary>
public class MultiOPT10069
{
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
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