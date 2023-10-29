using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵기간손익조회</summary>
public class SingleOpw20003
{
    /// <summary>선물약정금액</summary>
    [DataMember, JsonProperty("선물약정금액")]
    public string? ForwardCommitmentAmount
    {
        get; set;
    }
    /// <summary>옵션약정금액</summary>
    [DataMember, JsonProperty("옵션약정금액")]
    public string? OptionCommitmentAmount
    {
        get; set;
    }
    /// <summary>선물정산손익</summary>
    [DataMember, JsonProperty("선물정산손익")]
    public string? GainOrLossOnFuturesSettlement
    {
        get; set;
    }
    /// <summary>옵션매매손익</summary>
    [DataMember, JsonProperty("옵션매매손익")]
    public string? ProfitAndLossOnOptionTradingOptions
    {
        get; set;
    }
    /// <summary>총손익</summary>
    [DataMember, JsonProperty("총손익")]
    public string? GrossProfitAndLoss
    {
        get; set;
    }
    /// <summary>평균예탁금액</summary>
    [DataMember, JsonProperty("평균예탁금액")]
    public string? AverageDepositAmount
    {
        get; set;
    }
    /// <summary>예탁총액</summary>
    [DataMember, JsonProperty("예탁총액")]
    public string? TotalDeposit
    {
        get; set;
    }
    /// <summary>수수료</summary>
    [DataMember, JsonProperty("수수료")]
    public string? Fee
    {
        get; set;
    }
    /// <summary>수익율</summary>
    [DataMember, JsonProperty("수익율")]
    public string? Yield
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