using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>신용매매동향</summary>
public class MultiOpt10013
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? 일자
    {
        get; set;
    }
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
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? 거래량
    {
        get; set;
    }
    /// <summary>신규</summary>
    [DataMember, JsonProperty("신규")]
    public string? 신규
    {
        get; set;
    }
    /// <summary>상환</summary>
    [DataMember, JsonProperty("상환")]
    public string? 상환
    {
        get; set;
    }
    /// <summary>잔고</summary>
    [DataMember, JsonProperty("잔고")]
    public string? 잔고
    {
        get; set;
    }
    /// <summary>금액</summary>
    [DataMember, JsonProperty("금액")]
    public string? 금액
    {
        get; set;
    }
    /// <summary>대비</summary>
    [DataMember, JsonProperty("대비")]
    public string? 대비
    {
        get; set;
    }
    /// <summary>공여율</summary>
    [DataMember, JsonProperty("공여율")]
    public string? 공여율
    {
        get; set;
    }
    /// <summary>잔고율</summary>
    [DataMember, JsonProperty("잔고율")]
    public string? 잔고율
    {
        get; set;
    }
}