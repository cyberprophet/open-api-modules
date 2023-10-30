using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별체결잔고</summary>
public class MultiOpw00005
{
    /// <summary>신용구분</summary>
    [StringLength(0x10), DataMember, JsonProperty("신용구분")]
    public virtual string? Credit
    {
        get; set;
    }
    /// <summary>대출일</summary>
    [StringLength(0x10), DataMember, JsonProperty("대출일")]
    public virtual string? LoanDate
    {
        get; set;
    }
    /// <summary>만기일</summary>
    [StringLength(0x10), DataMember, JsonProperty("만기일")]
    public virtual string? ExpiryDate
    {
        get; set;
    }
    /// <summary>종목번호</summary>
    [StringLength(0x8), DataMember, JsonProperty("종목번호")]
    public virtual string? Code
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [StringLength(0x10), DataMember, JsonProperty("종목명")]
    public virtual string? Name
    {
        get; set;
    }
    /// <summary>결제잔고</summary>
    [StringLength(0x10), DataMember, JsonProperty("결제잔고")]
    public virtual string? PaymentBalance
    {
        get; set;
    }
    /// <summary>현재잔고</summary>
    [StringLength(0x10), DataMember, JsonProperty("현재잔고")]
    public virtual string? Quantity
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [StringLength(0x10), DataMember, JsonProperty("현재가")]
    public virtual string? Current
    {
        get; set;
    }
    /// <summary>매입단가</summary>
    [StringLength(0x10), DataMember, JsonProperty("매입단가")]
    public virtual string? Average
    {
        get; set;
    }
    /// <summary>매입금액</summary>
    [StringLength(0x10), DataMember, JsonProperty("매입금액")]
    public virtual string? Purchase
    {
        get; set;
    }
    /// <summary>평가금액</summary>
    [StringLength(0x10), DataMember, JsonProperty("평가금액")]
    public virtual string? Evaluation
    {
        get; set;
    }
    /// <summary>평가손익</summary>
    [StringLength(0x10), DataMember, JsonProperty("평가손익")]
    public virtual string? Amount
    {
        get; set;
    }
    /// <summary>손익률</summary>
    [StringLength(0x10), DataMember, JsonProperty("손익률")]
    public virtual string? Rate
    {
        get; set;
    }
}