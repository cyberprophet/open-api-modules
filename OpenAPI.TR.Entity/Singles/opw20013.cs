using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌미결제청산가능수량조회</summary>
public class SingleOpw20013
{
    /// <summary>미결제수량</summary>
    [DataMember, JsonProperty("미결제수량")]
    public string? OutstandingQuantity
    {
        get; set;
    }
    /// <summary>청산가능수량</summary>
    [DataMember, JsonProperty("청산가능수량")]
    public string? LiquidationPossibleQuantity
    {
        get; set;
    }
    /// <summary>현재증거금총액</summary>
    [DataMember, JsonProperty("현재증거금총액")]
    public string? TotalAmountOfCurrentDeposits
    {
        get; set;
    }
    /// <summary>현재증거금현금</summary>
    [DataMember, JsonProperty("현재증거금현금")]
    public string? CurrentMarginCash
    {
        get; set;
    }
    /// <summary>예상위탁증거금</summary>
    [DataMember, JsonProperty("예상위탁증거금")]
    public string? EstimatedConsignmentMargin
    {
        get; set;
    }
    /// <summary>예상현금증거금</summary>
    [DataMember, JsonProperty("예상현금증거금")]
    public string? EstimatedCashMargin
    {
        get; set;
    }
}