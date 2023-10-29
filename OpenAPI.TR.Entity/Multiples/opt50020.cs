using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>복수종목결제월별시세</summary>
public class MultiOpt50020
{
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
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? FluctuationRate
    {
        get; set;
    }
    /// <summary>대비기호</summary>
    [DataMember, JsonProperty("대비기호")]
    public string? ContrastSymbol
    {
        get; set;
    }
    /// <summary>시간가치</summary>
    [DataMember, JsonProperty("시간가치")]
    public string? TimeValue
    {
        get; set;
    }
    /// <summary>내재가치</summary>
    [DataMember, JsonProperty("내재가치")]
    public string? IntrinsicValue
    {
        get; set;
    }
    /// <summary>내재변동성</summary>
    [DataMember, JsonProperty("내재변동성")]
    public string? IntrinsicVolatility
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
    /// <summary>미결제약정전일대비</summary>
    [DataMember, JsonProperty("미결제약정전일대비")]
    public string? ComparedToThePreviousDayOfTheOutstandingPayment
    {
        get; set;
    }
    /// <summary>미결제약정</summary>
    [DataMember, JsonProperty("미결제약정")]
    public string? OpenInterest
    {
        get; set;
    }
    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금")]
    public string? AccumulatedTransactionAmount
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? AccumulatedTradingVolume
    {
        get; set;
    }
    /// <summary>매수호가총잔량</summary>
    [DataMember, JsonProperty("매수호가총잔량")]
    public string? TotalRemainingAmountOfTheBuyerAskingPrice
    {
        get; set;
    }
    /// <summary>매도호가총잔량</summary>
    [DataMember, JsonProperty("매도호가총잔량")]
    public string? TotalBacklogOfSellingPrices
    {
        get; set;
    }
    /// <summary>매수호가수량</summary>
    [DataMember, JsonProperty("매수호가수량")]
    public string? PurchasePriceQuantity
    {
        get; set;
    }
    /// <summary>매수호가</summary>
    [DataMember, JsonProperty("매수호가")]
    public string? BuyInPrice
    {
        get; set;
    }
    /// <summary>매도호가수량</summary>
    [DataMember, JsonProperty("매도호가수량")]
    public string? NumberOfSellingCallPrices
    {
        get; set;
    }
    /// <summary>매도호가</summary>
    [DataMember, JsonProperty("매도호가")]
    public string? SellingPrice
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public string? StandardPrice
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
    /// <summary>기준가대비시가등락율</summary>
    [DataMember, JsonProperty("기준가대비시가등락율")]
    public string? MarketPriceFluctuationRateComparedToBasePrice
    {
        get; set;
    }
    /// <summary>기준가대비고가등락율</summary>
    [DataMember, JsonProperty("기준가대비고가등락율")]
    public string? HighPriceFluctuationRateComparedToBasePrice
    {
        get; set;
    }
    /// <summary>기준가대비저가등락율</summary>
    [DataMember, JsonProperty("기준가대비저가등락율")]
    public string? LowPriceFluctuationRateComparedToBasePrice
    {
        get; set;
    }
    /// <summary>지수환산</summary>
    [DataMember, JsonProperty("지수환산")]
    public string? ExponentialConversion
    {
        get; set;
    }
    /// <summary>예상체결가전일종가대비등락율</summary>
    [DataMember, JsonProperty("예상체결가전일종가대비등락율")]
    public string? ExpectedRateOfFluctuationComparedToExpectedClosingPriceOfHomeAppliances
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
    /// <summary>예상체결가</summary>
    [DataMember, JsonProperty("예상체결가")]
    public string? EstimatedClosingPrice
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>ATM구분</summary>
    [DataMember, JsonProperty("ATM구분")]
    public string? ATMClassification
    {
        get; set;
    }
    /// <summary>행사가</summary>
    [DataMember, JsonProperty("행사가")]
    public string? Eventist
    {
        get; set;
    }
    /// <summary>대칭구분</summary>
    [DataMember, JsonProperty("대칭구분")]
    public string? SymmetricClassification
    {
        get; set;
    }
    /// <summary>풋_현재가</summary>
    [DataMember, JsonProperty("풋_현재가")]
    public string? ThePresent
    {
        get; set;
    }
    /// <summary>풋_전일대비</summary>
    [DataMember, JsonProperty("풋_전일대비")]
    public string? FootDayToDay
    {
        get; set;
    }
    /// <summary>풋_등락율</summary>
    [DataMember, JsonProperty("풋_등락율")]
    public string? FootIncreaseRate
    {
        get; set;
    }
    /// <summary>풋_대비기호</summary>
    [DataMember, JsonProperty("풋_대비기호")]
    public string? FootContrastSymbol
    {
        get; set;
    }
    /// <summary>풋_시간가치</summary>
    [DataMember, JsonProperty("풋_시간가치")]
    public string? FootTimeValue
    {
        get; set;
    }
    /// <summary>풋_내재가치</summary>
    [DataMember, JsonProperty("풋_내재가치")]
    public string? FootInternalValue
    {
        get; set;
    }
    /// <summary>풋_내재변동성</summary>
    [DataMember, JsonProperty("풋_내재변동성")]
    public string? FootInternalVolatility
    {
        get; set;
    }
    /// <summary>풋_이론가</summary>
    [DataMember, JsonProperty("풋_이론가")]
    public string? FootTheorist
    {
        get; set;
    }
    /// <summary>풋_괴리율</summary>
    [DataMember, JsonProperty("풋_괴리율")]
    public string? FootDistancingRate
    {
        get; set;
    }
    /// <summary>풋_미결제약정전일대비</summary>
    [DataMember, JsonProperty("풋_미결제약정전일대비")]
    public string? FootOutstandingAgreementComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>풋_미결제약정</summary>
    [DataMember, JsonProperty("풋_미결제약정")]
    public string? FootOutstandingAgreement
    {
        get; set;
    }
    /// <summary>풋_누적거래대금</summary>
    [DataMember, JsonProperty("풋_누적거래대금")]
    public string? FootAccumulatedTransactionAmount
    {
        get; set;
    }
    /// <summary>풋_누적거래량</summary>
    [DataMember, JsonProperty("풋_누적거래량")]
    public string? FootCumulativeTradingVolume
    {
        get; set;
    }
    /// <summary>풋_매수호가총잔량</summary>
    [DataMember, JsonProperty("풋_매수호가총잔량")]
    public string? FootTotalAskingPriceRemaining
    {
        get; set;
    }
    /// <summary>풋_매도호가총잔량</summary>
    [DataMember, JsonProperty("풋_매도호가총잔량")]
    public string? FootSellTotalRemainingAmount
    {
        get; set;
    }
    /// <summary>풋_매수호가수량</summary>
    [DataMember, JsonProperty("풋_매수호가수량")]
    public string? FootBuyableAskingPrice
    {
        get; set;
    }
    /// <summary>풋_매수호가</summary>
    [DataMember, JsonProperty("풋_매수호가")]
    public string? GreenAskingPrice
    {
        get; set;
    }
    /// <summary>풋_매도호가수량</summary>
    [DataMember, JsonProperty("풋_매도호가수량")]
    public string? FootSellToValueQuantity
    {
        get; set;
    }
    /// <summary>풋_매도호가</summary>
    [DataMember, JsonProperty("풋_매도호가")]
    public string? SellingPriceOfSellingPrice
    {
        get; set;
    }
    /// <summary>풋_기준가</summary>
    [DataMember, JsonProperty("풋_기준가")]
    public string? FootBasicPrice
    {
        get; set;
    }
    /// <summary>풋_시가</summary>
    [DataMember, JsonProperty("풋_시가")]
    public string? FootStartPrice
    {
        get; set;
    }
    /// <summary>풋_고가</summary>
    [DataMember, JsonProperty("풋_고가")]
    public string? FootHighPrice
    {
        get; set;
    }
    /// <summary>풋_저가</summary>
    [DataMember, JsonProperty("풋_저가")]
    public string? FootLowPrice
    {
        get; set;
    }
    /// <summary>풋_기준가대비시가등락율</summary>
    [DataMember, JsonProperty("풋_기준가대비시가등락율")]
    public string? FootMarketPriceFluctuationRateComparedToBasePrice
    {
        get; set;
    }
    /// <summary>풋_기준가대비고가등락율</summary>
    [DataMember, JsonProperty("풋_기준가대비고가등락율")]
    public string? FootHighPriceFluctuationRateComparedToBasePrice
    {
        get; set;
    }
    /// <summary>풋_기준가대비저가등락율</summary>
    [DataMember, JsonProperty("풋_기준가대비저가등락율")]
    public string? FootLowPriceFluctuationRateComparedToBasePrice
    {
        get; set;
    }
    /// <summary>풋_지수환산</summary>
    [DataMember, JsonProperty("풋_지수환산")]
    public string? FootIndexConversion
    {
        get; set;
    }
    /// <summary>풋_예상체결가전일종가대비등락율</summary>
    [DataMember, JsonProperty("풋_예상체결가전일종가대비등락율")]
    public string? FootExpectedClosingRatioOfHomeApplianceDayPrice
    {
        get; set;
    }
    /// <summary>풋_예상체결가전일종가대비기호</summary>
    [DataMember, JsonProperty("풋_예상체결가전일종가대비기호")]
    public string? FootExpectedClosingPriceComparisonSymbol
    {
        get; set;
    }
    /// <summary>풋_예상체결가전일종가대비</summary>
    [DataMember, JsonProperty("풋_예상체결가전일종가대비")]
    public string? FootExpectedClosingPriceOfHomeAppliances
    {
        get; set;
    }
    /// <summary>풋_예상체결가</summary>
    [DataMember, JsonProperty("풋_예상체결가")]
    public string? FootExpectedContractPrice
    {
        get; set;
    }
    /// <summary>풋_종목코드</summary>
    [DataMember, JsonProperty("풋_종목코드")]
    public string? FootCode
    {
        get; set;
    }
    /// <summary>풋_ATM구분</summary>
    [DataMember, JsonProperty("풋_ATM구분")]
    public string? FootATMClassification
    {
        get; set;
    }
    /// <summary>풋_행사가</summary>
    [DataMember, JsonProperty("풋_행사가")]
    public string? FootEventPrice
    {
        get; set;
    }
}