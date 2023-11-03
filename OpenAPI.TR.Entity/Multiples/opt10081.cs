using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식일봉차트조회</summary>
public class MultiOpt10081
{
    [NotMapped]
    public string? Name
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드"), StringLength(6), Key]
    public string? Code
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가"), StringLength(0x10), Required]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량"), StringLength(0x10), Required]
    public string? VolumeOfTransaction
    {
        get; set;
    }
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금"), StringLength(0x10)]
    public string? TransactionAmount
    {
        get; set;
    }
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자"), StringLength(8), Key]
    public string? Date
    {
        get; set;
    }
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가"), StringLength(0x10), Required]
    public string? StartPrice
    {
        get; set;
    }
    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가"), StringLength(0x10), Required]
    public string? HighPrice
    {
        get; set;
    }
    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가"), StringLength(0x10), Required]
    public string? LowPrice
    {
        get; set;
    }
    /// <summary>수정주가구분</summary>
    [DataMember, JsonProperty("수정주가구분"), StringLength(0x10)]
    public string? ModifiedStockPriceClassification
    {
        get; set;
    }
    /// <summary>수정비율</summary>
    [DataMember, JsonProperty("수정비율"), StringLength(0x10)]
    public string? CorrectionRate
    {
        get; set;
    }
    /// <summary>대업종구분</summary>
    [DataMember, JsonProperty("대업종구분"), StringLength(0x10)]
    public string? LargeIndustryClassification
    {
        get; set;
    }
    /// <summary>소업종구분</summary>
    [DataMember, JsonProperty("소업종구분"), StringLength(0x10)]
    public string? SmallIndustryClassification
    {
        get; set;
    }
    /// <summary>종목정보</summary>
    [DataMember, JsonProperty("종목정보"), StringLength(0x10)]
    public string? StockInformation
    {
        get; set;
    }
    /// <summary>수정주가이벤트</summary>
    [DataMember, JsonProperty("수정주가이벤트"), StringLength(0x10)]
    public string? RevisedStockPriceEvent
    {
        get; set;
    }
    /// <summary>전일종가</summary>
    [DataMember, JsonProperty("전일종가"), StringLength(0x10)]
    public string? ClosingPriceOfTheDayBefore
    {
        get; set;
    }
}