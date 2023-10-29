using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>시세표성정보</summary>
public class MultiOpt10007
{
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>날짜</summary>
    [DataMember, JsonProperty("날짜")]
    public string? Date
    {
        get; set;
    }
    /// <summary>시간</summary>
    [DataMember, JsonProperty("시간")]
    public string? Time
    {
        get; set;
    }
    /// <summary>전일종가</summary>
    [DataMember, JsonProperty("전일종가")]
    public string? TheClosingPriceOfTheDayBefore
    {
        get; set;
    }
    /// <summary>전일거래량</summary>
    [DataMember, JsonProperty("전일거래량")]
    public string? FullTimeTradingVolume
    {
        get; set;
    }
    /// <summary>상한가</summary>
    [DataMember, JsonProperty("상한가")]
    public string? TheUpperLimit
    {
        get; set;
    }
    /// <summary>하한가</summary>
    [DataMember, JsonProperty("하한가")]
    public string? ALowerPrice
    {
        get; set;
    }
    /// <summary>전일거래대금</summary>
    [DataMember, JsonProperty("전일거래대금")]
    public string? PreviousDaysTransactionAmount
    {
        get; set;
    }
    /// <summary>상장주식수</summary>
    [DataMember, JsonProperty("상장주식수")]
    public string? ListedNumberOfShares
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? ThePresentPrice
    {
        get; set;
    }
    /// <summary>부호</summary>
    [DataMember, JsonProperty("부호")]
    public string? Sign
    {
        get; set;
    }
    /// <summary>등락률</summary>
    [DataMember, JsonProperty("등락률")]
    public string? FluctuationRate
    {
        get; set;
    }
    /// <summary>전일비</summary>
    [DataMember, JsonProperty("전일비")]
    public string? FullTimeCost
    {
        get; set;
    }
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가")]
    public string? TheMarketPrice
    {
        get; set;
    }
    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가")]
    public string? AHighPrice
    {
        get; set;
    }
    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가")]
    public string? ALowPrice
    {
        get; set;
    }
    /// <summary>체결량</summary>
    [DataMember, JsonProperty("체결량")]
    public string? TheAmountOfEngagement
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
    /// <summary>예상체결가</summary>
    [DataMember, JsonProperty("예상체결가")]
    public string? AnEstimatedClosingPrice
    {
        get; set;
    }
    /// <summary>예상체결량</summary>
    [DataMember, JsonProperty("예상체결량")]
    public string? EstimatedAmountOfEngagement
    {
        get; set;
    }
    /// <summary>예상매도우선호가</summary>
    [DataMember, JsonProperty("예상매도우선호가")]
    public string? PredictedMaddowPreference
    {
        get; set;
    }
    /// <summary>예상매수우선호가</summary>
    [DataMember, JsonProperty("예상매수우선호가")]
    public string? ExpectedPurchasePreferencePrice
    {
        get; set;
    }
    /// <summary>거래시작일</summary>
    [DataMember, JsonProperty("거래시작일")]
    public string? TradingStartDate
    {
        get; set;
    }
    /// <summary>행사가격</summary>
    [DataMember, JsonProperty("행사가격")]
    public string? AStrikePrice
    {
        get; set;
    }
    /// <summary>최고가</summary>
    [DataMember, JsonProperty("최고가")]
    public string? TheMaximumPrice
    {
        get; set;
    }
    /// <summary>최저가</summary>
    [DataMember, JsonProperty("최저가")]
    public string? TheLowestPrice
    {
        get; set;
    }
    /// <summary>최고가일</summary>
    [DataMember, JsonProperty("최고가일")]
    public string? TheHighestPrice
    {
        get; set;
    }
    /// <summary>최저가일</summary>
    [DataMember, JsonProperty("최저가일")]
    public string? TheLowestPriceDay
    {
        get; set;
    }
    /// <summary>매도1호가</summary>
    [DataMember, JsonProperty("매도1호가")]
    public string? TheFirstSellingPrice
    {
        get; set;
    }
    /// <summary>매도2호가</summary>
    [DataMember, JsonProperty("매도2호가")]
    public string? SellingPrice2
    {
        get; set;
    }
    /// <summary>매도3호가</summary>
    [DataMember, JsonProperty("매도3호가")]
    public string? SellingPrice3
    {
        get; set;
    }
    /// <summary>매도4호가</summary>
    [DataMember, JsonProperty("매도4호가")]
    public string? SellingPrice4
    {
        get; set;
    }
    /// <summary>매도5호가</summary>
    [DataMember, JsonProperty("매도5호가")]
    public string? SellingPriceOf5
    {
        get; set;
    }
    /// <summary>매도6호가</summary>
    [DataMember, JsonProperty("매도6호가")]
    public string? SellingPrice6
    {
        get; set;
    }
    /// <summary>매도7호가</summary>
    [DataMember, JsonProperty("매도7호가")]
    public string? SellingPrice7
    {
        get; set;
    }
    /// <summary>매도8호가</summary>
    [DataMember, JsonProperty("매도8호가")]
    public string? SellingPrice8
    {
        get; set;
    }
    /// <summary>매도9호가</summary>
    [DataMember, JsonProperty("매도9호가")]
    public string? SellingPrice9
    {
        get; set;
    }
    /// <summary>매도10호가</summary>
    [DataMember, JsonProperty("매도10호가")]
    public string? TheSellingPriceOf10
    {
        get; set;
    }
    /// <summary>매수1호가</summary>
    [DataMember, JsonProperty("매수1호가")]
    public string? Buying1Price
    {
        get; set;
    }
    /// <summary>매수2호가</summary>
    [DataMember, JsonProperty("매수2호가")]
    public string? Buy2Price
    {
        get; set;
    }
    /// <summary>매수3호가</summary>
    [DataMember, JsonProperty("매수3호가")]
    public string? Buying3Price
    {
        get; set;
    }
    /// <summary>매수4호가</summary>
    [DataMember, JsonProperty("매수4호가")]
    public string? Buy4Price
    {
        get; set;
    }
    /// <summary>매수5호가</summary>
    [DataMember, JsonProperty("매수5호가")]
    public string? Buying5Price
    {
        get; set;
    }
    /// <summary>매수6호가</summary>
    [DataMember, JsonProperty("매수6호가")]
    public string? Buy6Price
    {
        get; set;
    }
    /// <summary>매수7호가</summary>
    [DataMember, JsonProperty("매수7호가")]
    public string? Buy7Price
    {
        get; set;
    }
    /// <summary>매수8호가</summary>
    [DataMember, JsonProperty("매수8호가")]
    public string? Buy8Price
    {
        get; set;
    }
    /// <summary>매수9호가</summary>
    [DataMember, JsonProperty("매수9호가")]
    public string? Buy9Price
    {
        get; set;
    }
    /// <summary>매수10호가</summary>
    [DataMember, JsonProperty("매수10호가")]
    public string? Buy10Price
    {
        get; set;
    }
    /// <summary>매도1호가잔량</summary>
    [DataMember, JsonProperty("매도1호가잔량")]
    public string? Sold1PriceRemainingAmount
    {
        get; set;
    }
    /// <summary>매도2호가잔량</summary>
    [DataMember, JsonProperty("매도2호가잔량")]
    public string? Sold2PriceRemainingAmount
    {
        get; set;
    }
    /// <summary>매도3호가잔량</summary>
    [DataMember, JsonProperty("매도3호가잔량")]
    public string? Sold3PriceRemainingAmount
    {
        get; set;
    }
    /// <summary>매도4호가잔량</summary>
    [DataMember, JsonProperty("매도4호가잔량")]
    public string? Sold4PriceRemainingAmount
    {
        get; set;
    }
    /// <summary>매도5호가잔량</summary>
    [DataMember, JsonProperty("매도5호가잔량")]
    public string? Sold5PriceRemainingAmount
    {
        get; set;
    }
    /// <summary>매도6호가잔량</summary>
    [DataMember, JsonProperty("매도6호가잔량")]
    public string? Sold6PriceRemainingAmount
    {
        get; set;
    }
    /// <summary>매도7호가잔량</summary>
    [DataMember, JsonProperty("매도7호가잔량")]
    public string? Sold7PriceRemainingAmount
    {
        get; set;
    }
    /// <summary>매도8호가잔량</summary>
    [DataMember, JsonProperty("매도8호가잔량")]
    public string? Sold8PriceRemainingAmount
    {
        get; set;
    }
    /// <summary>매도9호가잔량</summary>
    [DataMember, JsonProperty("매도9호가잔량")]
    public string? Sold9PriceRemainingAmount
    {
        get; set;
    }
    /// <summary>매도10호가잔량</summary>
    [DataMember, JsonProperty("매도10호가잔량")]
    public string? Sold10PriceRemainingAmount
    {
        get; set;
    }
    /// <summary>매수1호가잔량</summary>
    [DataMember, JsonProperty("매수1호가잔량")]
    public string? Number1PriceRemaining
    {
        get; set;
    }
    /// <summary>매수2호가잔량</summary>
    [DataMember, JsonProperty("매수2호가잔량")]
    public string? Number2RemainingAmount
    {
        get; set;
    }
    /// <summary>매수3호가잔량</summary>
    [DataMember, JsonProperty("매수3호가잔량")]
    public string? Buy3RemainingAmount
    {
        get; set;
    }
    /// <summary>매수4호가잔량</summary>
    [DataMember, JsonProperty("매수4호가잔량")]
    public string? Buy4PriceRemainingAmount
    {
        get; set;
    }
    /// <summary>매수5호가잔량</summary>
    [DataMember, JsonProperty("매수5호가잔량")]
    public string? Buying5PriceRemainingAmount
    {
        get; set;
    }
    /// <summary>매수6호가잔량</summary>
    [DataMember, JsonProperty("매수6호가잔량")]
    public string? Buy6PriceRemainingAmount
    {
        get; set;
    }
    /// <summary>매수7호가잔량</summary>
    [DataMember, JsonProperty("매수7호가잔량")]
    public string? Buy7HasRemainingAmount
    {
        get; set;
    }
    /// <summary>매수8호가잔량</summary>
    [DataMember, JsonProperty("매수8호가잔량")]
    public string? Buy8RemainingAmount
    {
        get; set;
    }
    /// <summary>매수9호가잔량</summary>
    [DataMember, JsonProperty("매수9호가잔량")]
    public string? Buying9RemainingAmount
    {
        get; set;
    }
    /// <summary>매수10호가잔량</summary>
    [DataMember, JsonProperty("매수10호가잔량")]
    public string? Number10RemainingAmount
    {
        get; set;
    }
    /// <summary>매도1호가직전대비</summary>
    [DataMember, JsonProperty("매도1호가직전대비")]
    public string? Selling1PriceComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매도2호가직전대비</summary>
    [DataMember, JsonProperty("매도2호가직전대비")]
    public string? Sold2PriceComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매도3호가직전대비</summary>
    [DataMember, JsonProperty("매도3호가직전대비")]
    public string? Selling3PriceComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매도4호가직전대비</summary>
    [DataMember, JsonProperty("매도4호가직전대비")]
    public string? Sold4PriceComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매도5호가직전대비</summary>
    [DataMember, JsonProperty("매도5호가직전대비")]
    public string? Sold5PriceComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매도6호가직전대비</summary>
    [DataMember, JsonProperty("매도6호가직전대비")]
    public string? Sold6PriceComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매도7호가직전대비</summary>
    [DataMember, JsonProperty("매도7호가직전대비")]
    public string? Sold7PriceComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매도8호가직전대비</summary>
    [DataMember, JsonProperty("매도8호가직전대비")]
    public string? Sold8PriceComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매도9호가직전대비</summary>
    [DataMember, JsonProperty("매도9호가직전대비")]
    public string? Sold9PriceComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매도10호가직전대비</summary>
    [DataMember, JsonProperty("매도10호가직전대비")]
    public string? Selling10PriceComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매수1호가직전대비</summary>
    [DataMember, JsonProperty("매수1호가직전대비")]
    public string? Purchase1PriceComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매수2호가직전대비</summary>
    [DataMember, JsonProperty("매수2호가직전대비")]
    public string? Buy2ComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매수3호가직전대비</summary>
    [DataMember, JsonProperty("매수3호가직전대비")]
    public string? Purchase3IsComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매수4호가직전대비</summary>
    [DataMember, JsonProperty("매수4호가직전대비")]
    public string? Buying4IsComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매수5호가직전대비</summary>
    [DataMember, JsonProperty("매수5호가직전대비")]
    public string? Purchase5PriceComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매수6호가직전대비</summary>
    [DataMember, JsonProperty("매수6호가직전대비")]
    public string? Purchase6PriceComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매수7호가직전대비</summary>
    [DataMember, JsonProperty("매수7호가직전대비")]
    public string? Purchase7IsComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매수8호가직전대비</summary>
    [DataMember, JsonProperty("매수8호가직전대비")]
    public string? Purchase8ComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매수9호가직전대비</summary>
    [DataMember, JsonProperty("매수9호가직전대비")]
    public string? Buy9ComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매수10호가직전대비</summary>
    [DataMember, JsonProperty("매수10호가직전대비")]
    public string? Purchase10PriceComparedToJustBefore
    {
        get; set;
    }
    /// <summary>매도1호가건수</summary>
    [DataMember, JsonProperty("매도1호가건수")]
    public string? _1SellingPriceNumber
    {
        get; set;
    }
    /// <summary>매도2호가건수</summary>
    [DataMember, JsonProperty("매도2호가건수")]
    public string? Sold2PriceNumber
    {
        get; set;
    }
    /// <summary>매도3호가건수</summary>
    [DataMember, JsonProperty("매도3호가건수")]
    public string? Sold3PriceNumber
    {
        get; set;
    }
    /// <summary>매도4호가건수</summary>
    [DataMember, JsonProperty("매도4호가건수")]
    public string? Sold4PriceNumber
    {
        get; set;
    }
    /// <summary>매도5호가건수</summary>
    [DataMember, JsonProperty("매도5호가건수")]
    public string? Sold5PriceNumber
    {
        get; set;
    }
    /// <summary>매수1호가건수</summary>
    [DataMember, JsonProperty("매수1호가건수")]
    public string? _1NumberOfPurchases
    {
        get; set;
    }
    /// <summary>매수2호가건수</summary>
    [DataMember, JsonProperty("매수2호가건수")]
    public string? _2NumberOfPurchases
    {
        get; set;
    }
    /// <summary>매수3호가건수</summary>
    [DataMember, JsonProperty("매수3호가건수")]
    public string? _3NumberOfPurchases
    {
        get; set;
    }
    /// <summary>매수4호가건수</summary>
    [DataMember, JsonProperty("매수4호가건수")]
    public string? _4NumberOfPurchases
    {
        get; set;
    }
    /// <summary>매수5호가건수</summary>
    [DataMember, JsonProperty("매수5호가건수")]
    public string? _5NumberOfPurchases
    {
        get; set;
    }
    /// <summary>LP매도1호가잔량</summary>
    [DataMember, JsonProperty("LP매도1호가잔량")]
    public string? LP1PriceRemainingVolume
    {
        get; set;
    }
    /// <summary>LP매도2호가잔량</summary>
    [DataMember, JsonProperty("LP매도2호가잔량")]
    public string? LP2PriceRemainingVolume
    {
        get; set;
    }
    /// <summary>LP매도3호가잔량</summary>
    [DataMember, JsonProperty("LP매도3호가잔량")]
    public string? LP3PriceRemainingVolume
    {
        get; set;
    }
    /// <summary>LP매도4호가잔량</summary>
    [DataMember, JsonProperty("LP매도4호가잔량")]
    public string? LP4PriceRemainingVolume
    {
        get; set;
    }
    /// <summary>LP매도5호가잔량</summary>
    [DataMember, JsonProperty("LP매도5호가잔량")]
    public string? LP5PriceRemainingVolume
    {
        get; set;
    }
    /// <summary>LP매도6호가잔량</summary>
    [DataMember, JsonProperty("LP매도6호가잔량")]
    public string? LP6PriceRemainingVolume
    {
        get; set;
    }
    /// <summary>LP매도7호가잔량</summary>
    [DataMember, JsonProperty("LP매도7호가잔량")]
    public string? LP7PriceRemainingCapacity
    {
        get; set;
    }
    /// <summary>LP매도8호가잔량</summary>
    [DataMember, JsonProperty("LP매도8호가잔량")]
    public string? LP8PriceRemainingCapacity
    {
        get; set;
    }
    /// <summary>LP매도9호가잔량</summary>
    [DataMember, JsonProperty("LP매도9호가잔량")]
    public string? LPSelling9PriceRemaining
    {
        get; set;
    }
    /// <summary>LP매도10호가잔량</summary>
    [DataMember, JsonProperty("LP매도10호가잔량")]
    public string? LP10PriceRemaining
    {
        get; set;
    }
    /// <summary>LP매수1호가잔량</summary>
    [DataMember, JsonProperty("LP매수1호가잔량")]
    public string? LPPurchase1PriceRemaining
    {
        get; set;
    }
    /// <summary>LP매수2호가잔량</summary>
    [DataMember, JsonProperty("LP매수2호가잔량")]
    public string? LPPurchase2PriceRemaining
    {
        get; set;
    }
    /// <summary>LP매수3호가잔량</summary>
    [DataMember, JsonProperty("LP매수3호가잔량")]
    public string? LPPurchase3PriceRemaining
    {
        get; set;
    }
    /// <summary>LP매수4호가잔량</summary>
    [DataMember, JsonProperty("LP매수4호가잔량")]
    public string? LPPurchase4PriceRemaining
    {
        get; set;
    }
    /// <summary>LP매수5호가잔량</summary>
    [DataMember, JsonProperty("LP매수5호가잔량")]
    public string? LPPurchase5PriceRemaining
    {
        get; set;
    }
    /// <summary>LP매수6호가잔량</summary>
    [DataMember, JsonProperty("LP매수6호가잔량")]
    public string? LPPurchase6PriceRemaining
    {
        get; set;
    }
    /// <summary>LP매수7호가잔량</summary>
    [DataMember, JsonProperty("LP매수7호가잔량")]
    public string? LPPurchase7RemainingVolume
    {
        get; set;
    }
    /// <summary>LP매수8호가잔량</summary>
    [DataMember, JsonProperty("LP매수8호가잔량")]
    public string? LPPurchase8RemainingVolume
    {
        get; set;
    }
    /// <summary>LP매수9호가잔량</summary>
    [DataMember, JsonProperty("LP매수9호가잔량")]
    public string? LPPurchase9RemainingVolume
    {
        get; set;
    }
    /// <summary>LP매수10호가잔량</summary>
    [DataMember, JsonProperty("LP매수10호가잔량")]
    public string? LPPurchase10PriceRemaining
    {
        get; set;
    }
    /// <summary>총매수잔량</summary>
    [DataMember, JsonProperty("총매수잔량")]
    public string? TotalPurchaseBacklog
    {
        get; set;
    }
    /// <summary>총매도잔량</summary>
    [DataMember, JsonProperty("총매도잔량")]
    public string? TotalRemainingSales
    {
        get; set;
    }
    /// <summary>총매수건수</summary>
    [DataMember, JsonProperty("총매수건수")]
    public string? TotalNumberOfPurchases
    {
        get; set;
    }
    /// <summary>총매도건수</summary>
    [DataMember, JsonProperty("총매도건수")]
    public string? TotalNumberOfSales
    {
        get; set;
    }
}