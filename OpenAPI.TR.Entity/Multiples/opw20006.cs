using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵잔고상세현황</summary>
public class MultiOpw20006
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
    /// <summary>매매일자</summary>
    [DataMember, JsonProperty("매매일자")]
    public string? DateOfSale
    {
        get; set;
    }
    /// <summary>매매구분</summary>
    [DataMember, JsonProperty("매매구분")]
    public string? TradingClassification
    {
        get; set;
    }
    /// <summary>잔고수량</summary>
    [DataMember, JsonProperty("잔고수량")]
    public string? BalanceQuantity
    {
        get; set;
    }
    /// <summary>매입단가</summary>
    [DataMember, JsonProperty("매입단가")]
    public string? PurchaseUnitPrice
    {
        get; set;
    }
    /// <summary>매매금액</summary>
    [DataMember, JsonProperty("매매금액")]
    public string? AmountOfMoney
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
    /// <summary>손익율</summary>
    [DataMember, JsonProperty("손익율")]
    public string? ProfitLossRatio
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