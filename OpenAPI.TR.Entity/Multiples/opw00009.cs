using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌별주문체결현황배열</summary>
public class MultiOpw00009
{
    /// <summary>주식채권구분</summary>
    [DataMember, JsonProperty("주식채권구분")]
    public string? StockBondClassification
    {
        get; set;
    }
    /// <summary>주문번호</summary>
    [DataMember, JsonProperty("주문번호")]
    public string? OrderNumber
    {
        get; set;
    }
    /// <summary>종목번호</summary>
    [DataMember, JsonProperty("종목번호")]
    public string? ItemNumber
    {
        get; set;
    }
    /// <summary>매매구분</summary>
    [DataMember, JsonProperty("매매구분")]
    public string? TradingClassification
    {
        get; set;
    }
    /// <summary>주문유형구분</summary>
    [DataMember, JsonProperty("주문유형구분")]
    public string? OrderTypeClassification
    {
        get; set;
    }
    /// <summary>주문수량</summary>
    [DataMember, JsonProperty("주문수량")]
    public string? OrderQuantity
    {
        get; set;
    }
    /// <summary>주문단가</summary>
    [DataMember, JsonProperty("주문단가")]
    public string? OrderUnitPrice
    {
        get; set;
    }
    /// <summary>확인수량</summary>
    [DataMember, JsonProperty("확인수량")]
    public string? ConfirmedQuantity
    {
        get; set;
    }
    /// <summary>예약반대</summary>
    [DataMember, JsonProperty("예약반대")]
    public string? NoReservation
    {
        get; set;
    }
    /// <summary>체결번호</summary>
    [DataMember, JsonProperty("체결번호")]
    public string? ConcludingNumber
    {
        get; set;
    }
    /// <summary>접수구분</summary>
    [DataMember, JsonProperty("접수구분")]
    public string? ReceivingClassification
    {
        get; set;
    }
    /// <summary>원주문번호</summary>
    [DataMember, JsonProperty("원주문번호")]
    public string? CircularNumber
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>결제구분</summary>
    [DataMember, JsonProperty("결제구분")]
    public string? PaymentClassification
    {
        get; set;
    }
    /// <summary>신용거래구분</summary>
    [DataMember, JsonProperty("신용거래구분")]
    public string? CreditTransactionClassification
    {
        get; set;
    }
    /// <summary>체결수량</summary>
    [DataMember, JsonProperty("체결수량")]
    public string? ConcludedQuantity
    {
        get; set;
    }
    /// <summary>체결단가</summary>
    [DataMember, JsonProperty("체결단가")]
    public string? ConcludingUnitPrice
    {
        get; set;
    }
    /// <summary>통신구분</summary>
    [DataMember, JsonProperty("통신구분")]
    public string? CommunicationClassification
    {
        get; set;
    }
    /// <summary>정정취소구분</summary>
    [DataMember, JsonProperty("정정취소구분")]
    public string? CorrectionCancellationClassification
    {
        get; set;
    }
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? ConcludingTime
    {
        get; set;
    }
}