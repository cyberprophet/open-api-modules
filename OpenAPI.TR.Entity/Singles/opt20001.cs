using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종현재가</summary>
public class SingleOpt20001
{
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>전일대비기호</summary>
    [DataMember, JsonProperty("전일대비기호")]
    public string? 전일대비기호
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? 전일대비
    {
        get; set;
    }
    /// <summary>등락률</summary>
    [DataMember, JsonProperty("등락률")]
    public string? 등락률
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? 거래량
    {
        get; set;
    }
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금")]
    public string? 거래대금
    {
        get; set;
    }
    /// <summary>거래형성종목수</summary>
    [DataMember, JsonProperty("거래형성종목수")]
    public string? 거래형성종목수
    {
        get; set;
    }
    /// <summary>거래형성비율</summary>
    [DataMember, JsonProperty("거래형성비율")]
    public string? 거래형성비율
    {
        get; set;
    }
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가")]
    public string? 시가
    {
        get; set;
    }
    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가")]
    public string? 고가
    {
        get; set;
    }
    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가")]
    public string? 저가
    {
        get; set;
    }
    /// <summary>상한</summary>
    [DataMember, JsonProperty("상한")]
    public string? 상한
    {
        get; set;
    }
    /// <summary>상승</summary>
    [DataMember, JsonProperty("상승")]
    public string? 상승
    {
        get; set;
    }
    /// <summary>보합</summary>
    [DataMember, JsonProperty("보합")]
    public string? 보합
    {
        get; set;
    }
    /// <summary>하락</summary>
    [DataMember, JsonProperty("하락")]
    public string? 하락
    {
        get; set;
    }
    /// <summary>하한</summary>
    [DataMember, JsonProperty("하한")]
    public string? 하한
    {
        get; set;
    }
    /// <summary>52주최고가</summary>
    [DataMember, JsonProperty("52주최고가")]
    public string? 주최고가
    {
        get; set;
    }
    /// <summary>52주최고가일</summary>
    [DataMember, JsonProperty("52주최고가일")]
    public string? 주최고가일
    {
        get; set;
    }
    /// <summary>52주최고가대비율</summary>
    [DataMember, JsonProperty("52주최고가대비율")]
    public string? 주최고가대비율
    {
        get;
        set;
    }
    /// <summary>52주최저가</summary>
    [DataMember, JsonProperty("52주최저가")]
    public string? 주최저가
    {
        get;
        set;
    }
    /// <summary>52주최저가일</summary>
    [DataMember, JsonProperty("52주최저가일")]
    public string? 주최저가일
    {
        get;
        set;
    }
    /// <summary>52주최저가대비율</summary>
    [DataMember, JsonProperty("52주최저가대비율")]
    public string? 주최저가대비율
    {
        get;
        set;
    }
}