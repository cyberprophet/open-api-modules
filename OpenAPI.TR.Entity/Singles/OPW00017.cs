using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌별당일현황</summary>
public class SingleOPW00017
{
    /// <summary>D+2추정예수금</summary>
    [DataMember, JsonProperty("D+2추정예수금")]
    public string? D2EstimateDeposit
    {
        get; set;
    }
    /// <summary>신용이자미납금</summary>
    [DataMember, JsonProperty("신용이자미납금")]
    public string? OutstandingCreditInterestPayments
    {
        get; set;
    }
    /// <summary>기타대여금</summary>
    [DataMember, JsonProperty("기타대여금")]
    public string? OtherLoans
    {
        get; set;
    }
    /// <summary>일반주식평가금액D+2</summary>
    [DataMember, JsonProperty("일반주식평가금액D+2")]
    public string? GeneralStockValuationAmountD2
    {
        get; set;
    }
    /// <summary>예탁담보대출금D+2</summary>
    [DataMember, JsonProperty("예탁담보대출금D+2")]
    public string? DepositedMortgageLoanD2
    {
        get; set;
    }
    /// <summary>예탁담보주식평가금액D+2</summary>
    [DataMember, JsonProperty("예탁담보주식평가금액D+2")]
    public string? DepositedSecuredStockValuationAmountD2
    {
        get; set;
    }
    /// <summary>신용융자금D+2</summary>
    [DataMember, JsonProperty("신용융자금D+2")]
    public string? CreditLoanD2
    {
        get; set;
    }
    /// <summary>신용융자평가금D+2</summary>
    [DataMember, JsonProperty("신용융자평가금D+2")]
    public string? CreditSelfEvaluationD2
    {
        get; set;
    }
    /// <summary>신용대주담보금D+2</summary>
    [DataMember, JsonProperty("신용대주담보금D+2")]
    public string? CreditLoanSecurityD2
    {
        get; set;
    }
    /// <summary>신용대주평가금D+2</summary>
    [DataMember, JsonProperty("신용대주평가금D+2")]
    public string? CreditLoanValuationD2
    {
        get; set;
    }
    /// <summary>입금금액</summary>
    [DataMember, JsonProperty("입금금액")]
    public string? DepositAmount
    {
        get; set;
    }
    /// <summary>출금금액</summary>
    [DataMember, JsonProperty("출금금액")]
    public string? WithdrawalAmount
    {
        get; set;
    }
    /// <summary>입고금액</summary>
    [DataMember, JsonProperty("입고금액")]
    public string? ReceivingAmount
    {
        get; set;
    }
    /// <summary>출고금액</summary>
    [DataMember, JsonProperty("출고금액")]
    public string? ForwardingAmount
    {
        get; set;
    }
    /// <summary>매도금액</summary>
    [DataMember, JsonProperty("매도금액")]
    public string? SellingAmount
    {
        get; set;
    }
    /// <summary>매수금액</summary>
    [DataMember, JsonProperty("매수금액")]
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
    /// <summary>세금</summary>
    [DataMember, JsonProperty("세금")]
    public string? Tax
    {
        get; set;
    }
    /// <summary>주식매입자금대출금</summary>
    [DataMember, JsonProperty("주식매입자금대출금")]
    public string? LoanForAStockLoan
    {
        get; set;
    }
    /// <summary>RP평가금액</summary>
    [DataMember, JsonProperty("RP평가금액")]
    public string? RPEvaluationAmount
    {
        get; set;
    }
    /// <summary>채권평가금액</summary>
    [DataMember, JsonProperty("채권평가금액")]
    public string? AmountOfBondValuation
    {
        get; set;
    }
    /// <summary>ELS평가금액</summary>
    [DataMember, JsonProperty("ELS평가금액")]
    public string? ELSValuationAmount
    {
        get; set;
    }
    /// <summary>신용이자금액</summary>
    [DataMember, JsonProperty("신용이자금액")]
    public string? CreditInterestAmount
    {
        get; set;
    }
    /// <summary>매도대금담보대출이자금액</summary>
    [DataMember, JsonProperty("매도대금담보대출이자금액")]
    public string? InterestOnTheLoanSecuredBySellingPrice
    {
        get; set;
    }
    /// <summary>배당금액</summary>
    [DataMember, JsonProperty("배당금액")]
    public string? DividendAmount
    {
        get; set;
    }
}