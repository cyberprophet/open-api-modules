using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>관리자별주문체결내역</summary>
public class MultiOPW00006
{
    /// <summary>주문번호</summary>
    [DataMember, JsonProperty("주문번호")]
    public string? OrderNumber
    {
        get; set;
    }
    /// <summary>원주문번호</summary>
    [DataMember, JsonProperty("원주문번호")]
    public string? CircularNumber
    {
        get; set;
    }
    /// <summary>모주문번호</summary>
    [DataMember, JsonProperty("모주문번호")]
    public string? BaseOrderNumber
    {
        get; set;
    }
    /// <summary>계좌번호</summary>
    [DataMember, JsonProperty("계좌번호")]
    public string? BankAccountNumber
    {
        get; set;
    }
    /// <summary>계좌명</summary>
    [DataMember, JsonProperty("계좌명")]
    public string? AccountName
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>정정구분</summary>
    [DataMember, JsonProperty("정정구분")]
    public string? CorrectionClassification
    {
        get; set;
    }
    /// <summary>매도수구분</summary>
    [DataMember, JsonProperty("매도수구분")]
    public string? NumberOfUnitsSold
    {
        get; set;
    }
    /// <summary>주문구분</summary>
    [DataMember, JsonProperty("주문구분")]
    public string? OrderClassification
    {
        get; set;
    }
    /// <summary>통신주문구분</summary>
    [DataMember, JsonProperty("통신주문구분")]
    public string? CommunicationOrderClassification
    {
        get; set;
    }
    /// <summary>주문수량</summary>
    [DataMember, JsonProperty("주문수량")]
    public string? OrderQuantity
    {
        get; set;
    }
    /// <summary>주문지수</summary>
    [DataMember, JsonProperty("주문지수")]
    public string? OrderIndex
    {
        get; set;
    }
    /// <summary>주문잔량</summary>
    [DataMember, JsonProperty("주문잔량")]
    public string? OrderRemaining
    {
        get; set;
    }
    /// <summary>체결수량</summary>
    [DataMember, JsonProperty("체결수량")]
    public string? ConcludedQuantity
    {
        get; set;
    }
    /// <summary>체결지수</summary>
    [DataMember, JsonProperty("체결지수")]
    public string? FasteningIndex
    {
        get; set;
    }
    /// <summary>접수여부</summary>
    [DataMember, JsonProperty("접수여부")]
    public string? AcceptanceStatus
    {
        get; set;
    }
    /// <summary>체결번호</summary>
    [DataMember, JsonProperty("체결번호")]
    public string? ConcludingNumber
    {
        get; set;
    }
}