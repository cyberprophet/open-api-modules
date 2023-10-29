using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종별순매수</summary>
public class MultiOPT10051
{
    /// <summary>업종코드</summary>
    [DataMember, JsonProperty("업종코드")]
    public string? IndustryCode
    {
        get; set;
    }
    /// <summary>업종명</summary>
    [DataMember, JsonProperty("업종명")]
    public string? BusinessName
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? ThePresentPrice
    {
        get; set;
    }
    /// <summary>대비부호</summary>
    [DataMember, JsonProperty("대비부호")]
    public string? ContrastSign
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
    /// <summary>증권순매수</summary>
    [DataMember, JsonProperty("증권순매수")]
    public string? ANetPurchaseOfSecurities
    {
        get; set;
    }
    /// <summary>보험순매수</summary>
    [DataMember, JsonProperty("보험순매수")]
    public string? ANetPurchaseOfInsurance
    {
        get; set;
    }
    /// <summary>투신순매수</summary>
    [DataMember, JsonProperty("투신순매수")]
    public string? ANetInvestmentByJumpingIn
    {
        get; set;
    }
    /// <summary>은행순매수</summary>
    [DataMember, JsonProperty("은행순매수")]
    public string? ANetBankPurchase
    {
        get; set;
    }
    /// <summary>종신금순매수</summary>
    [DataMember, JsonProperty("종신금순매수")]
    public string? ANetPurchaseOfLifeGold
    {
        get; set;
    }
    /// <summary>기금순매수</summary>
    [DataMember, JsonProperty("기금순매수")]
    public string? NetPurchaseOfFunds
    {
        get; set;
    }
    /// <summary>기타법인순매수</summary>
    [DataMember, JsonProperty("기타법인순매수")]
    public string? NetPurchaseOfOtherCorporations
    {
        get; set;
    }
    /// <summary>개인순매수</summary>
    [DataMember, JsonProperty("개인순매수")]
    public string? IndividualNetPurchase
    {
        get; set;
    }
    /// <summary>외국인순매수</summary>
    [DataMember, JsonProperty("외국인순매수")]
    public string? ANetForeignPurchase
    {
        get; set;
    }
    /// <summary>내국인대우외국인순매수</summary>
    [DataMember, JsonProperty("내국인대우외국인순매수")]
    public string? NetPurchaseOfKoreanAndForeigners
    {
        get; set;
    }
    /// <summary>국가순매수</summary>
    [DataMember, JsonProperty("국가순매수")]
    public string? ANetPurchaseOfACountry
    {
        get; set;
    }
    /// <summary>사모펀드순매수</summary>
    [DataMember, JsonProperty("사모펀드순매수")]
    public string? NetPurchaseOfPrivateEquityFunds
    {
        get; set;
    }
    /// <summary>기관계순매수</summary>
    [DataMember, JsonProperty("기관계순매수")]
    public string? ANetPurchaseOfInstitutionalAccounts
    {
        get; set;
    }
}