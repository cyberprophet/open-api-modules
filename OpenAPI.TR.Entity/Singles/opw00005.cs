using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>체결잔고</summary>
public class SingleOpw00005
{
    /// <summary>예수금</summary>
    [DataMember, JsonProperty("예수금")]
    public string? Deposit
    {
        get; set;
    }
    /// <summary>예수금D+1</summary>
    [DataMember, JsonProperty("예수금D+1")]
    public string? DepositD1
    {
        get; set;
    }
    /// <summary>예수금D+2</summary>
    [DataMember, JsonProperty("예수금D+2")]
    public string? DepositD2
    {
        get; set;
    }
    /// <summary>출금가능금액</summary>
    [DataMember, JsonProperty("출금가능금액")]
    public string? AmountAvailableForWithdrawable
    {
        get; set;
    }
    /// <summary>미수확보금</summary>
    [DataMember, JsonProperty("미수확보금")]
    public string? OutstandingAmountOfMoney
    {
        get; set;
    }
    /// <summary>대용금</summary>
    [DataMember, JsonProperty("대용금")]
    public string? SubstituteMoney
    {
        get; set;
    }
    /// <summary>권리대용금</summary>
    [DataMember, JsonProperty("권리대용금")]
    public string? RightForRightsCharge
    {
        get; set;
    }
    /// <summary>주문가능현금</summary>
    [DataMember, JsonProperty("주문가능현금")]
    public string? CashAvailableForOrderable
    {
        get; set;
    }
    /// <summary>현금미수금</summary>
    [DataMember, JsonProperty("현금미수금")]
    public string? CashReceivables
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
    /// <summary>미상환융자금</summary>
    [DataMember, JsonProperty("미상환융자금")]
    public string? OutstandingLoan
    {
        get; set;
    }
    /// <summary>증거금현금</summary>
    [DataMember, JsonProperty("증거금현금")]
    public string? CashOnDeposit
    {
        get; set;
    }
    /// <summary>증거금대용</summary>
    [DataMember, JsonProperty("증거금대용")]
    public string? CostOfEvidence
    {
        get; set;
    }
    /// <summary>주식매수총액</summary>
    [DataMember, JsonProperty("주식매수총액")]
    public string? TotalStockPurchase
    {
        get; set;
    }
    /// <summary>평가금액합계</summary>
    [DataMember, JsonProperty("평가금액합계")]
    public string? TotalValuationAmount
    {
        get; set;
    }
    /// <summary>총손익합계</summary>
    [DataMember, JsonProperty("총손익합계")]
    public string? TotalProfitAndLoss
    {
        get; set;
    }
    /// <summary>총손익률</summary>
    [DataMember, JsonProperty("총손익률")]
    public string? GrossProfitAndLossRatio
    {
        get; set;
    }
    /// <summary>총재매수가능금액</summary>
    [DataMember, JsonProperty("총재매수가능금액")]
    public string? AmountAvailableToPurchaseByTheGovernor
    {
        get; set;
    }
    /// <summary>20주문가능금액</summary>
    [DataMember, JsonProperty("20주문가능금액")]
    public string? AmountAvailableToOrderableFor20
    {
        get; set;
    }
    /// <summary>30주문가능금액</summary>
    [DataMember, JsonProperty("30주문가능금액")]
    public string? AmountAvailableToOrderFor30
    {
        get; set;
    }
    /// <summary>40주문가능금액</summary>
    [DataMember, JsonProperty("40주문가능금액")]
    public string? AmountAvailableForOrderFor40
    {
        get; set;
    }
    /// <summary>50주문가능금액</summary>
    [DataMember, JsonProperty("50주문가능금액")]
    public string? AvailableFor50OrderableAmount
    {
        get; set;
    }
    /// <summary>60주문가능금액</summary>
    [DataMember, JsonProperty("60주문가능금액")]
    public string? AvailableFor60OrderableAmount
    {
        get; set;
    }
    /// <summary>100주문가능금액</summary>
    [DataMember, JsonProperty("100주문가능금액")]
    public string? AvailableToOrderable100
    {
        get; set;
    }
    /// <summary>신용융자합계</summary>
    [DataMember, JsonProperty("신용융자합계")]
    public string? TotalCreditLoans
    {
        get; set;
    }
    /// <summary>신용융자대주합계</summary>
    [DataMember, JsonProperty("신용융자대주합계")]
    public string? CreditLoanLoanLoanTotal
    {
        get; set;
    }
    /// <summary>신용담보비율</summary>
    [DataMember, JsonProperty("신용담보비율")]
    public string? CreditBackedRatio
    {
        get; set;
    }
    /// <summary>예탁담보대출금액</summary>
    [DataMember, JsonProperty("예탁담보대출금액")]
    public string? DepositSecuredLoanAmount
    {
        get; set;
    }
    /// <summary>매도담보대출금액</summary>
    [DataMember, JsonProperty("매도담보대출금액")]
    public string? AmountOfCollateralizedLoanForSale
    {
        get; set;
    }
    /// <summary>조회건수</summary>
    [DataMember, JsonProperty("조회건수")]
    public string? NumberOfInquiries
    {
        get; set;
    }
}