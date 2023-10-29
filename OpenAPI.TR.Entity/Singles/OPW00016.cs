using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일별계좌수익률상세현황</summary>
public class SingleOPW00016
{
    /// <summary>관리사원번호</summary>
    [DataMember, JsonProperty("관리사원번호")]
    public string? ManagementEmployeeNumber
    {
        get; set;
    }
    /// <summary>관리자명</summary>
    [DataMember, JsonProperty("관리자명")]
    public string? AdministratorName
    {
        get; set;
    }
    /// <summary>관리자지점</summary>
    [DataMember, JsonProperty("관리자지점")]
    public string? AdministratorBranch
    {
        get; set;
    }
    /// <summary>예수금_초</summary>
    [DataMember, JsonProperty("예수금_초")]
    public string? StartDeposit
    {
        get; set;
    }
    /// <summary>예수금_말</summary>
    [DataMember, JsonProperty("예수금_말")]
    public string? EndDeposit
    {
        get; set;
    }
    /// <summary>유가증권평가금액_초</summary>
    [DataMember, JsonProperty("유가증권평가금액_초")]
    public string? StartValuationAmountOfSecurities
    {
        get; set;
    }
    /// <summary>유가증권평가금액_말</summary>
    [DataMember, JsonProperty("유가증권평가금액_말")]
    public string? EndValuationAmountOfSecurities
    {
        get; set;
    }
    /// <summary>대주담보금_초</summary>
    [DataMember, JsonProperty("대주담보금_초")]
    public string? StartLoanSecurity
    {
        get; set;
    }
    /// <summary>대주담보금_말</summary>
    [DataMember, JsonProperty("대주담보금_말")]
    public string? EndLoanSecurity
    {
        get; set;
    }
    /// <summary>신용융자금_초</summary>
    [DataMember, JsonProperty("신용융자금_초")]
    public string? StartCreditLoan
    {
        get; set;
    }
    /// <summary>신용융자금_말</summary>
    [DataMember, JsonProperty("신용융자금_말")]
    public string? EndCreditLoan
    {
        get; set;
    }
    /// <summary>현금미수금_초</summary>
    [DataMember, JsonProperty("현금미수금_초")]
    public string? StartCashReceivables
    {
        get; set;
    }
    /// <summary>현금미수금_말</summary>
    [DataMember, JsonProperty("현금미수금_말")]
    public string? EndCashReceivables
    {
        get; set;
    }
    /// <summary>원화대용금_초</summary>
    [DataMember, JsonProperty("원화대용금_초")]
    public string? KRWStartCredit
    {
        get; set;
    }
    /// <summary>원화대용금_말</summary>
    [DataMember, JsonProperty("원화대용금_말")]
    public string? KRWEndLoan
    {
        get; set;
    }
    /// <summary>대주평가금_초</summary>
    [DataMember, JsonProperty("대주평가금_초")]
    public string? StartValuation
    {
        get; set;
    }
    /// <summary>대주평가금_말</summary>
    [DataMember, JsonProperty("대주평가금_말")]
    public string? EndValuation
    {
        get; set;
    }
    /// <summary>권리평가금_초</summary>
    [DataMember, JsonProperty("권리평가금_초")]
    public string? StartValuationOfRights
    {
        get; set;
    }
    /// <summary>권리평가금_말</summary>
    [DataMember, JsonProperty("권리평가금_말")]
    public string? EndValuationOfRights
    {
        get; set;
    }
    /// <summary>대출금_초</summary>
    [DataMember, JsonProperty("대출금_초")]
    public string? StartLoan
    {
        get; set;
    }
    /// <summary>대출금_말</summary>
    [DataMember, JsonProperty("대출금_말")]
    public string? EndLoan
    {
        get; set;
    }
    /// <summary>기타대여금_초</summary>
    [DataMember, JsonProperty("기타대여금_초")]
    public string? StartOtherLoans
    {
        get; set;
    }
    /// <summary>기타대여금_말</summary>
    [DataMember, JsonProperty("기타대여금_말")]
    public string? EndOtherLoan
    {
        get; set;
    }
    /// <summary>신용이자미납금_초</summary>
    [DataMember, JsonProperty("신용이자미납금_초")]
    public string? StartCreditInterestUnpaid
    {
        get; set;
    }
    /// <summary>신용이자미납금_말</summary>
    [DataMember, JsonProperty("신용이자미납금_말")]
    public string? EndCreditInterestUnpaid
    {
        get; set;
    }
    /// <summary>신용이자_초</summary>
    [DataMember, JsonProperty("신용이자_초")]
    public string? StartCreditInterest
    {
        get; set;
    }
    /// <summary>신용이자_말</summary>
    [DataMember, JsonProperty("신용이자_말")]
    public string? EndCreditInterest
    {
        get; set;
    }
    /// <summary>순자산액계_초</summary>
    [DataMember, JsonProperty("순자산액계_초")]
    public string? StartNetAssetTotal
    {
        get; set;
    }
    /// <summary>순자산액계_말</summary>
    [DataMember, JsonProperty("순자산액계_말")]
    public string? EndNetAssetTotal
    {
        get; set;
    }
    /// <summary>투자원금평잔</summary>
    [DataMember, JsonProperty("투자원금평잔")]
    public string? InvestmentPrincipalBalance
    {
        get; set;
    }
    /// <summary>평가손익</summary>
    [DataMember, JsonProperty("평가손익")]
    public string? ValuationGainsAndLosses
    {
        get; set;
    }
    /// <summary>수익률</summary>
    [DataMember, JsonProperty("수익률")]
    public string? YieldRateOfReturn
    {
        get; set;
    }
    /// <summary>회전율</summary>
    [DataMember, JsonProperty("회전율")]
    public string? TurnoverRateOfRotation
    {
        get; set;
    }
    /// <summary>기간내총입금</summary>
    [DataMember, JsonProperty("기간내총입금")]
    public string? TotalDepositsWithinThePeriod
    {
        get; set;
    }
    /// <summary>기간내총출금</summary>
    [DataMember, JsonProperty("기간내총출금")]
    public string? TotalWithdrawalWithinThePeriod
    {
        get; set;
    }
    /// <summary>기간내총입고</summary>
    [DataMember, JsonProperty("기간내총입고")]
    public string? TotalWarehousingWithinThePeriod
    {
        get; set;
    }
    /// <summary>기간내총출고</summary>
    [DataMember, JsonProperty("기간내총출고")]
    public string? TotalForwardingWithinThePeriod
    {
        get; set;
    }
    /// <summary>선물대용매도금액</summary>
    [DataMember, JsonProperty("선물대용매도금액")]
    public string? SellingAmountForFutures
    {
        get; set;
    }
    /// <summary>위탁대용매도금액</summary>
    [DataMember, JsonProperty("위탁대용매도금액")]
    public string? ConsignmentSellingAmount
    {
        get; set;
    }
}