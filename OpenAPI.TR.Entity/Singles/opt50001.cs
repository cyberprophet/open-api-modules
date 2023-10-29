using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵현재가정보</summary>
public class SingleOpt50001
{
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>대비기호</summary>
    [DataMember, JsonProperty("대비기호")]
    public string? ContrastSymbol
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
    /// <summary>거래량대비</summary>
    [DataMember, JsonProperty("거래량대비")]
    public string? TransactionVolumeVersus
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public string? StandardPrice
    {
        get; set;
    }
    /// <summary>이론가</summary>
    [DataMember, JsonProperty("이론가")]
    public string? Theorist
    {
        get; set;
    }
    /// <summary>이론베이시스</summary>
    [DataMember, JsonProperty("이론베이시스")]
    public string? TheoreticalBasis
    {
        get; set;
    }
    /// <summary>괴리도</summary>
    [DataMember, JsonProperty("괴리도")]
    public string? DisparateDiagram
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
    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금")]
    public string? AccumulatedTransactionAmount
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
    /// <summary>CB상한가</summary>
    [DataMember, JsonProperty("CB상한가")]
    public string? CBUpperLimit
    {
        get; set;
    }
    /// <summary>CB하한가</summary>
    [DataMember, JsonProperty("CB하한가")]
    public string? HowMuchIsTheWeekBefore
    {
        get; set;
    }
    /// <summary>대용가</summary>
    [DataMember, JsonProperty("대용가")]
    public string? SubstituteFor
    {
        get; set;
    }
    /// <summary>최종거래일</summary>
    [DataMember, JsonProperty("최종거래일")]
    public string? FinalTransactionDate
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
    /// <summary>상장중최고가</summary>
    [DataMember, JsonProperty("상장중최고가")]
    public string? HighestPriceOfACertificate
    {
        get; set;
    }
    /// <summary>상장중최고가대비율</summary>
    [DataMember, JsonProperty("상장중최고가대비율")]
    public string? HighestPriceRatioDuringListing
    {
        get; set;
    }
    /// <summary>상장중최고가일</summary>
    [DataMember, JsonProperty("상장중최고가일")]
    public string? ListedHighestPriceDay
    {
        get; set;
    }
    /// <summary>상장중최저가</summary>
    [DataMember, JsonProperty("상장중최저가")]
    public string? LowestPriceOfAListing
    {
        get; set;
    }
    /// <summary>상장중최저가대비율</summary>
    [DataMember, JsonProperty("상장중최저가대비율")]
    public string? LowestPriceRatioAmongListings
    {
        get; set;
    }
    /// <summary>상장중최저가일</summary>
    [DataMember, JsonProperty("상장중최저가일")]
    public string? LowestPriceDateOfListing
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>호가시간</summary>
    [DataMember, JsonProperty("호가시간")]
    public string? AskingTime
    {
        get; set;
    }
    /// <summary>매도수익율5</summary>
    [DataMember, JsonProperty("매도수익율5")]
    public string? ReturnOnSale5
    {
        get; set;
    }
    /// <summary>매도건수5</summary>
    [DataMember, JsonProperty("매도건수5")]
    public string? NumberOfSales5
    {
        get; set;
    }
    /// <summary>매도수량5</summary>
    [DataMember, JsonProperty("매도수량5")]
    public string? SalesVolume5
    {
        get; set;
    }
    /// <summary>매도수익율4</summary>
    [DataMember, JsonProperty("매도수익율4")]
    public string? ReturnOnSale4
    {
        get; set;
    }
    /// <summary>매도건수4</summary>
    [DataMember, JsonProperty("매도건수4")]
    public string? NumberOfSales4
    {
        get; set;
    }
    /// <summary>매도수량4</summary>
    [DataMember, JsonProperty("매도수량4")]
    public string? SalesVolume4
    {
        get; set;
    }
    /// <summary>매도호가4</summary>
    [DataMember, JsonProperty("매도호가4")]
    public string? SellingPrice4
    {
        get; set;
    }
    /// <summary>매도호가5</summary>
    [DataMember, JsonProperty("매도호가5")]
    public string? SellingPrice5
    {
        get; set;
    }
    /// <summary>매도수익율3</summary>
    [DataMember, JsonProperty("매도수익율3")]
    public string? ReturnOnSale3
    {
        get; set;
    }
    /// <summary>매도건수3</summary>
    [DataMember, JsonProperty("매도건수3")]
    public string? NumberOfSales3
    {
        get; set;
    }
    /// <summary>매도수량3</summary>
    [DataMember, JsonProperty("매도수량3")]
    public string? SalesVolume3
    {
        get; set;
    }
    /// <summary>매도호가3</summary>
    [DataMember, JsonProperty("매도호가3")]
    public string? SellingPrice3
    {
        get; set;
    }
    /// <summary>매도수익율2</summary>
    [DataMember, JsonProperty("매도수익율2")]
    public string? ReturnOnSale2
    {
        get; set;
    }
    /// <summary>매도건수2</summary>
    [DataMember, JsonProperty("매도건수2")]
    public string? NumberOfSales2
    {
        get; set;
    }
    /// <summary>매도수량2</summary>
    [DataMember, JsonProperty("매도수량2")]
    public string? SalesVolume2
    {
        get; set;
    }
    /// <summary>매도호가2</summary>
    [DataMember, JsonProperty("매도호가2")]
    public string? SellingPrice2
    {
        get; set;
    }
    /// <summary>매도수익율1</summary>
    [DataMember, JsonProperty("매도수익율1")]
    public string? ReturnOnSale1
    {
        get; set;
    }
    /// <summary>매도건수1</summary>
    [DataMember, JsonProperty("매도건수1")]
    public string? NumberOfSales1
    {
        get; set;
    }
    /// <summary>매도수량1</summary>
    [DataMember, JsonProperty("매도수량1")]
    public string? SalesVolume1
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
    /// <summary>매수수량1</summary>
    [DataMember, JsonProperty("매수수량1")]
    public string? PurchaseQuantity1
    {
        get; set;
    }
    /// <summary>매수건수1</summary>
    [DataMember, JsonProperty("매수건수1")]
    public string? NumberOfPurchases1
    {
        get; set;
    }
    /// <summary>매수수익율1</summary>
    [DataMember, JsonProperty("매수수익율1")]
    public string? ReturnOnPurchase1
    {
        get; set;
    }
    /// <summary>매수호가2</summary>
    [DataMember, JsonProperty("매수호가2")]
    public string? BuyingPrice2
    {
        get; set;
    }
    /// <summary>매수수량2</summary>
    [DataMember, JsonProperty("매수수량2")]
    public string? PurchaseQuantity2
    {
        get; set;
    }
    /// <summary>매수건수2</summary>
    [DataMember, JsonProperty("매수건수2")]
    public string? NumberOfPurchases2
    {
        get; set;
    }
    /// <summary>매수수익율2</summary>
    [DataMember, JsonProperty("매수수익율2")]
    public string? ReturnOnPurchase2
    {
        get; set;
    }
    /// <summary>매수호가3</summary>
    [DataMember, JsonProperty("매수호가3")]
    public string? BuyingPrice3
    {
        get; set;
    }
    /// <summary>매수수량3</summary>
    [DataMember, JsonProperty("매수수량3")]
    public string? PurchaseQuantity3
    {
        get; set;
    }
    /// <summary>매수건수3</summary>
    [DataMember, JsonProperty("매수건수3")]
    public string? NumberOfPurchases3
    {
        get; set;
    }
    /// <summary>매수수익율3</summary>
    [DataMember, JsonProperty("매수수익율3")]
    public string? ReturnOnPurchase3
    {
        get; set;
    }
    /// <summary>매수호가4</summary>
    [DataMember, JsonProperty("매수호가4")]
    public string? BuyInPrice4
    {
        get; set;
    }
    /// <summary>매수수량4</summary>
    [DataMember, JsonProperty("매수수량4")]
    public string? PurchaseQuantity4
    {
        get; set;
    }
    /// <summary>매수건수4</summary>
    [DataMember, JsonProperty("매수건수4")]
    public string? NumberOfPurchases4
    {
        get; set;
    }
    /// <summary>매수수익율4</summary>
    [DataMember, JsonProperty("매수수익율4")]
    public string? ReturnOnPurchase4
    {
        get; set;
    }
    /// <summary>매수호가5</summary>
    [DataMember, JsonProperty("매수호가5")]
    public string? BuyingPrice5
    {
        get; set;
    }
    /// <summary>매수수량5</summary>
    [DataMember, JsonProperty("매수수량5")]
    public string? PurchaseQuantity5
    {
        get; set;
    }
    /// <summary>매수건수5</summary>
    [DataMember, JsonProperty("매수건수5")]
    public string? NumberOfPurchases5
    {
        get; set;
    }
    /// <summary>매수수익율5</summary>
    [DataMember, JsonProperty("매수수익율5")]
    public string? PurchaseYield5
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
    /// <summary>2차저항</summary>
    [DataMember, JsonProperty("2차저항")]
    public string? SecondaryResistance
    {
        get; set;
    }
    /// <summary>1차저항</summary>
    [DataMember, JsonProperty("1차저항")]
    public string? PrimaryResistance
    {
        get; set;
    }
    /// <summary>피봇</summary>
    [DataMember, JsonProperty("피봇")]
    public string? Pivot
    {
        get; set;
    }
    /// <summary>1차저지</summary>
    [DataMember, JsonProperty("1차저지")]
    public string? FirstBlock
    {
        get; set;
    }
    /// <summary>2차저지</summary>
    [DataMember, JsonProperty("2차저지")]
    public string? SecondRoundOfStops
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
    /// <summary>매도호가총건수</summary>
    [DataMember, JsonProperty("매도호가총건수")]
    public string? TotalNumberOfSellingCalls
    {
        get; set;
    }
    /// <summary>매도호가총잔량</summary>
    [DataMember, JsonProperty("매도호가총잔량")]
    public string? TotalBacklogOfSellingPrices
    {
        get; set;
    }
    /// <summary>순매수잔량</summary>
    [DataMember, JsonProperty("순매수잔량")]
    public string? NetBuyRemaining
    {
        get; set;
    }
    /// <summary>매수호가총잔량</summary>
    [DataMember, JsonProperty("매수호가총잔량")]
    public string? TotalRemainingAmountOfTheBuyerAskingPrice
    {
        get; set;
    }
    /// <summary>매수호가총건수</summary>
    [DataMember, JsonProperty("매수호가총건수")]
    public string? TotalNumberOfPurchaseCalls
    {
        get; set;
    }
    /// <summary>매도호가총잔량직전대비</summary>
    [DataMember, JsonProperty("매도호가총잔량직전대비")]
    public string? SellingPriceComparedToTotalRemainingVolumeJustBefore
    {
        get; set;
    }
    /// <summary>매수호가총잔량직전대비</summary>
    [DataMember, JsonProperty("매수호가총잔량직전대비")]
    public string? BuyingPriceComparedToTotalRemainingVolumeJustBefore
    {
        get; set;
    }
    /// <summary>예상체결가</summary>
    [DataMember, JsonProperty("예상체결가")]
    public string? EstimatedClosingPrice
    {
        get; set;
    }
    /// <summary>예상체결가전일종가대비기호</summary>
    [DataMember, JsonProperty("예상체결가전일종가대비기호")]
    public string? ExpectedClosingPriceOfHomeAppliances
    {
        get; set;
    }
    /// <summary>예상체결가전일종가대비</summary>
    [DataMember, JsonProperty("예상체결가전일종가대비")]
    public string? EstimatedClosingPriceComparedToExpectedClosingPrice
    {
        get; set;
    }
    /// <summary>예상체결가전일종가대비등락율</summary>
    [DataMember, JsonProperty("예상체결가전일종가대비등락율")]
    public string? ExpectedRateOfFluctuationComparedToExpectedClosingPriceOfHomeAppliances
    {
        get; set;
    }
    /// <summary>이자율</summary>
    [DataMember, JsonProperty("이자율")]
    public string? InterestRate
    {
        get; set;
    }
}