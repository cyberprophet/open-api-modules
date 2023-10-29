using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵주문체결</summary>
public class MultiOPT50026
{
    /// <summary>주문번호</summary>
    [DataMember, JsonProperty("주문번호")]
    public string? OrderNumber
    {
        get; set;
    }
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
    /// <summary>주문구분</summary>
    [DataMember, JsonProperty("주문구분")]
    public string? OrderClassification
    {
        get; set;
    }
    /// <summary>주문가격</summary>
    [DataMember, JsonProperty("주문가격")]
    public string? OrderPrice
    {
        get; set;
    }
    /// <summary>주문수량</summary>
    [DataMember, JsonProperty("주문수량")]
    public string? OrderQuantity
    {
        get; set;
    }
    /// <summary>체결가</summary>
    [DataMember, JsonProperty("체결가")]
    public string? EngagementPrice
    {
        get; set;
    }
    /// <summary>체결량</summary>
    [DataMember, JsonProperty("체결량")]
    public string? AmountOfEngagement
    {
        get; set;
    }
    /// <summary>미체결수량</summary>
    [DataMember, JsonProperty("미체결수량")]
    public string? UncontractedQuantity
    {
        get; set;
    }
    /// <summary>주문상태</summary>
    [DataMember, JsonProperty("주문상태")]
    public string? OrderStatus
    {
        get; set;
    }
    /// <summary>원주문번호</summary>
    [DataMember, JsonProperty("원주문번호")]
    public string? CircularNumber
    {
        get; set;
    }
    /// <summary>매매구분</summary>
    [DataMember, JsonProperty("매매구분")]
    public string? TradingClassification
    {
        get; set;
    }
    /// <summary>주문체결시간</summary>
    [DataMember, JsonProperty("주문체결시간")]
    public string? OrderSigningTime
    {
        get; set;
    }
}