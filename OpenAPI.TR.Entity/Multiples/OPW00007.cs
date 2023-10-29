using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌별주문체결내역상세</summary>
public class MultiOPW00007
{
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
    /// <summary>신용구분</summary>
    [DataMember, JsonProperty("신용구분")]
    public string? CreditClassification
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
    /// <summary>접수구분</summary>
    [DataMember, JsonProperty("접수구분")]
    public string? ReceivingClassification
    {
        get; set;
    }
    /// <summary>반대여부</summary>
    [DataMember, JsonProperty("반대여부")]
    public string? OpposingOrNot
    {
        get; set;
    }
    /// <summary>주문시간</summary>
    [DataMember, JsonProperty("주문시간")]
    public string? OrderTime
    {
        get; set;
    }
    /// <summary>원주문</summary>
    [DataMember, JsonProperty("원주문")]
    public string? CircumferentialSentence
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
    /// <summary>대출일</summary>
    [DataMember, JsonProperty("대출일")]
    public string? DateOfLoan
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
    /// <summary>주문잔량</summary>
    [DataMember, JsonProperty("주문잔량")]
    public string? OrderRemaining
    {
        get; set;
    }
    /// <summary>통신구분</summary>
    [DataMember, JsonProperty("통신구분")]
    public string? CommunicationClassification
    {
        get; set;
    }
    /// <summary>정정취소</summary>
    [DataMember, JsonProperty("정정취소")]
    public string? CancellationOfCorrection
    {
        get; set;
    }
    /// <summary>확인시간</summary>
    [DataMember, JsonProperty("확인시간")]
    public string? ConfirmationTime
    {
        get; set;
    }
}