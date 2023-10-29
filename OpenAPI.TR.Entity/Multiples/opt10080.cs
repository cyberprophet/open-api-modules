using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식분봉차트조회</summary>
public class MultiOpt10080
{
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? VolumeOfTransaction
    {
        get; set;
    }
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? ConcludingTime
    {
        get; set;
    }
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가")]
    public string? MarketPrice
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
    /// <summary>수정주가구분</summary>
    [DataMember, JsonProperty("수정주가구분")]
    public string? ModifiedStockPriceClassification
    {
        get; set;
    }
    /// <summary>수정비율</summary>
    [DataMember, JsonProperty("수정비율")]
    public string? CorrectionRate
    {
        get; set;
    }
    /// <summary>대업종구분</summary>
    [DataMember, JsonProperty("대업종구분")]
    public string? LargeIndustryClassification
    {
        get; set;
    }
    /// <summary>소업종구분</summary>
    [DataMember, JsonProperty("소업종구분")]
    public string? SmallBusinessClassification
    {
        get; set;
    }
    /// <summary>종목정보</summary>
    [DataMember, JsonProperty("종목정보")]
    public string? ItemInformation
    {
        get; set;
    }
    /// <summary>수정주가이벤트</summary>
    [DataMember, JsonProperty("수정주가이벤트")]
    public string? RevisedStockPriceEvent
    {
        get; set;
    }
    /// <summary>전일종가</summary>
    [DataMember, JsonProperty("전일종가")]
    public string? TheClosingPriceOfTheDayBefore
    {
        get; set;
    }
}