using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>증거금세부내역조회</summary>
public class SingleOpw00013
{
    /// <summary>금일재사용대상금액</summary>
    [DataMember, JsonProperty("금일재사용대상금액")]
    public string? AmountSubjectToReuseToday
    {
        get; set;
    }
    /// <summary>금일재사용사용금액</summary>
    [DataMember, JsonProperty("금일재사용사용금액")]
    public string? AmountOfReuseToday
    {
        get; set;
    }
    /// <summary>금일재사용가능금액</summary>
    [DataMember, JsonProperty("금일재사용가능금액")]
    public string? AmountAvailableForReuseToday
    {
        get; set;
    }
    /// <summary>금일재사용제한금액</summary>
    [DataMember, JsonProperty("금일재사용제한금액")]
    public string? RestrictedAmountForReuseToday
    {
        get; set;
    }
    /// <summary>금일재사용가능금액최종</summary>
    [DataMember, JsonProperty("금일재사용가능금액최종")]
    public string? FinalAmountAvailableForReuseToday
    {
        get; set;
    }
    /// <summary>전일재사용대상금액</summary>
    [DataMember, JsonProperty("전일재사용대상금액")]
    public string? AmountSubjectToReUseThePreviousDay
    {
        get; set;
    }
    /// <summary>전일재사용사용금액</summary>
    [DataMember, JsonProperty("전일재사용사용금액")]
    public string? AmountOfReUseUsedForThePreviousDay
    {
        get; set;
    }
    /// <summary>전일재사용가능금액</summary>
    [DataMember, JsonProperty("전일재사용가능금액")]
    public string? AmountAvailableForReUseThePreviousDay
    {
        get; set;
    }
    /// <summary>전일재사용제한금액</summary>
    [DataMember, JsonProperty("전일재사용제한금액")]
    public string? RestrictedAmountForReUseOfThePreviousDay
    {
        get; set;
    }
    /// <summary>전일재사용가능금액최종</summary>
    [DataMember, JsonProperty("전일재사용가능금액최종")]
    public string? LastAvailableAmountForReUseOnThePreviousDay
    {
        get; set;
    }
    /// <summary>현금금액</summary>
    [DataMember, JsonProperty("현금금액")]
    public string? CashAmount
    {
        get; set;
    }
    /// <summary>현금증거금</summary>
    [DataMember, JsonProperty("현금증거금")]
    public string? CashDeposit
    {
        get; set;
    }
    /// <summary>사용가능현금</summary>
    [DataMember, JsonProperty("사용가능현금")]
    public string? AvailableCash
    {
        get; set;
    }
    /// <summary>현금사용제한금액</summary>
    [DataMember, JsonProperty("현금사용제한금액")]
    public string? RestrictedAmountOfCashUse
    {
        get; set;
    }
    /// <summary>사용가능현금최종</summary>
    [DataMember, JsonProperty("사용가능현금최종")]
    public string? AvailableCashFinal
    {
        get; set;
    }
    /// <summary>대용금액</summary>
    [DataMember, JsonProperty("대용금액")]
    public string? SubstituteAmount
    {
        get; set;
    }
    /// <summary>대용증거금</summary>
    [DataMember, JsonProperty("대용증거금")]
    public string? ProxyDeposit
    {
        get; set;
    }
    /// <summary>사용가능대용</summary>
    [DataMember, JsonProperty("사용가능대용")]
    public string? AvailableForUse
    {
        get; set;
    }
    /// <summary>대용사용제한금액</summary>
    [DataMember, JsonProperty("대용사용제한금액")]
    public string? RestrictedAmountOfSubstituteUse
    {
        get; set;
    }
    /// <summary>사용가능대용최종</summary>
    [DataMember, JsonProperty("사용가능대용최종")]
    public string? AvailableReplacementFinal
    {
        get; set;
    }
    /// <summary>신용보증금현금</summary>
    [DataMember, JsonProperty("신용보증금현금")]
    public string? CreditDepositCash
    {
        get; set;
    }
    /// <summary>신용보증금대용</summary>
    [DataMember, JsonProperty("신용보증금대용")]
    public string? CreditDepositReplacement
    {
        get; set;
    }
    /// <summary>신용담보금현금</summary>
    [DataMember, JsonProperty("신용담보금현금")]
    public string? CashOnCreditSecurity
    {
        get; set;
    }
    /// <summary>신용담보금대용</summary>
    [DataMember, JsonProperty("신용담보금대용")]
    public string? CreditCollateral
    {
        get; set;
    }
    /// <summary>미수금</summary>
    [DataMember, JsonProperty("미수금")]
    public string? Outstanding
    {
        get; set;
    }
    /// <summary>대주담보금재사용금</summary>
    [DataMember, JsonProperty("대주담보금재사용금")]
    public string? RecurringLoanSecurity
    {
        get; set;
    }
    /// <summary>20주문가능금액</summary>
    [DataMember, JsonProperty("20주문가능금액")]
    public string? AvailableToOrderable20Amount
    {
        get; set;
    }
    /// <summary>30주문가능금액</summary>
    [DataMember, JsonProperty("30주문가능금액")]
    public string? AvailableToOrder30Amount
    {
        get; set;
    }
    /// <summary>40주문가능금액</summary>
    [DataMember, JsonProperty("40주문가능금액")]
    public string? AvailableForOrder40Amount
    {
        get; set;
    }
    /// <summary>50주문가능금액</summary>
    [DataMember, JsonProperty("50주문가능금액")]
    public string? AvailableForOrderable50Amount
    {
        get; set;
    }
    /// <summary>60주문가능금액</summary>
    [DataMember, JsonProperty("60주문가능금액")]
    public string? AvailableForOrder60Amount
    {
        get; set;
    }
    /// <summary>100주문가능금액</summary>
    [DataMember, JsonProperty("100주문가능금액")]
    public string? AvailableToOrder100Amount
    {
        get; set;
    }
    /// <summary>금일신용상환손실금액</summary>
    [DataMember, JsonProperty("금일신용상환손실금액")]
    public string? CreditRepaymentLossAmountToday
    {
        get; set;
    }
    /// <summary>전일신용상환손실금액</summary>
    [DataMember, JsonProperty("전일신용상환손실금액")]
    public string? DailyCreditRepaymentLossAmount
    {
        get; set;
    }
    /// <summary>금일대주상환손실대용증거금</summary>
    [DataMember, JsonProperty("금일대주상환손실대용증거금")]
    public string? TodayDepositInLieuOfLossInRepaymentOfStock
    {
        get; set;
    }
    /// <summary>전일대주상환손실대용증거금</summary>
    [DataMember, JsonProperty("전일대주상환손실대용증거금")]
    public string? SecuritiesInLieuOfLossInRepaymentOfThePreviousDay
    {
        get; set;
    }
    /// <summary>평가대용금(현물사용제외)</summary>
    [DataMember, JsonProperty("평가대용금(현물사용제외)")]
    public string? EvaluationCharge
    {
        get; set;
    }
    /// <summary>평가대용비율</summary>
    [DataMember, JsonProperty("평가대용비율")]
    public string? EvaluationSubstitutionRatio
    {
        get; set;
    }
    /// <summary>신용대용증거금</summary>
    [DataMember, JsonProperty("신용대용증거금")]
    public string? CreditGuarantee
    {
        get; set;
    }
    /// <summary>현금주문대용증거금</summary>
    [DataMember, JsonProperty("현금주문대용증거금")]
    public string? CashOrderDeposit
    {
        get; set;
    }
    /// <summary>신용주문대용증거금</summary>
    [DataMember, JsonProperty("신용주문대용증거금")]
    public string? DepositForACreditOrder
    {
        get; set;
    }
    /// <summary>신용대용환산금</summary>
    [DataMember, JsonProperty("신용대용환산금")]
    public string? CreditConversion
    {
        get; set;
    }
    /// <summary>대용가능금액</summary>
    [DataMember, JsonProperty("대용가능금액")]
    public string? SubstituteableAmount
    {
        get; set;
    }
    /// <summary>대용가능금액2</summary>
    [DataMember, JsonProperty("대용가능금액2")]
    public string? SubstituteableAmount2
    {
        get; set;
    }
    /// <summary>현금대용부족금</summary>
    [DataMember, JsonProperty("현금대용부족금")]
    public string? CashShortage
    {
        get; set;
    }
    /// <summary>신용대용부족금</summary>
    [DataMember, JsonProperty("신용대용부족금")]
    public string? CreditShortage
    {
        get; set;
    }
    /// <summary>현금주문가능대용금</summary>
    [DataMember, JsonProperty("현금주문가능대용금")]
    public string? CashOrderableCharge
    {
        get; set;
    }
    /// <summary>신용주문가능대용금</summary>
    [DataMember, JsonProperty("신용주문가능대용금")]
    public string? CreditOrderableCharge
    {
        get; set;
    }
}