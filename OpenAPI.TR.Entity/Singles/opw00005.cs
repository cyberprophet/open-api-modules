using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>체결잔고</summary>
public class SingleOpw00005
{
    /// <summary>예수금</summary>
    [StringLength(0x10), DataMember, JsonProperty("예수금")]
    public virtual string? Deposit
    {
        get; set;
    }
    /// <summary>예수금D+1</summary>
    [StringLength(0x10), DataMember, JsonProperty("예수금D+1")]
    public virtual string? PreDeposit
    {
        get; set;
    }
    /// <summary>예수금D+2</summary>
    [StringLength(0x10), DataMember, JsonProperty("예수금D+2")]
    public virtual string? PresumeDeposit
    {
        get; set;
    }
    /// <summary>출금가능금액</summary>
    [StringLength(0x10), DataMember, JsonProperty("출금가능금액")]
    public virtual string? WithDrawableAmount
    {
        get; set;
    }
    /// <summary>미수확보금</summary>
    [StringLength(0x10), DataMember, JsonProperty("미수확보금")]
    public virtual string? UncollectedSecurity
    {
        get; set;
    }
    /// <summary>대용금</summary>
    [StringLength(0x10), DataMember, JsonProperty("대용금")]
    public virtual string? Loan
    {
        get; set;
    }
    /// <summary>권리대용금</summary>
    [StringLength(0x10), DataMember, JsonProperty("권리대용금")]
    public virtual string? LoanForRights
    {
        get; set;
    }
    /// <summary>주문가능현금</summary>
    [StringLength(0x10), DataMember, JsonProperty("주문가능현금")]
    public virtual string? OrderableCash
    {
        get; set;
    }
    /// <summary>현금미수금</summary>
    [StringLength(0x10), DataMember, JsonProperty("현금미수금")]
    public virtual string? CashReceivables
    {
        get; set;
    }
    /// <summary>신용이자미납금</summary>
    [StringLength(0x10), DataMember, JsonProperty("신용이자미납금")]
    public virtual string? UnpaidInterestOnCredit
    {
        get; set;
    }
    /// <summary>기타대여금</summary>
    [StringLength(0x10), DataMember, JsonProperty("기타대여금")]
    public virtual string? OtherLoans
    {
        get; set;
    }
    /// <summary>미상환융자금</summary>
    [StringLength(0x10), DataMember, JsonProperty("미상환융자금")]
    public virtual string? OutstandingLoan
    {
        get; set;
    }
    /// <summary>증거금현금</summary>
    [StringLength(0x10), DataMember, JsonProperty("증거금현금")]
    public virtual string? CashOnDeposit
    {
        get; set;
    }
    /// <summary>증거금대용</summary>
    [StringLength(0x10), DataMember, JsonProperty("증거금대용")]
    public virtual string? DepositSubstitute
    {
        get; set;
    }
    /// <summary>주식매수총액</summary>
    [StringLength(0x10), DataMember, JsonProperty("주식매수총액")]
    public virtual string? TotalStockPurchases
    {
        get; set;
    }
    /// <summary>평가금액합계</summary>
    [StringLength(0x10), DataMember, JsonProperty("평가금액합계")]
    public virtual string? EvaluationAmount
    {
        get; set;
    }
    /// <summary>총손익합계</summary>
    [StringLength(0x10), DataMember, JsonProperty("총손익합계")]
    public virtual string? TotalProfitAndLoss
    {
        get; set;
    }
    /// <summary>총손익률</summary>
    [StringLength(0x10), DataMember, JsonProperty("총손익률")]
    public virtual string? GrossProfitAndLossRatio
    {
        get; set;
    }
    /// <summary>총재매수가능금액</summary>
    [StringLength(0x10), DataMember, JsonProperty("총재매수가능금액")]
    public virtual string? TotalAvailablePurchaseAmount
    {
        get; set;
    }
    /// <summary>20주문가능금액</summary>
    [StringLength(0x10), DataMember, JsonProperty("20주문가능금액")]
    public virtual string? OneFifthAvailablePurchaseAmount
    {
        get; set;
    }
    /// <summary>30주문가능금액</summary>
    [StringLength(0x10), DataMember, JsonProperty("30주문가능금액")]
    public virtual string? OneThirdAvailablePurchaseAmount
    {
        get; set;
    }
    /// <summary>40주문가능금액</summary>
    [StringLength(0x10), DataMember, JsonProperty("40주문가능금액")]
    public virtual string? TwoFifthsAvailablePurchaseAmount
    {
        get; set;
    }
    /// <summary>50주문가능금액</summary>
    [StringLength(0x10), DataMember, JsonProperty("50주문가능금액")]
    public virtual string? HalfAvailablePurchaseAmount
    {
        get; set;
    }
    /// <summary>60주문가능금액</summary>
    [StringLength(0x10), DataMember, JsonProperty("60주문가능금액")]
    public virtual string? TwoThirdsAvailablePurchaseAmount
    {
        get; set;
    }
    /// <summary>100주문가능금액</summary>
    [StringLength(0x10), DataMember, JsonProperty("100주문가능금액")]
    public virtual string? FullAvailablePurchaseAmount
    {
        get; set;
    }
    /// <summary>신용융자합계</summary>
    [StringLength(0x10), DataMember, JsonProperty("신용융자합계")]
    public virtual string? TotalCreditLoans
    {
        get; set;
    }
    /// <summary>신용융자대주합계</summary>
    [StringLength(0x10), DataMember, JsonProperty("신용융자대주합계")]
    public virtual string? CreditLoan
    {
        get; set;
    }
    /// <summary>신용담보비율</summary>
    [StringLength(0x10), DataMember, JsonProperty("신용담보비율")]
    public virtual string? CreditSecurityRatio
    {
        get; set;
    }
    /// <summary>예탁담보대출금액</summary>
    [StringLength(0x10), DataMember, JsonProperty("예탁담보대출금액")]
    public virtual string? DepositedMortgageAmount
    {
        get; set;
    }
    /// <summary>매도담보대출금액</summary>
    [StringLength(0x10), DataMember, JsonProperty("매도담보대출금액")]
    public virtual string? MortgageSoldAmount
    {
        get; set;
    }
    /// <summary>조회건수</summary>
    [StringLength(0x4), DataMember, JsonProperty("조회건수")]
    public virtual string? NumberOfViews
    {
        get; set;
    }
}