using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵증거금상세내역</summary>
public class SingleOpw20012
{
    /// <summary>예탁총액</summary>
    [DataMember, JsonProperty("예탁총액")]
    public string? TotalDeposit
    {
        get; set;
    }
    /// <summary>예탁현금</summary>
    [DataMember, JsonProperty("예탁현금")]
    public string? DepositCash
    {
        get; set;
    }
    /// <summary>예탁대용</summary>
    [DataMember, JsonProperty("예탁대용")]
    public string? DepositReplacement
    {
        get; set;
    }
    /// <summary>위탁증거금총액</summary>
    [DataMember, JsonProperty("위탁증거금총액")]
    public string? TotalAmountOfEntrustedDeposits
    {
        get; set;
    }
    /// <summary>위탁현금증거금</summary>
    [DataMember, JsonProperty("위탁현금증거금")]
    public string? ConsignmentCashMargin
    {
        get; set;
    }
    /// <summary>유지증거금총액</summary>
    [DataMember, JsonProperty("유지증거금총액")]
    public string? TotalAmountOfMaintenanceDeposits
    {
        get; set;
    }
    /// <summary>추가증거금총액</summary>
    [DataMember, JsonProperty("추가증거금총액")]
    public string? TotalAmountOfAdditionalDeposits
    {
        get; set;
    }
    /// <summary>추가증거금현금</summary>
    [DataMember, JsonProperty("추가증거금현금")]
    public string? AdditionalMarginCash
    {
        get; set;
    }
    /// <summary>신규위탁증거금총액</summary>
    [DataMember, JsonProperty("신규위탁증거금총액")]
    public string? TotalAmountOfNewConsignmentDeposits
    {
        get; set;
    }
    /// <summary>선물신규주문증거금총액</summary>
    [DataMember, JsonProperty("선물신규주문증거금총액")]
    public string? TotalMarginForNewFuturesOrders
    {
        get; set;
    }
    /// <summary>신규스프레드증거금</summary>
    [DataMember, JsonProperty("신규스프레드증거금")]
    public string? NewSpreadMargin
    {
        get; set;
    }
    /// <summary>옵션신규매수주문</summary>
    [DataMember, JsonProperty("옵션신규매수주문")]
    public string? NewOptionPurchaseOrder
    {
        get; set;
    }
    /// <summary>옵션신규매도주문</summary>
    [DataMember, JsonProperty("옵션신규매도주문")]
    public string? NewOptionSaleOrder
    {
        get; set;
    }
    /// <summary>위험위탁증거금</summary>
    [DataMember, JsonProperty("위험위탁증거금")]
    public string? RiskConsignmentMargin
    {
        get; set;
    }
    /// <summary>옵션가격증거금</summary>
    [DataMember, JsonProperty("옵션가격증거금")]
    public string? OptionPriceMargin
    {
        get; set;
    }
    /// <summary>가격변동증거금</summary>
    [DataMember, JsonProperty("가격변동증거금")]
    public string? PriceFluctuationMargin
    {
        get; set;
    }
    /// <summary>선물스프레드증거금</summary>
    [DataMember, JsonProperty("선물스프레드증거금")]
    public string? FuturesSpreadMargin
    {
        get; set;
    }
    /// <summary>인수도증거금</summary>
    [DataMember, JsonProperty("인수도증거금")]
    public string? UnderwritingMargin
    {
        get; set;
    }
    /// <summary>최소증거금</summary>
    [DataMember, JsonProperty("최소증거금")]
    public string? MinimumMargin
    {
        get; set;
    }
    /// <summary>당일옵션순매수대금</summary>
    [DataMember, JsonProperty("당일옵션순매수대금")]
    public string? NetPurchasePriceOfOptionsOnTheSameDay
    {
        get; set;
    }
    /// <summary>옵션매수대금</summary>
    [DataMember, JsonProperty("옵션매수대금")]
    public string? OptionPurchasePrice
    {
        get; set;
    }
    /// <summary>선물체결순손익</summary>
    [DataMember, JsonProperty("선물체결순손익")]
    public string? NetGainOrLossOnFuturesConclusion
    {
        get; set;
    }
    /// <summary>선물정산차금</summary>
    [DataMember, JsonProperty("선물정산차금")]
    public string? ForwardSettlementDifference
    {
        get; set;
    }
    /// <summary>옵션매도결제대금</summary>
    [DataMember, JsonProperty("옵션매도결제대금")]
    public string? OptionSellingPrice
    {
        get; set;
    }
    /// <summary>옵션매수결제대금</summary>
    [DataMember, JsonProperty("옵션매수결제대금")]
    public string? OptionPurchasePayment
    {
        get; set;
    }
    /// <summary>수수료합계</summary>
    [DataMember, JsonProperty("수수료합계")]
    public string? TotalCommission
    {
        get; set;
    }
    /// <summary>선물최종결제차금</summary>
    [DataMember, JsonProperty("선물최종결제차금")]
    public string? FinalPaymentDifferenceForFutures
    {
        get; set;
    }
    /// <summary>인수도대금</summary>
    [DataMember, JsonProperty("인수도대금")]
    public string? UnderwritingPrice
    {
        get; set;
    }
    /// <summary>옵션행사대금</summary>
    [DataMember, JsonProperty("옵션행사대금")]
    public string? OptionExercisePrice
    {
        get; set;
    }
    /// <summary>옵션배정대금</summary>
    [DataMember, JsonProperty("옵션배정대금")]
    public string? OptionAllocationPrice
    {
        get; set;
    }
    /// <summary>주문가능총액</summary>
    [DataMember, JsonProperty("주문가능총액")]
    public string? TotalOrderableAmount
    {
        get; set;
    }
    /// <summary>주문가능현금</summary>
    [DataMember, JsonProperty("주문가능현금")]
    public string? CashAvailableForOrderable
    {
        get; set;
    }
    /// <summary>인출가능총액</summary>
    [DataMember, JsonProperty("인출가능총액")]
    public string? TotalWithdrawableAmount
    {
        get; set;
    }
    /// <summary>인출가능현금</summary>
    [DataMember, JsonProperty("인출가능현금")]
    public string? WithdrawableCash
    {
        get; set;
    }
    /// <summary>계좌명</summary>
    [DataMember, JsonProperty("계좌명")]
    public string? AccountName
    {
        get; set;
    }
    /// <summary>계좌번호</summary>
    [DataMember, JsonProperty("계좌번호")]
    public string? AccountNumber
    {
        get; set;
    }
    /// <summary>조회일자</summary>
    [DataMember, JsonProperty("조회일자")]
    public string? InquiryDate
    {
        get; set;
    }
    /// <summary>예탁평가총액</summary>
    [DataMember, JsonProperty("예탁평가총액")]
    public string? TotalDepositEvaluation
    {
        get; set;
    }
    /// <summary>익일예탁총액</summary>
    [DataMember, JsonProperty("익일예탁총액")]
    public string? TotalDepositForTheNextDay
    {
        get; set;
    }
    /// <summary>전일대용매도금</summary>
    [DataMember, JsonProperty("전일대용매도금")]
    public string? ThePreviousDaySale
    {
        get; set;
    }
    /// <summary>금일대용매도금액</summary>
    [DataMember, JsonProperty("금일대용매도금액")]
    public string? SaleAmountForToday
    {
        get; set;
    }
    /// <summary>미수연체료</summary>
    [DataMember, JsonProperty("미수연체료")]
    public string? UnpaidOverdueFees
    {
        get; set;
    }
    /// <summary>전일장종료예탁총액</summary>
    [DataMember, JsonProperty("전일장종료예탁총액")]
    public string? TotalDepositAtTheEndOfThePreviousSession
    {
        get; set;
    }
    /// <summary>전일장종료예탁현금</summary>
    [DataMember, JsonProperty("전일장종료예탁현금")]
    public string? FullTimeEndDepositCash
    {
        get; set;
    }
    /// <summary>장중인출가능금액변경여부</summary>
    [DataMember, JsonProperty("장중인출가능금액변경여부")]
    public string? WhetherTheWithdrawableAmountDuringTheDayIsChangedOrNot
    {
        get; set;
    }
}