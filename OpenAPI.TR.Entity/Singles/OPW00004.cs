using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌평가현황</summary>
public class SingleOPW00004
{
    /// <summary>계좌명</summary>
    [DataMember, JsonProperty("계좌명"), StringLength(0x10)]
    public virtual string? Name
    {
        get; set;
    }
    /// <summary>지점명</summary>
    [DataMember, JsonProperty("지점명"), StringLength(0x10)]
    public virtual string? Branch
    {
        get; set;
    }
    /// <summary>예수금</summary>
    [DataMember, JsonProperty("예수금"), StringLength(0x10)]
    public virtual string? Deposit
    {
        get; set;
    }
    /// <summary>D+2추정예수금</summary>
    [DataMember, JsonProperty("D+2추정예수금"), StringLength(0x10)]
    public virtual string? PresumeDeposit
    {
        get; set;
    }
    /// <summary>유가잔고평가액</summary>
    [DataMember, JsonProperty("유가잔고평가액"), StringLength(0x10)]
    public virtual string? Balance
    {
        get; set;
    }
    /// <summary>예탁자산평가액</summary>
    [DataMember, JsonProperty("예탁자산평가액"), StringLength(0x10)]
    public virtual string? Asset
    {
        get; set;
    }
    /// <summary>총매입금액</summary>
    [DataMember, JsonProperty("총매입금액"), StringLength(0x10)]
    public virtual string? TotalPurchaseAmount
    {
        get; set;
    }
    /// <summary>추정예탁자산</summary>
    [DataMember, JsonProperty("추정예탁자산"), StringLength(0x10)]
    public virtual string? PresumeAsset
    {
        get; set;
    }
    /// <summary>매도담보대출금</summary>
    [DataMember, JsonProperty("매도담보대출금"), StringLength(0x10)]
    public virtual string? MortgageLoan
    {
        get; set;
    }
    /// <summary>당일투자원금</summary>
    [DataMember, JsonProperty("당일투자원금"), StringLength(0x10)]
    public virtual string? SameDayInvestment
    {
        get; set;
    }
    /// <summary>당월투자원금</summary>
    [DataMember, JsonProperty("당월투자원금"), StringLength(0x10)]
    public virtual string? CurrentMonthInvestment
    {
        get; set;
    }
    /// <summary>누적투자원금</summary>
    [DataMember, JsonProperty("누적투자원금"), StringLength(0x10)]
    public virtual string? AccumulatedInvestment
    {
        get; set;
    }
    /// <summary>당일투자손익</summary>
    [DataMember, JsonProperty("당일투자손익"), StringLength(0x10)]
    public virtual string? SameDayProfitAndLoss
    {
        get; set;
    }
    /// <summary>당월투자손익</summary>
    [DataMember, JsonProperty("당월투자손익"), StringLength(0x10)]
    public virtual string? CurrentMonthProfitAndLoss
    {
        get; set;
    }
    /// <summary>누적투자손익</summary>
    [DataMember, JsonProperty("누적투자손익"), StringLength(0x10)]
    public virtual string? AccumulatedProfitAndLoss
    {
        get; set;
    }
    /// <summary>당일손익율</summary>
    [DataMember, JsonProperty("당일손익율"), StringLength(0x10)]
    public virtual string? ProfitAndLossPercentageForTheDay
    {
        get; set;
    }
    /// <summary>당월손익율</summary>
    [DataMember, JsonProperty("당월손익율"), StringLength(0x10)]
    public virtual string? ProfitAndLossPercentageForTheCurrentMonth
    {
        get; set;
    }
    /// <summary>누적손익율</summary>
    [DataMember, JsonProperty("누적손익율"), StringLength(0x10)]
    public virtual string? CumulativeProfitPercentage
    {
        get; set;
    }
    /// <summary>출력건수</summary>
    [DataMember, JsonProperty("출력건수"), StringLength(4)]
    public virtual string? NumberOfPrints
    {
        get; set;
    }
}