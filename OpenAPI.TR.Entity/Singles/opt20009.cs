using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종현재가일별</summary>
public class SingleOpt20009
{
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
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
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금")]
    public string? TransactionPrice
    {
        get; set;
    }
    /// <summary>거래형성종목수</summary>
    [DataMember, JsonProperty("거래형성종목수")]
    public string? NumberOfTransactionFormingStocks
    {
        get; set;
    }
    /// <summary>거래형성비율</summary>
    [DataMember, JsonProperty("거래형성비율")]
    public string? TransactionFormationRatio
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
    /// <summary>상한</summary>
    [DataMember, JsonProperty("상한")]
    public string? Spoiled
    {
        get; set;
    }
    /// <summary>상승</summary>
    [DataMember, JsonProperty("상승")]
    public string? Rising
    {
        get; set;
    }
    /// <summary>보합</summary>
    [DataMember, JsonProperty("보합")]
    public string? Flat
    {
        get; set;
    }
    /// <summary>하락</summary>
    [DataMember, JsonProperty("하락")]
    public string? Falling
    {
        get; set;
    }
    /// <summary>하한</summary>
    [DataMember, JsonProperty("하한")]
    public string? LowerLimit
    {
        get; set;
    }
    /// <summary>52주최고가</summary>
    [DataMember, JsonProperty("52주최고가")]
    public string? HighPriceFor52week
    {
        get; set;
    }
    /// <summary>52주최고가일</summary>
    [DataMember, JsonProperty("52주최고가일")]
    public string? HighPriceDayFor52week
    {
        get; set;
    }
    /// <summary>52주최고가대비율</summary>
    [DataMember, JsonProperty("52주최고가대비율")]
    public string? HighPriceRatioFor52week
    {
        get; set;
    }
    /// <summary>52주최저가</summary>
    [DataMember, JsonProperty("52주최저가")]
    public string? LowPriceFor52week
    {
        get; set;
    }
    /// <summary>52주최저가일</summary>
    [DataMember, JsonProperty("52주최저가일")]
    public string? LowPriceDayFor52week
    {
        get; set;
    }
    /// <summary>52주최저가대비율</summary>
    [DataMember, JsonProperty("52주최저가대비율")]
    public string? LowPriceRatioFor52week
    {
        get; set;
    }
}