using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌평가현황</summary>
public class SingleOPW00004
{
    /// <summary>계좌명</summary>
    [DataMember, JsonProperty("계좌명")]
    public string? AccountName
    {
        get; set;
    }
    /// <summary>지점명</summary>
    [DataMember, JsonProperty("지점명")]
    public string? BranchName
    {
        get; set;
    }
    /// <summary>예수금</summary>
    [DataMember, JsonProperty("예수금")]
    public string? Deposit
    {
        get; set;
    }
    /// <summary>D+2추정예수금</summary>
    [DataMember, JsonProperty("D+2추정예수금")]
    public string? D2EstimateDeposit
    {
        get; set;
    }
    /// <summary>유가잔고평가액</summary>
    [DataMember, JsonProperty("유가잔고평가액")]
    public string? ValuationAmountOfOilBalance
    {
        get; set;
    }
    /// <summary>예탁자산평가액</summary>
    [DataMember, JsonProperty("예탁자산평가액")]
    public string? ValuationOfDepositedAssets
    {
        get; set;
    }
    /// <summary>총매입금액</summary>
    [DataMember, JsonProperty("총매입금액")]
    public string? TotalPurchaseAmount
    {
        get; set;
    }
    /// <summary>추정예탁자산</summary>
    [DataMember, JsonProperty("추정예탁자산")]
    public string? EstimatedDepositAssets
    {
        get; set;
    }
    /// <summary>매도담보대출금</summary>
    [DataMember, JsonProperty("매도담보대출금")]
    public string? MortgageOnSale
    {
        get; set;
    }
    /// <summary>당일투자원금</summary>
    [DataMember, JsonProperty("당일투자원금")]
    public string? SameDayInvestmentPrincipal
    {
        get; set;
    }
    /// <summary>당월투자원금</summary>
    [DataMember, JsonProperty("당월투자원금")]
    public string? InvestmentPrincipalForTheCurrentMonth
    {
        get; set;
    }
    /// <summary>누적투자원금</summary>
    [DataMember, JsonProperty("누적투자원금")]
    public string? AccumulatedInvestmentPrincipal
    {
        get; set;
    }
    /// <summary>당일투자손익</summary>
    [DataMember, JsonProperty("당일투자손익")]
    public string? EarningsAndLossesOnInvestmentOnTheDay
    {
        get; set;
    }
    /// <summary>당월투자손익</summary>
    [DataMember, JsonProperty("당월투자손익")]
    public string? EarningsAndLossesOnInvestmentForTheCurrentMonth
    {
        get; set;
    }
    /// <summary>누적투자손익</summary>
    [DataMember, JsonProperty("누적투자손익")]
    public string? AccumulatedInvestmentGainsAndLosses
    {
        get; set;
    }
    /// <summary>당일손익율</summary>
    [DataMember, JsonProperty("당일손익율")]
    public string? SameDayProfitAndLossRate
    {
        get; set;
    }
    /// <summary>당월손익율</summary>
    [DataMember, JsonProperty("당월손익율")]
    public string? ProfitAndLossRateForTheCurrentMonth
    {
        get; set;
    }
    /// <summary>누적손익율</summary>
    [DataMember, JsonProperty("누적손익율")]
    public string? AccumulatedProfitAndLossRatio
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