using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌별결제예상내역조회</summary>
public class SingleOPW20008
{
    /// <summary>계좌명</summary>
    [DataMember, JsonProperty("계좌명")]
    public string? AccountName
    {
        get; set;
    }
    /// <summary>예탁총액</summary>
    [DataMember, JsonProperty("예탁총액")]
    public string? TotalDeposit
    {
        get; set;
    }
    /// <summary>추정예탁총액</summary>
    [DataMember, JsonProperty("추정예탁총액")]
    public string? EstimatedDepositTotal
    {
        get; set;
    }
    /// <summary>예탁현금</summary>
    [DataMember, JsonProperty("예탁현금")]
    public string? DepositCash
    {
        get; set;
    }
    /// <summary>추정예탁현금</summary>
    [DataMember, JsonProperty("추정예탁현금")]
    public string? EstimatedDepositCash
    {
        get; set;
    }
    /// <summary>선물당일차금</summary>
    [DataMember, JsonProperty("선물당일차금")]
    public string? FirstDayOfThePresent
    {
        get; set;
    }
    /// <summary>선물갱신차금</summary>
    [DataMember, JsonProperty("선물갱신차금")]
    public string? FuturesRenewalCharge
    {
        get; set;
    }
    /// <summary>선물최종결제차금</summary>
    [DataMember, JsonProperty("선물최종결제차금")]
    public string? FinalPaymentDifferenceForFutures
    {
        get; set;
    }
    /// <summary>선물예상정산손익</summary>
    [DataMember, JsonProperty("선물예상정산손익")]
    public string? ExpectedGainOrLossOnFuturesSettlement
    {
        get; set;
    }
    /// <summary>옵션매수대금</summary>
    [DataMember, JsonProperty("옵션매수대금")]
    public string? OptionPurchasePrice
    {
        get; set;
    }
    /// <summary>옵션매도대금</summary>
    [DataMember, JsonProperty("옵션매도대금")]
    public string? OptionSellingPrice
    {
        get; set;
    }
    /// <summary>옵션행사차금</summary>
    [DataMember, JsonProperty("옵션행사차금")]
    public string? OptionEventDifference
    {
        get; set;
    }
    /// <summary>옵션배정차금</summary>
    [DataMember, JsonProperty("옵션배정차금")]
    public string? OptionAllocationDifference
    {
        get; set;
    }
    /// <summary>주식옵션행사대금</summary>
    [DataMember, JsonProperty("주식옵션행사대금")]
    public string? StockOptionExercisePrice
    {
        get; set;
    }
    /// <summary>주식옵션배정대금</summary>
    [DataMember, JsonProperty("주식옵션배정대금")]
    public string? StockOptionAllocationAmount
    {
        get; set;
    }
    /// <summary>인수도대금</summary>
    [DataMember, JsonProperty("인수도대금")]
    public string? UnderwritingPrice
    {
        get; set;
    }
    /// <summary>전일대용매도체결금액</summary>
    [DataMember, JsonProperty("전일대용매도체결금액")]
    public string? PreviousDaySalePrice
    {
        get; set;
    }
    /// <summary>금일대용매도체결금액</summary>
    [DataMember, JsonProperty("금일대용매도체결금액")]
    public string? TodaySellingPrice
    {
        get; set;
    }
    /// <summary>선물수수료</summary>
    [DataMember, JsonProperty("선물수수료")]
    public string? FuturesFee
    {
        get; set;
    }
    /// <summary>옵션수수료</summary>
    [DataMember, JsonProperty("옵션수수료")]
    public string? OptionFee
    {
        get; set;
    }
    /// <summary>결제가격수신여부</summary>
    [DataMember, JsonProperty("결제가격수신여부")]
    public string? PaymentPriceReceivedStatus
    {
        get; set;
    }
    /// <summary>유지증거금총액</summary>
    [DataMember, JsonProperty("유지증거금총액")]
    public string? TotalAmountOfMaintenanceDeposits
    {
        get; set;
    }
    /// <summary>유지증거금총액부족액</summary>
    [DataMember, JsonProperty("유지증거금총액부족액")]
    public string? TotalShortageOfMaintenanceDeposits
    {
        get; set;
    }
    /// <summary>유지증거금현금부족액</summary>
    [DataMember, JsonProperty("유지증거금현금부족액")]
    public string? MaintenanceEvidenceCashShortage
    {
        get; set;
    }
    /// <summary>옵션잔고평가손익</summary>
    [DataMember, JsonProperty("옵션잔고평가손익")]
    public string? GainOrLossOnValuationOfOptionsBalance
    {
        get; set;
    }
    /// <summary>예탁대용</summary>
    [DataMember, JsonProperty("예탁대용")]
    public string? DepositReplacement
    {
        get; set;
    }
    /// <summary>익일결제예정금액</summary>
    [DataMember, JsonProperty("익일결제예정금액")]
    public string? EstimatedAmountForNextDayPayment
    {
        get; set;
    }
}