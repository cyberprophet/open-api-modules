using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물전체시세</summary>
public class SingleOPTFOFID
{
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
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>매도호가2</summary>
    [DataMember, JsonProperty("매도호가2")]
    public string? SellingPrice2
    {
        get; set;
    }
    /// <summary>매도호가1</summary>
    [DataMember, JsonProperty("매도호가1")]
    public string? SellingPrice1
    {
        get; set;
    }
    /// <summary>매수호가1</summary>
    [DataMember, JsonProperty("매수호가1")]
    public string? BuyingPrice1
    {
        get; set;
    }
    /// <summary>매수호가2</summary>
    [DataMember, JsonProperty("매수호가2")]
    public string? BuyingPrice2
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? VolumeOfTransaction
    {
        get; set;
    }
    /// <summary>거래량전일대비</summary>
    [DataMember, JsonProperty("거래량전일대비")]
    public string? TradingVolumeDayOnDay
    {
        get; set;
    }
    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금")]
    public string? AccumulatedTransactionAmount
    {
        get; set;
    }
    /// <summary>미결제약정</summary>
    [DataMember, JsonProperty("미결제약정")]
    public string? OpenInterest
    {
        get; set;
    }
    /// <summary>미결제약정전일대비</summary>
    [DataMember, JsonProperty("미결제약정전일대비")]
    public string? ComparedToThePreviousDayOfTheOutstandingPayment
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
    /// <summary>이론가</summary>
    [DataMember, JsonProperty("이론가")]
    public string? Theorist
    {
        get; set;
    }
    /// <summary>괴리율</summary>
    [DataMember, JsonProperty("괴리율")]
    public string? DisparateRatio
    {
        get; set;
    }
    /// <summary>시장베이시스</summary>
    [DataMember, JsonProperty("시장베이시스")]
    public string? MarketBasis
    {
        get; set;
    }
    /// <summary>이론베이시스</summary>
    [DataMember, JsonProperty("이론베이시스")]
    public string? TheoreticalBasis
    {
        get; set;
    }
    /// <summary>행사가</summary>
    [DataMember, JsonProperty("행사가")]
    public string? Eventist
    {
        get; set;
    }
    /// <summary>지수환산</summary>
    [DataMember, JsonProperty("지수환산")]
    public string? ExponentialConversion
    {
        get; set;
    }
    /// <summary>대비기호</summary>
    [DataMember, JsonProperty("대비기호")]
    public string? ContrastSymbol
    {
        get; set;
    }
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? FluctuationRate
    {
        get; set;
    }
    /// <summary>매수수량</summary>
    [DataMember, JsonProperty("매수수량")]
    public string? PurchaseQuantity
    {
        get; set;
    }
    /// <summary>매수호가총건수</summary>
    [DataMember, JsonProperty("매수호가총건수")]
    public string? TotalNumberOfPurchaseCalls
    {
        get; set;
    }
    /// <summary>매도호가총건수</summary>
    [DataMember, JsonProperty("매도호가총건수")]
    public string? TotalNumberOfSellingCalls
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public string? StandardPrice
    {
        get; set;
    }
    /// <summary>잔존일수</summary>
    [DataMember, JsonProperty("잔존일수")]
    public string? RemainingDays
    {
        get; set;
    }
    /// <summary>영업일기준잔존일</summary>
    [DataMember, JsonProperty("영업일기준잔존일")]
    public string? RemainingDaysBasedOnBusinessDays
    {
        get; set;
    }
}