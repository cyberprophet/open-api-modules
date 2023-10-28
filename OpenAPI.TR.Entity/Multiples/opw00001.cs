using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별예수금현황</summary>
public class MultiOpw00001
{
    /// <summary>통화코드</summary>
    [DataMember, JsonProperty("통화코드")]
    public string? 통화코드
    {
        get; set;
    }
    /// <summary>외화예수금</summary>
    [DataMember, JsonProperty("외화예수금")]
    public string? 외화예수금
    {
        get; set;
    }
    /// <summary>원화대용평가금</summary>
    [DataMember, JsonProperty("원화대용평가금")]
    public string? 원화대용평가금
    {
        get; set;
    }
    /// <summary>해외주식증거금</summary>
    [DataMember, JsonProperty("해외주식증거금")]
    public string? 해외주식증거금
    {
        get; set;
    }
    /// <summary>출금가능금액(예수금)</summary>
    [DataMember, JsonProperty("출금가능금액(예수금)")]
    public string? 출금가능금액예수금
    {
        get; set;
    }
    /// <summary>주문가능금액(예수금)</summary>
    [DataMember, JsonProperty("주문가능금액(예수금)")]
    public string? 주문가능금액예수금
    {
        get; set;
    }
    /// <summary>외화미수(합계)</summary>
    [DataMember, JsonProperty("외화미수(합계)")]
    public string? 외화미수합계
    {
        get; set;
    }
    /// <summary>외화현금미수금</summary>
    [DataMember, JsonProperty("외화현금미수금")]
    public string? 외화현금미수금
    {
        get; set;
    }
    /// <summary>연체료</summary>
    [DataMember, JsonProperty("연체료")]
    public string? 연체료
    {
        get; set;
    }
    /// <summary>d+1외화예수금</summary>
    [DataMember, JsonProperty("d+1외화예수금")]
    public string? D1외화예수금
    {
        get; set;
    }
    /// <summary>d+2외화예수금</summary>
    [DataMember, JsonProperty("d+2외화예수금")]
    public string? D2외화예수금
    {
        get; set;
    }
    /// <summary>d+3외화예수금</summary>
    [DataMember, JsonProperty("d+3외화예수금")]
    public string? D3외화예수금
    {
        get;
        set;
    }
    /// <summary>d+4외화예수금</summary>
    [DataMember, JsonProperty("d+4외화예수금")]
    public string? D4외화예수금
    {
        get;
        set;
    }
}