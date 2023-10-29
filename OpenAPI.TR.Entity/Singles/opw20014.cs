using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵실시간증거금산출</summary>
public class SingleOpw20014
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
    /// <summary>예탁현금</summary>
    [DataMember, JsonProperty("예탁현금")]
    public string? DepositCash
    {
        get; set;
    }
    /// <summary>예탁대용금</summary>
    [DataMember, JsonProperty("예탁대용금")]
    public string? DepositLoan
    {
        get; set;
    }
    /// <summary>위탁증거금</summary>
    [DataMember, JsonProperty("위탁증거금")]
    public string? ConsignmentMargin
    {
        get; set;
    }
    /// <summary>현금증거금</summary>
    [DataMember, JsonProperty("현금증거금")]
    public string? CashDeposit
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
    /// <summary>추정예탁총액</summary>
    [DataMember, JsonProperty("추정예탁총액")]
    public string? EstimatedDepositTotal
    {
        get; set;
    }
    /// <summary>추정예탁현금</summary>
    [DataMember, JsonProperty("추정예탁현금")]
    public string? EstimatedDepositCash
    {
        get; set;
    }
    /// <summary>추정위탁증거금총액</summary>
    [DataMember, JsonProperty("추정위탁증거금총액")]
    public string? EstimatedConsignmentMarginTotal
    {
        get; set;
    }
    /// <summary>추정위탁증거금현금</summary>
    [DataMember, JsonProperty("추정위탁증거금현금")]
    public string? EstimatedConsignmentMarginCash
    {
        get; set;
    }
    /// <summary>추정유지증거금총액</summary>
    [DataMember, JsonProperty("추정유지증거금총액")]
    public string? TotalEstimatedMaintenanceMargin
    {
        get; set;
    }
    /// <summary>추정유지증거금현금</summary>
    [DataMember, JsonProperty("추정유지증거금현금")]
    public string? EstimatedMaintenanceMarginCash
    {
        get; set;
    }
    /// <summary>추정추가증거금총액</summary>
    [DataMember, JsonProperty("추정추가증거금총액")]
    public string? EstimatedAdditionalMarginTotal
    {
        get; set;
    }
    /// <summary>추정추가증거금현금</summary>
    [DataMember, JsonProperty("추정추가증거금현금")]
    public string? EstimatedAdditionalMarginCash
    {
        get; set;
    }
    /// <summary>선물당일차금</summary>
    [DataMember, JsonProperty("선물당일차금")]
    public string? FirstDayOfThePresent
    {
        get; set;
    }
    /// <summary>옵션결제대금</summary>
    [DataMember, JsonProperty("옵션결제대금")]
    public string? OptionPayment
    {
        get; set;
    }
    /// <summary>인수도대금</summary>
    [DataMember, JsonProperty("인수도대금")]
    public string? UnderwritingPrice
    {
        get; set;
    }
    /// <summary>수수료</summary>
    [DataMember, JsonProperty("수수료")]
    public string? Fee
    {
        get; set;
    }
    /// <summary>선물갱신차금</summary>
    [DataMember, JsonProperty("선물갱신차금")]
    public string? FuturesRenewalCharge
    {
        get; set;
    }
    /// <summary>선물최종차금</summary>
    [DataMember, JsonProperty("선물최종차금")]
    public string? FinalDifferenceForAGift
    {
        get; set;
    }
    /// <summary>옵션행사배정대금</summary>
    [DataMember, JsonProperty("옵션행사배정대금")]
    public string? OptionEventAllocationPrice
    {
        get; set;
    }
    /// <summary>유지증거금기준부족액</summary>
    [DataMember, JsonProperty("유지증거금기준부족액")]
    public string? ShortageOfMaintenanceMarginStandards
    {
        get; set;
    }
    /// <summary>위탁증거금기준부족액</summary>
    [DataMember, JsonProperty("위탁증거금기준부족액")]
    public string? ShortageBasedOnConsignmentMargin
    {
        get; set;
    }
    /// <summary>사후증거금계좌구분</summary>
    [DataMember, JsonProperty("사후증거금계좌구분")]
    public string? PostDepositAccountClassification
    {
        get; set;
    }
    /// <summary>결제가격수신여부</summary>
    [DataMember, JsonProperty("결제가격수신여부")]
    public string? PaymentPriceReceivedStatus
    {
        get; set;
    }
    /// <summary>장종료예탁총액</summary>
    [DataMember, JsonProperty("장종료예탁총액")]
    public string? TotalAmountOfDepositsAtTheEndOfTheMarket
    {
        get; set;
    }
    /// <summary>장종료예탁현금</summary>
    [DataMember, JsonProperty("장종료예탁현금")]
    public string? EndOfMarketDepositCash
    {
        get; set;
    }
    /// <summary>장종료예탁대용금</summary>
    [DataMember, JsonProperty("장종료예탁대용금")]
    public string? EndOfMarketDeposit
    {
        get;        set;
    }
    /// <summary>조회건수</summary>
    [DataMember, JsonProperty("조회건수")]
    public string? NumberOfInquiries
    {
        get;        set;
    }
}