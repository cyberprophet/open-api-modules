using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵시고저가</summary>
public class MultiOPT50040
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public string? StandardPrice
    {
        get; set;
    }
    /// <summary>체결량</summary>
    [DataMember, JsonProperty("체결량")]
    public string? AmountOfEngagement
    {
        get; set;
    }
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가")]
    public string? StartPrice
    {
        get; set;
    }
    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가")]
    public string? HighPrice
    {
        get; set;
    }
    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가")]
    public string? LowPrice
    {
        get; set;
    }
    /// <summary>시초미결제약정수량</summary>
    [DataMember, JsonProperty("시초미결제약정수량")]
    public string? InitialOutstandingPaymentAgreementQuantity
    {
        get; set;
    }
    /// <summary>최고미결제약정수량</summary>
    [DataMember, JsonProperty("최고미결제약정수량")]
    public string? MaximumAmountOfOutstandingAgreements
    {
        get; set;
    }
    /// <summary>최저미결제약정수량</summary>
    [DataMember, JsonProperty("최저미결제약정수량")]
    public string? MinimumAmountOfOutstandingPaymentAgreement
    {
        get; set;
    }
    /// <summary>미결제약정</summary>
    [DataMember, JsonProperty("미결제약정")]
    public string? OpenInterest
    {
        get; set;
    }
    /// <summary>전일미결제약정</summary>
    [DataMember, JsonProperty("전일미결제약정")]
    public string? PreviousDayOutstandingSettlement
    {
        get; set;
    }
    /// <summary>이론가</summary>
    [DataMember, JsonProperty("이론가")]
    public string? Theorist
    {
        get; set;
    }
    /// <summary>내재변동성</summary>
    [DataMember, JsonProperty("내재변동성")]
    public string? IntrinsicVolatility
    {
        get; set;
    }
    /// <summary>델타</summary>
    [DataMember, JsonProperty("델타")]
    public string? Delta
    {
        get; set;
    }
    /// <summary>감마</summary>
    [DataMember, JsonProperty("감마")]
    public string? Gamma
    {
        get; set;
    }
    /// <summary>상한가</summary>
    [DataMember, JsonProperty("상한가")]
    public string? UpperLimit
    {
        get; set;
    }
    /// <summary>하한가</summary>
    [DataMember, JsonProperty("하한가")]
    public string? LowerPrice
    {
        get; set;
    }
    /// <summary>시장베이시스</summary>
    [DataMember, JsonProperty("시장베이시스")]
    public string? MarketBasis
    {
        get; set;
    }
    /// <summary>괴리율</summary>
    [DataMember, JsonProperty("괴리율")]
    public string? DisparateRatio
    {
        get; set;
    }
}