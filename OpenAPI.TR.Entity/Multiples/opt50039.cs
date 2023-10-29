using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>투자자별포지션종합</summary>
public class MultiOpt50039
{
    /// <summary>기간중주가등락</summary>
    [DataMember, JsonProperty("기간중주가등락")]
    public string? StockPricesRiseAndFallDuringThePeriod
    {
        get; set;
    }
    /// <summary>기타법인</summary>
    [DataMember, JsonProperty("기타법인")]
    public string? OtherCorporations
    {
        get; set;
    }
    /// <summary>연기금등</summary>
    [DataMember, JsonProperty("연기금등")]
    public string? PensionFundEtc
    {
        get; set;
    }
    /// <summary>기타금융</summary>
    [DataMember, JsonProperty("기타금융")]
    public string? OtherFinancing
    {
        get; set;
    }
    /// <summary>은행</summary>
    [DataMember, JsonProperty("은행")]
    public string? Bank
    {
        get; set;
    }
    /// <summary>투신</summary>
    [DataMember, JsonProperty("투신")]
    public string? JumpOutOfOneWay
    {
        get; set;
    }
    /// <summary>보험</summary>
    [DataMember, JsonProperty("보험")]
    public string? Insurance
    {
        get; set;
    }
    /// <summary>금융투자</summary>
    [DataMember, JsonProperty("금융투자")]
    public string? FinancialInvestment
    {
        get; set;
    }
    /// <summary>외국인</summary>
    [DataMember, JsonProperty("외국인")]
    public string? Foreigner
    {
        get; set;
    }
    /// <summary>개인</summary>
    [DataMember, JsonProperty("개인")]
    public string? Individual
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? AccumulatedTradingVolume
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
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
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
    /// <summary>대칭구분</summary>
    [DataMember, JsonProperty("대칭구분")]
    public string? SymmetricClassification
    {
        get; set;
    }
    /// <summary>풋_종목코드</summary>
    [DataMember, JsonProperty("풋_종목코드")]
    public string? FootCode
    {
        get; set;
    }
    /// <summary>풋_현재가</summary>
    [DataMember, JsonProperty("풋_현재가")]
    public string? FootPresentPrice
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
    /// <summary>풋_전일대비</summary>
    [DataMember, JsonProperty("풋_전일대비")]
    public string? FootDayToDay
    {
        get; set;
    }
    /// <summary>풋_미결제약정</summary>
    [DataMember, JsonProperty("풋_미결제약정")]
    public string? FootOutstandingAgreement
    {
        get; set;
    }
    /// <summary>풋_미결제약정전일대비</summary>
    [DataMember, JsonProperty("풋_미결제약정전일대비")]
    public string? FootOutstandingAgreementComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>풋_누적거래량</summary>
    [DataMember, JsonProperty("풋_누적거래량")]
    public string? FootCumulativeTradingVolume
    {
        get; set;
    }
    /// <summary>풋_ATM구분</summary>
    [DataMember, JsonProperty("풋_ATM구분")]
    public string? FootATMClassification
    {
        get; set;
    }
    /// <summary>풋_개인</summary>
    [DataMember, JsonProperty("풋_개인")]
    public string? FootIndividual
    {
        get; set;
    }
    /// <summary>풋_외국인</summary>
    [DataMember, JsonProperty("풋_외국인")]
    public string? FootForeigner
    {
        get; set;
    }
    /// <summary>풋_금융투자</summary>
    [DataMember, JsonProperty("풋_금융투자")]
    public string? PutFinancialInvestment
    {
        get; set;
    }
    /// <summary>풋_보험</summary>
    [DataMember, JsonProperty("풋_보험")]
    public string? FootInsurance
    {
        get; set;
    }
    /// <summary>풋_투신</summary>
    [DataMember, JsonProperty("풋_투신")]
    public string? FootToothpins
    {
        get; set;
    }
    /// <summary>풋_은행</summary>
    [DataMember, JsonProperty("풋_은행")]
    public string? FootBank
    {
        get; set;
    }
    /// <summary>풋_기타금융</summary>
    [DataMember, JsonProperty("풋_기타금융")]
    public string? FootOtherFinancing
    {
        get; set;
    }
    /// <summary>풋_연기금등</summary>
    [DataMember, JsonProperty("풋_연기금등")]
    public string? FootPensionFundsEtc
    {
        get; set;
    }
    /// <summary>풋_기타법인</summary>
    [DataMember, JsonProperty("풋_기타법인")]
    public string? FootOtherCorporations
    {
        get; set;
    }
    /// <summary>풋_기간중주가등락</summary>
    [DataMember, JsonProperty("풋_기간중주가등락")]
    public string? FootPeriodStockPricesRiseAndFall
    {
        get; set;
    }
}