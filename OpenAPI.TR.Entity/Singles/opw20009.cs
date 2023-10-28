using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵계좌별주문가능수량</summary>
public class SingleOpw20009
{
    /// <summary>예탁총액</summary>
    [DataMember, JsonProperty("예탁총액")]
    public string? 예탁총액
    {
        get; set;
    }
    /// <summary>예탁현금</summary>
    [DataMember, JsonProperty("예탁현금")]
    public string? 예탁현금
    {
        get; set;
    }
    /// <summary>위탁증거금</summary>
    [DataMember, JsonProperty("위탁증거금")]
    public string? 위탁증거금
    {
        get; set;
    }
    /// <summary>현금증거금</summary>
    [DataMember, JsonProperty("현금증거금")]
    public string? 현금증거금
    {
        get; set;
    }
    /// <summary>주문가능금액</summary>
    [DataMember, JsonProperty("주문가능금액")]
    public string? 주문가능금액
    {
        get; set;
    }
    /// <summary>신규가능수량</summary>
    [DataMember, JsonProperty("신규가능수량")]
    public string? 신규가능수량
    {
        get; set;
    }
    /// <summary>청산가능수량</summary>
    [DataMember, JsonProperty("청산가능수량")]
    public string? 청산가능수량
    {
        get; set;
    }
    /// <summary>총가능수량</summary>
    [DataMember, JsonProperty("총가능수량")]
    public string? 총가능수량
    {
        get; set;
    }
    /// <summary>주문가능총액</summary>
    [DataMember, JsonProperty("주문가능총액")]
    public string? 주문가능총액
    {
        get; set;
    }
    /// <summary>필요증거금총액</summary>
    [DataMember, JsonProperty("필요증거금총액")]
    public string? 필요증거금총액
    {
        get; set;
    }
    /// <summary>총액부족액</summary>
    [DataMember, JsonProperty("총액부족액")]
    public string? 총액부족액
    {
        get; set;
    }
    /// <summary>주문가능현금</summary>
    [DataMember, JsonProperty("주문가능현금")]
    public string? 주문가능현금
    {
        get; set;
    }
    /// <summary>필요증거금현금</summary>
    [DataMember, JsonProperty("필요증거금현금")]
    public string? 필요증거금현금
    {
        get; set;
    }
    /// <summary>현금부족액</summary>
    [DataMember, JsonProperty("현금부족액")]
    public string? 현금부족액
    {
        get; set;
    }
    /// <summary>주문가능대용금</summary>
    [DataMember, JsonProperty("주문가능대용금")]
    public string? 주문가능대용금
    {
        get; set;
    }
    /// <summary>필요증거금대용금</summary>
    [DataMember, JsonProperty("필요증거금대용금")]
    public string? 필요증거금대용금
    {
        get; set;
    }
    /// <summary>대용금부족액</summary>
    [DataMember, JsonProperty("대용금부족액")]
    public string? 대용금부족액
    {
        get; set;
    }
}