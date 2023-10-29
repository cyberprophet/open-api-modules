using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>예수금상세현황</summary>
public class SingleOpw00001
{
    /// <summary>예수금</summary>
    [DataMember, JsonProperty("예수금")]
    public string? Deposit
    {
        get; set;
    }
    /// <summary>주식증거금현금</summary>
    [DataMember, JsonProperty("주식증거금현금")]
    public string? StockMarginCash
    {
        get; set;
    }
    /// <summary>수익증권증거금현금</summary>
    [DataMember, JsonProperty("수익증권증거금현금")]
    public string? CashOnSecuritiesOfProfits
    {
        get; set;
    }
    /// <summary>익일수익증권매도정산대금</summary>
    [DataMember, JsonProperty("익일수익증권매도정산대금")]
    public string? NextDayBeneficiarySecuritiesSaleSettlementAmount
    {
        get; set;
    }
    /// <summary>해외주식원화대용설정금</summary>
    [DataMember, JsonProperty("해외주식원화대용설정금")]
    public string? SettingMoneyForOverseasStockCurrency
    {
        get; set;
    }
    /// <summary>신용보증금현금</summary>
    [DataMember, JsonProperty("신용보증금현금")]
    public string? CreditDepositCash
    {
        get; set;
    }
    /// <summary>신용담보금현금</summary>
    [DataMember, JsonProperty("신용담보금현금")]
    public string? CashOnCreditSecurity
    {
        get; set;
    }
    /// <summary>추가담보금현금</summary>
    [DataMember, JsonProperty("추가담보금현금")]
    public string? AdditionalSecurityCash
    {
        get; set;
    }
    /// <summary>기타증거금</summary>
    [DataMember, JsonProperty("기타증거금")]
    public string? OtherDeposits
    {
        get; set;
    }
    /// <summary>미수확보금</summary>
    [DataMember, JsonProperty("미수확보금")]
    public string? OutstandingAmountOfMoney
    {
        get; set;
    }
    /// <summary>공매도대금</summary>
    [DataMember, JsonProperty("공매도대금")]
    public string? ShortSellingPrice
    {
        get; set;
    }
    /// <summary>신용설정평가금</summary>
    [DataMember, JsonProperty("신용설정평가금")]
    public string? CreditSettingAppraisal
    {
        get; set;
    }
    /// <summary>수표입금액</summary>
    [DataMember, JsonProperty("수표입금액")]
    public string? AmountOfCheck
    {
        get; set;
    }
    /// <summary>기타수표입금액</summary>
    [DataMember, JsonProperty("기타수표입금액")]
    public string? AmountOfOtherChecksDeposited
    {
        get; set;
    }
    /// <summary>신용담보재사용</summary>
    [DataMember, JsonProperty("신용담보재사용")]
    public string? ReuseOfCreditCollateral
    {
        get; set;
    }
    /// <summary>코넥스기본예탁금</summary>
    [DataMember, JsonProperty("코넥스기본예탁금")]
    public string? KONEXBasicDeposit
    {
        get; set;
    }
    /// <summary>ELW예탁평가금</summary>
    [DataMember, JsonProperty("ELW예탁평가금")]
    public string? ELWDepositValuation
    {
        get; set;
    }
    /// <summary>신용대주권리예정금액</summary>
    [DataMember, JsonProperty("신용대주권리예정금액")]
    public string? EstimatedAmountOfCreditLoanRight
    {
        get; set;
    }
    /// <summary>생계형가입금액</summary>
    [DataMember, JsonProperty("생계형가입금액")]
    public string? LivelihoodTypeSubscriptionAmount
    {
        get; set;
    }
    /// <summary>생계형입금가능금액</summary>
    [DataMember, JsonProperty("생계형입금가능금액")]
    public string? LivelihoodDepositableAmount
    {
        get; set;
    }
    /// <summary>대용금평가금액(합계)</summary>
    [DataMember, JsonProperty("대용금평가금액(합계)")]
    public string? SubstituteValuationAmount
    {
        get; set;
    }
    /// <summary>잔고대용평가금액</summary>
    [DataMember, JsonProperty("잔고대용평가금액")]
    public string? EvaluationAmountInPlaceOfBalance
    {
        get; set;
    }
    /// <summary>위탁대용잔고평가금액</summary>
    [DataMember, JsonProperty("위탁대용잔고평가금액")]
    public string? ConsignmentLoanBalanceEvaluationAmount
    {
        get; set;
    }
    /// <summary>수익증권대용평가금액</summary>
    [DataMember, JsonProperty("수익증권대용평가금액")]
    public string? ValuationAmountForBeneficiaryCertificates
    {
        get; set;
    }
    /// <summary>위탁증거금대용</summary>
    [DataMember, JsonProperty("위탁증거금대용")]
    public string? SubstitutingDepositForConsignment
    {
        get; set;
    }
    /// <summary>신용보증금대용</summary>
    [DataMember, JsonProperty("신용보증금대용")]
    public string? CreditDepositReplacement
    {
        get; set;
    }
    /// <summary>신용담보금대용</summary>
    [DataMember, JsonProperty("신용담보금대용")]
    public string? CreditCollateral
    {
        get; set;
    }
    /// <summary>추가담보금대용</summary>
    [DataMember, JsonProperty("추가담보금대용")]
    public string? ForAdditionalCollateral
    {
        get; set;
    }
    /// <summary>권리대용금</summary>
    [DataMember, JsonProperty("권리대용금")]
    public string? RightForRightsCharge
    {
        get; set;
    }
    /// <summary>출금가능금액</summary>
    [DataMember, JsonProperty("출금가능금액")]
    public string? AmountAvailableForWithdrawable
    {
        get; set;
    }
    /// <summary>랩출금가능금액</summary>
    [DataMember, JsonProperty("랩출금가능금액")]
    public string? LabWithdrawableAmount
    {
        get; set;
    }
    /// <summary>주문가능금액</summary>
    [DataMember, JsonProperty("주문가능금액")]
    public string? OrderableAmount
    {
        get; set;
    }
    /// <summary>수익증권매수가능금액</summary>
    [DataMember, JsonProperty("수익증권매수가능금액")]
    public string? AmountAvailableForPurchaseOfBeneficiaryCertificates
    {
        get; set;
    }
    /// <summary>20%종목주문가능금액</summary>
    [DataMember, JsonProperty("20%종목주문가능금액")]
    public string? OrderableAmountFor20
    {
        get; set;
    }
    /// <summary>30%종목주문가능금액</summary>
    [DataMember, JsonProperty("30%종목주문가능금액")]
    public string? OrderableAmountFor30
    {
        get; set;
    }
    /// <summary>40%종목주문가능금액</summary>
    [DataMember, JsonProperty("40%종목주문가능금액")]
    public string? OrderableAmountFor40
    {
        get; set;
    }
    /// <summary>100%종목주문가능금액</summary>
    [DataMember, JsonProperty("100%종목주문가능금액")]
    public string? OrderableAmountFor100
    {
        get; set;
    }
    /// <summary>현금미수금</summary>
    [DataMember, JsonProperty("현금미수금")]
    public string? CashReceivables
    {
        get; set;
    }
    /// <summary>현금미수연체료</summary>
    [DataMember, JsonProperty("현금미수연체료")]
    public string? NonPaymentOfCashArrears
    {
        get; set;
    }
    /// <summary>현금미수금합계</summary>
    [DataMember, JsonProperty("현금미수금합계")]
    public string? TotalCashReceivables
    {
        get; set;
    }
    /// <summary>신용이자미납</summary>
    [DataMember, JsonProperty("신용이자미납")]
    public string? NonPaymentOfCreditInterest
    {
        get; set;
    }
    /// <summary>신용이자미납연체료</summary>
    [DataMember, JsonProperty("신용이자미납연체료")]
    public string? LatePaymentOfCredit
    {
        get; set;
    }
    /// <summary>신용이자미납합계</summary>
    [DataMember, JsonProperty("신용이자미납합계")]
    public string? TotalOutstandingCreditInterest
    {
        get; set;
    }
    /// <summary>기타대여금</summary>
    [DataMember, JsonProperty("기타대여금")]
    public string? OtherLoans
    {
        get; set;
    }
    /// <summary>기타대여금연체료</summary>
    [DataMember, JsonProperty("기타대여금연체료")]
    public string? DelinquencyFeesForOtherLoans
    {
        get; set;
    }
    /// <summary>기타대여금합계</summary>
    [DataMember, JsonProperty("기타대여금합계")]
    public string? TotalOtherLoans
    {
        get; set;
    }
    /// <summary>미상환융자금</summary>
    [DataMember, JsonProperty("미상환융자금")]
    public string? OutstandingLoan
    {
        get; set;
    }
    /// <summary>융자금합계</summary>
    [DataMember, JsonProperty("융자금합계")]
    public string? TotalLoans
    {
        get; set;
    }
    /// <summary>대주금합계</summary>
    [DataMember, JsonProperty("대주금합계")]
    public string? TotalAmountOfStockLoan
    {
        get; set;
    }
    /// <summary>신용담보비율</summary>
    [DataMember, JsonProperty("신용담보비율")]
    public string? CreditBackedRatio
    {
        get; set;
    }
    /// <summary>중도이용료</summary>
    [DataMember, JsonProperty("중도이용료")]
    public string? IntermediateFee
    {
        get; set;
    }
    /// <summary>최소주문가능금액</summary>
    [DataMember, JsonProperty("최소주문가능금액")]
    public string? MinimumOrderableAmount
    {
        get; set;
    }
    /// <summary>대출총평가금액</summary>
    [DataMember, JsonProperty("대출총평가금액")]
    public string? TotalLoanValuation
    {
        get; set;
    }
    /// <summary>예탁담보대출잔고</summary>
    [DataMember, JsonProperty("예탁담보대출잔고")]
    public string? DepositedMortgageBalance
    {
        get; set;
    }
    /// <summary>매도담보대출잔고</summary>
    [DataMember, JsonProperty("매도담보대출잔고")]
    public string? LoanBalanceForSale
    {
        get; set;
    }
    /// <summary>d+1추정예수금</summary>
    [DataMember, JsonProperty("d+1추정예수금")]
    public string? D1EstimatedDeposit
    {
        get; set;
    }
    /// <summary>d+1매도매수정산금</summary>
    [DataMember, JsonProperty("d+1매도매수정산금")]
    public string? D1SettlementForSale
    {
        get; set;
    }
    /// <summary>d+1매수정산금</summary>
    [DataMember, JsonProperty("d+1매수정산금")]
    public string? D1PurchaseSettlementAmount
    {
        get; set;
    }
    /// <summary>d+1미수변제소요금</summary>
    [DataMember, JsonProperty("d+1미수변제소요금")]
    public string? D1AttemptedRepaymentCharge
    {
        get; set;
    }
    /// <summary>d+1매도정산금</summary>
    [DataMember, JsonProperty("d+1매도정산금")]
    public string? D1SalesSettlement
    {
        get; set;
    }
    /// <summary>d+1출금가능금액</summary>
    [DataMember, JsonProperty("d+1출금가능금액")]
    public string? D1WithdrawableAmount
    {
        get; set;
    }
    /// <summary>d+2추정예수금</summary>
    [DataMember, JsonProperty("d+2추정예수금")]
    public string? D2EstimateDeposit
    {
        get; set;
    }
    /// <summary>d+2매도매수정산금</summary>
    [DataMember, JsonProperty("d+2매도매수정산금")]
    public string? D2SaleSettlement
    {
        get; set;
    }
    /// <summary>d+2매수정산금</summary>
    [DataMember, JsonProperty("d+2매수정산금")]
    public string? D2PurchaseSettlementAmount
    {
        get; set;
    }
    /// <summary>d+2미수변제소요금</summary>
    [DataMember, JsonProperty("d+2미수변제소요금")]
    public string? D2AttemptedRepaymentCharges
    {
        get; set;
    }
    /// <summary>d+2매도정산금</summary>
    [DataMember, JsonProperty("d+2매도정산금")]
    public string? D2SalesSettlement
    {
        get; set;
    }
    /// <summary>d+2출금가능금액</summary>
    [DataMember, JsonProperty("d+2출금가능금액")]
    public string? D2WithdrawableAmount
    {
        get; set;
    }
    /// <summary>출력건수</summary>
    [DataMember, JsonProperty("출력건수")]
    public string? NumberOfOutputs
    {
        get; set;
    }
}