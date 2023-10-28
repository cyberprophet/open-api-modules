using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>거래원순간거래량</summary>
public class MultiOpt10052
{
    /// <summary>시간</summary>
    [DataMember, JsonProperty("시간")]
    public string? 시간
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>거래원명</summary>
    [DataMember, JsonProperty("거래원명")]
    public string? 거래원명
    {
        get; set;
    }
    /// <summary>구분</summary>
    [DataMember, JsonProperty("구분")]
    public string? 구분
    {
        get; set;
    }
    /// <summary>순간거래량</summary>
    [DataMember, JsonProperty("순간거래량")]
    public string? 순간거래량
    {
        get; set;
    }
    /// <summary>누적순매수</summary>
    [DataMember, JsonProperty("누적순매수")]
    public string? 누적순매수
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
}