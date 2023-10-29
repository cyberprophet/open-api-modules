using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵주문체결내역상세</summary>
public class MultiOpw20004
{
    /// <summary>주문번호</summary>
    [DataMember, JsonProperty("주문번호")]
    public string? OrderNumber
    {
        get; set;
    }
    /// <summary>매매구분</summary>
    [DataMember, JsonProperty("매매구분")]
    public string? TradingClassification
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>주문수량</summary>
    [DataMember, JsonProperty("주문수량")]
    public string? OrderQuantity
    {
        get; set;
    }
    /// <summary>체결수량</summary>
    [DataMember, JsonProperty("체결수량")]
    public string? ConcludedQuantity
    {
        get; set;
    }
    /// <summary>미체결수량</summary>
    [DataMember, JsonProperty("미체결수량")]
    public string? UncontractedQuantity
    {
        get; set;
    }
    /// <summary>접수번호</summary>
    [DataMember, JsonProperty("접수번호")]
    public string? ReceptionNumber
    {
        get; set;
    }
    /// <summary>접수구분</summary>
    [DataMember, JsonProperty("접수구분")]
    public string? ReceivingClassification
    {
        get; set;
    }
    /// <summary>조작자사번</summary>
    [DataMember, JsonProperty("조작자사번")]
    public string? OperatorNumber
    {
        get; set;
    }
    /// <summary>원주문번호</summary>
    [DataMember, JsonProperty("원주문번호")]
    public string? CircularNumber
    {
        get; set;
    }
    /// <summary>주문유형</summary>
    [DataMember, JsonProperty("주문유형")]
    public string? OrderType
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>주문가격</summary>
    [DataMember, JsonProperty("주문가격")]
    public string? OrderPrice
    {
        get; set;
    }
    /// <summary>체결가격</summary>
    [DataMember, JsonProperty("체결가격")]
    public string? ClosingPrice
    {
        get; set;
    }
    /// <summary>체결번호</summary>
    [DataMember, JsonProperty("체결번호")]
    public string? ConcludingNumber
    {
        get; set;
    }
    /// <summary>약정시간</summary>
    [DataMember, JsonProperty("약정시간")]
    public string? ContractedTime
    {
        get; set;
    }
    /// <summary>접수시간</summary>
    [DataMember, JsonProperty("접수시간")]
    public string? ReceptionTime
    {
        get; set;
    }
    /// <summary>매체</summary>
    [DataMember, JsonProperty("매체")]
    public string? Media
    {
        get; set;
    }
}