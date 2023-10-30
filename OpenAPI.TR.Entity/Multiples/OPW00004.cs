using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별계좌평가현황</summary>
public class MultiOPW00004
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드"), StringLength(8)]
    public virtual string? Code
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명"), StringLength(0x10)]
    public virtual string? Name
    {
        get; set;
    }
    /// <summary>보유수량</summary>
    [DataMember, JsonProperty("보유수량"), StringLength(0x10)]
    public string? Quantity
    {
        get; set;
    }
    /// <summary>평균단가</summary>
    [DataMember, JsonProperty("평균단가"), StringLength(0x10)]
    public string? Average
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가"), StringLength(0x10)]
    public string? Current
    {
        get; set;
    }
    /// <summary>평가금액</summary>
    [DataMember, JsonProperty("평가금액"), StringLength(0x10)]
    public string? Evaluation
    {
        get; set;
    }
    /// <summary>손익금액</summary>
    [DataMember, JsonProperty("손익금액"), StringLength(0x10)]
    public string? Amount
    {
        get; set;
    }
    /// <summary>손익율</summary>
    [DataMember, JsonProperty("손익율"), StringLength(0x10)]
    public string? Rate
    {
        get; set;
    }
    /// <summary>대출일</summary>
    [DataMember, JsonProperty("대출일"), StringLength(0x10)]
    public string? Loan
    {
        get; set;
    }
    /// <summary>매입금액</summary>
    [DataMember, JsonProperty("매입금액"), StringLength(0x10)]
    public string? Purchase
    {
        get; set;
    }
    /// <summary>결제잔고</summary>
    [DataMember, JsonProperty("결제잔고"), StringLength(0x10)]
    public string? PaymentBalance
    {
        get; set;
    }
    /// <summary>전일매수수량</summary>
    [DataMember, JsonProperty("전일매수수량"), StringLength(0x10)]
    public string? PreviousPurchaseQuantity
    {
        get; set;
    }
    /// <summary>전일매도수량</summary>
    [DataMember, JsonProperty("전일매도수량"), StringLength(0x10)]
    public string? PreviousSalesQuantity
    {
        get; set;
    }
    /// <summary>금일매수수량</summary>
    [DataMember, JsonProperty("금일매수수량"), StringLength(0x10)]
    public string? PurchaseQuantity
    {
        get; set;
    }
    /// <summary>금일매도수량</summary>
    [DataMember, JsonProperty("금일매도수량"), StringLength(0x10)]
    public string? SalesQuantity
    {
        get; set;
    }
}