using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별투자자기관별</summary>
public class MultiOpt10059
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? ThePresentPrice
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
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? AccumulatedTradingVolume
    {
        get; set;
    }
    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금")]
    public string? AccumulatedTransactionAmount
    {
        get; set;
    }
    /// <summary>개인투자자</summary>
    [DataMember, JsonProperty("개인투자자")]
    public string? AnIndividualInvestor
    {
        get; set;
    }
    /// <summary>외국인투자자</summary>
    [DataMember, JsonProperty("외국인투자자")]
    public string? AForeignInvestor
    {
        get; set;
    }
    /// <summary>기관계</summary>
    [DataMember, JsonProperty("기관계")]
    public string? TheEngineSystem
    {
        get; set;
    }
    /// <summary>금융투자</summary>
    [DataMember, JsonProperty("금융투자")]
    public string? FinancialInvestment
    {
        get; set;
    }
    /// <summary>보험</summary>
    [DataMember, JsonProperty("보험")]
    public string? Insurance
    {
        get; set;
    }
    /// <summary>투신</summary>
    [DataMember, JsonProperty("투신")]
    public string? JumpOutOfOnesWay
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
    /// <summary>연기금등</summary>
    [DataMember, JsonProperty("연기금등")]
    public string? PensionFundEtc
    {
        get; set;
    }
    /// <summary>사모펀드</summary>
    [DataMember, JsonProperty("사모펀드")]
    public string? APrivateEquityFund
    {
        get; set;
    }
    /// <summary>국가</summary>
    [DataMember, JsonProperty("국가")]
    public string? Nation
    {
        get; set;
    }
    /// <summary>기타법인</summary>
    [DataMember, JsonProperty("기타법인")]
    public string? OtherCorporations
    {
        get; set;
    }
    /// <summary>내외국인</summary>
    [DataMember, JsonProperty("내외국인")]
    public string? KoreanAndForeignNationals
    {
        get; set;
    }
}