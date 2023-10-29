using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>투자자별일별매매종목</summary>
public class MultiOPT10058
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
    /// <summary>순매도수량</summary>
    [DataMember, JsonProperty("순매도수량")]
    public string? NetSellingQuantity
    {
        get; set;
    }
    /// <summary>순매도금액</summary>
    [DataMember, JsonProperty("순매도금액")]
    public string? NetSellingAmount
    {
        get; set;
    }
    /// <summary>추정평균가</summary>
    [DataMember, JsonProperty("추정평균가")]
    public string? AnEstimatedAveragePrice
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
    /// <summary>평균가대비</summary>
    [DataMember, JsonProperty("평균가대비")]
    public string? TheAveragePriceRatio
    {
        get; set;
    }
    /// <summary>대비율</summary>
    [DataMember, JsonProperty("대비율")]
    public string? ContrastRatio
    {
        get; set;
    }
    /// <summary>기간거래량</summary>
    [DataMember, JsonProperty("기간거래량")]
    public string? FixedTermTransactionVolume
    {
        get; set;
    }
}