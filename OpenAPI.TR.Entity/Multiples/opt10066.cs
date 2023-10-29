using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>장중투자자별매매차트</summary>
public class MultiOpt10066
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
    /// <summary>등락률</summary>
    [DataMember, JsonProperty("등락률")]
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
}