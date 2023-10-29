using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵잔고현황정산가기준</summary>
public class MultiOpw20007
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>매도매수구분</summary>
    [DataMember, JsonProperty("매도매수구분")]
    public string? SellingAndBuyingClassification
    {
        get; set;
    }
    /// <summary>수량</summary>
    [DataMember, JsonProperty("수량")]
    public string? Quantity
    {
        get; set;
    }
    /// <summary>매입단가</summary>
    [DataMember, JsonProperty("매입단가")]
    public string? PurchaseUnitPrice
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>평가손익</summary>
    [DataMember, JsonProperty("평가손익")]
    public string? ValuationGainsAndLosses
    {
        get; set;
    }
    /// <summary>청산가능수량</summary>
    [DataMember, JsonProperty("청산가능수량")]
    public string? LiquidationPossibleQuantity
    {
        get; set;
    }
    /// <summary>약정금액</summary>
    [DataMember, JsonProperty("약정금액")]
    public string? ContractAmount
    {
        get; set;
    }
    /// <summary>평가금액</summary>
    [DataMember, JsonProperty("평가금액")]
    public string? EvaluationAmount
    {
        get; set;
    }
}