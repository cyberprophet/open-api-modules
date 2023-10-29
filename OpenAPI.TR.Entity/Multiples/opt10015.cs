using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일별거래상세</summary>
public class MultiOpt10015
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>종가</summary>
    [DataMember, JsonProperty("종가")]
    public string? ClosingPrice
    {
        get; set;
    }
    /// <summary>전일대비기호</summary>
    [DataMember, JsonProperty("전일대비기호")]
    public string? SignsComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? FluctuationRate
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? VolumeOfTransaction
    {
        get; set;
    }
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금")]
    public string? TransactionPrice
    {
        get; set;
    }
    /// <summary>장전거래량</summary>
    [DataMember, JsonProperty("장전거래량")]
    public string? LoadedTradingVolume
    {
        get; set;
    }
    /// <summary>장전거래비중</summary>
    [DataMember, JsonProperty("장전거래비중")]
    public string? ShareOfBilling
    {
        get; set;
    }
    /// <summary>장중거래량</summary>
    [DataMember, JsonProperty("장중거래량")]
    public string? IntradayTradingVolume
    {
        get; set;
    }
    /// <summary>장중거래비중</summary>
    [DataMember, JsonProperty("장중거래비중")]
    public string? ShareOfIntraDayTrading
    {
        get; set;
    }
    /// <summary>장후거래량</summary>
    [DataMember, JsonProperty("장후거래량")]
    public string? AfterMarketTradingVolume
    {
        get; set;
    }
    /// <summary>장후거래비중</summary>
    [DataMember, JsonProperty("장후거래비중")]
    public string? ProportionOfLongTermTransactions
    {
        get; set;
    }
    /// <summary>합계3</summary>
    [DataMember, JsonProperty("합계3")]
    public string? ATotalOfThree
    {
        get; set;
    }
    /// <summary>기간중거래량</summary>
    [DataMember, JsonProperty("기간중거래량")]
    public string? TransactionVolumeDuringThePeriod
    {
        get; set;
    }
    /// <summary>체결강도</summary>
    [DataMember, JsonProperty("체결강도")]
    public string? FasteningStrength
    {
        get; set;
    }
    /// <summary>외인보유</summary>
    [DataMember, JsonProperty("외인보유")]
    public string? ForeignOwnership
    {
        get; set;
    }
    /// <summary>외인비중</summary>
    [DataMember, JsonProperty("외인비중")]
    public string? TheProportionOfForeigners
    {
        get; set;
    }
    /// <summary>외인순매수</summary>
    [DataMember, JsonProperty("외인순매수")]
    public string? NetForeignPurchase
    {
        get; set;
    }
    /// <summary>기관순매수</summary>
    [DataMember, JsonProperty("기관순매수")]
    public string? ANetPurchaseOfAnInstitutionalPurchase
    {
        get; set;
    }
    /// <summary>개인순매수</summary>
    [DataMember, JsonProperty("개인순매수")]
    public string? IndividualNetPurchase
    {
        get; set;
    }
    /// <summary>외국계</summary>
    [DataMember, JsonProperty("외국계")]
    public string? TheForeignWorld
    {
        get; set;
    }
    /// <summary>신용잔고율</summary>
    [DataMember, JsonProperty("신용잔고율")]
    public string? CreditBalanceRatio
    {
        get; set;
    }
    /// <summary>프로그램</summary>
    [DataMember, JsonProperty("프로그램")]
    public string? Program
    {
        get; set;
    }
    /// <summary>장전거래대금</summary>
    [DataMember, JsonProperty("장전거래대금")]
    public string? BillingTransactionAmount
    {
        get; set;
    }
    /// <summary>장전거래대금비중</summary>
    [DataMember, JsonProperty("장전거래대금비중")]
    public string? ShareOfBillingTransactionPrice
    {
        get; set;
    }
    /// <summary>장중거래대금</summary>
    [DataMember, JsonProperty("장중거래대금")]
    public string? TransactionAmountDuringTheDay
    {
        get; set;
    }
    /// <summary>장중거래대금비중</summary>
    [DataMember, JsonProperty("장중거래대금비중")]
    public string? ShareOfTransactionValueDuringTheDay
    {
        get; set;
    }
    /// <summary>장후거래대금</summary>
    [DataMember, JsonProperty("장후거래대금")]
    public string? AfterTheMinuteTransaction
    {
        get; set;
    }
    /// <summary>장후거래대금비중</summary>
    [DataMember, JsonProperty("장후거래대금비중")]
    public string? ProportionOfTransactionValueAfterTheMarket
    {
        get; set;
    }
}