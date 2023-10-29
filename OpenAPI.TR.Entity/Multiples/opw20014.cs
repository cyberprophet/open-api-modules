using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵내재변동성</summary>
public class MultiOpw20014
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>매도매수구분</summary>
    [DataMember, JsonProperty("매도매수구분")]
    public string? SellingAndBuyingClassification
    {
        get; set;
    }
    /// <summary>미결제수량</summary>
    [DataMember, JsonProperty("미결제수량")]
    public string? OutstandingQuantity
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>내재변동성</summary>
    [DataMember, JsonProperty("내재변동성")]
    public string? IntrinsicVolatility
    {
        get; set;
    }
    /// <summary>이론지수</summary>
    [DataMember, JsonProperty("이론지수")]
    public string? TheoreticalIndex
    {
        get; set;
    }
    /// <summary>잔존일수</summary>
    [DataMember, JsonProperty("잔존일수")]
    public string? RemainingDays
    {
        get; set;
    }
}