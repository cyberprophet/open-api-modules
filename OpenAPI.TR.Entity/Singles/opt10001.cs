using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식기본정보</summary>
public class SingleOpt10001
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public virtual string? Code
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public virtual string? Name
    {
        get; set;
    }
    /// <summary>결산월</summary>
    [DataMember, JsonProperty("결산월")]
    public virtual string? SettlementMonth
    {
        get; set;
    }
    /// <summary>액면가</summary>
    [DataMember, JsonProperty("액면가")]
    public virtual string? FaceValue
    {
        get; set;
    }
    /// <summary>자본금</summary>
    [DataMember, JsonProperty("자본금")]
    public virtual string? CapitalStock
    {
        get; set;
    }
    /// <summary>상장주식</summary>
    [DataMember, JsonProperty("상장주식")]
    public virtual string? ListedShares
    {
        get; set;
    }
    /// <summary>신용비율</summary>
    [DataMember, JsonProperty("신용비율")]
    public virtual string? CreditRatio
    {
        get; set;
    }
    /// <summary>연중최고</summary>
    [DataMember, JsonProperty("연중최고")]
    public virtual string? BestOfTheYear
    {
        get; set;
    }
    /// <summary>연중최저</summary>
    [DataMember, JsonProperty("연중최저")]
    public virtual string? LowestOfTheYear
    {
        get; set;
    }
    /// <summary>시가총액</summary>
    [DataMember, JsonProperty("시가총액")]
    public virtual string? MarketCapitalization
    {
        get; set;
    }
    /// <summary>시가총액비중</summary>
    [DataMember, JsonProperty("시가총액비중")]
    public virtual string? MarketCapitalizationRatio
    {
        get; set;
    }
    /// <summary>외인소진률</summary>
    [DataMember, JsonProperty("외인소진률")]
    public virtual string? ForeignExhaustionRate
    {
        get; set;
    }
    /// <summary>대용가</summary>
    [DataMember, JsonProperty("대용가")]
    public virtual string? SubstituteFor
    {
        get; set;
    }
    /// <summary>PER</summary>
    [DataMember, JsonProperty(nameof(PER))]
    public virtual string? PER
    {
        get; set;
    }
    /// <summary>EPS</summary>
    [DataMember, JsonProperty(nameof(EPS))]
    public virtual string? EPS
    {
        get; set;
    }
    /// <summary>ROE</summary>
    [DataMember, JsonProperty(nameof(ROE))]
    public virtual string? ROE
    {
        get; set;
    }
    /// <summary>PBR</summary>
    [DataMember, JsonProperty(nameof(PBR))]
    public virtual string? PBR
    {
        get; set;
    }
    /// <summary>EV</summary>
    [DataMember, JsonProperty(nameof(EV))]
    public virtual string? EV
    {
        get; set;
    }
    /// <summary>BPS</summary>
    [DataMember, JsonProperty(nameof(BPS))]
    public virtual string? BPS
    {
        get; set;
    }
    /// <summary>매출액</summary>
    [DataMember, JsonProperty("매출액")]
    public virtual string? Sales
    {
        get; set;
    }
    /// <summary>영업이익</summary>
    [DataMember, JsonProperty("영업이익")]
    public virtual string? OperatingProfit
    {
        get; set;
    }
    /// <summary>당기순이익</summary>
    [DataMember, JsonProperty("당기순이익")]
    public string? CurrentNetIncome
    {
        get; set;
    }
    /// <summary>250최고</summary>
    [DataMember, JsonProperty("250최고")]
    public virtual string? HighestPriceIn250Days
    {
        get; set;
    }
    /// <summary>250최저</summary>
    [DataMember, JsonProperty("250최저")]
    public virtual string? LowestPriceIn250Days
    {
        get; set;
    }
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가")]
    public virtual string? StartPrice
    {
        get; set;
    }
    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가")]
    public virtual string? HighPrice
    {
        get; set;
    }
    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가")]
    public virtual string? LowPrice
    {
        get; set;
    }
    /// <summary>상한가</summary>
    [DataMember, JsonProperty("상한가")]
    public virtual string? UpperLimitPrice
    {
        get; set;
    }
    /// <summary>하한가</summary>
    [DataMember, JsonProperty("하한가")]
    public virtual string? LowerLimitPrice
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public virtual string? StandardPrice
    {
        get; set;
    }
    /// <summary>예상체결가</summary>
    [DataMember, JsonProperty("예상체결가")]
    public virtual string? EstimatedClosingPrice
    {
        get; set;
    }
    /// <summary>예상체결수량</summary>
    [DataMember, JsonProperty("예상체결수량")]
    public virtual string? EstimatedAmountOfFastening
    {
        get; set;
    }
    /// <summary>250최고가일</summary>
    [DataMember, JsonProperty("250최고가일")]
    public virtual string? HighestPriceDay
    {
        get; set;
    }
    /// <summary>250최고가대비율</summary>
    [DataMember, JsonProperty("250최고가대비율")]
    public virtual string? HighestPriceRatio
    {
        get; set;
    }
    /// <summary>250최저가일</summary>
    [DataMember, JsonProperty("250최저가일")]
    public virtual string? LowestPriceDay
    {
        get; set;
    }
    /// <summary>250최저가대비율</summary>
    [DataMember, JsonProperty("250최저가대비율")]
    public virtual string? LowestPriceRatio
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public virtual string? PresentPrice
    {
        get; set;
    }
    /// <summary>대비기호</summary>
    [DataMember, JsonProperty("대비기호")]
    public virtual string? ContrastSymbol
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public virtual string? ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public virtual string? FluctuationRate
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public virtual string? VolumeOfTransaction
    {
        get; set;
    }
    /// <summary>거래대비</summary>
    [DataMember, JsonProperty("거래대비")]
    public virtual string? TransactionPreparation
    {
        get; set;
    }
    /// <summary>액면가단위</summary>
    [DataMember, JsonProperty("액면가단위")]
    public virtual string? UnitOfParValue
    {
        get; set;
    }
    /// <summary>유통주식</summary>
    [DataMember, JsonProperty("유통주식")]
    public virtual string? SharesInCirculation
    {
        get; set;
    }
    /// <summary>유통비율</summary>
    [DataMember, JsonProperty("유통비율")]
    public virtual string? DistributionRatio
    {
        get; set;
    }
}