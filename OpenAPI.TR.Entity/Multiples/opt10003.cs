using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>체결정보</summary>
public class MultiOpt10003
{
    /// <summary>시간</summary>
    [DataMember, JsonProperty("시간")]
    public string? 시간
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? 전일대비
    {
        get; set;
    }
    /// <summary>대비율</summary>
    [DataMember, JsonProperty("대비율")]
    public string? 대비율
    {
        get; set;
    }
    /// <summary>우선매도호가단위</summary>
    [DataMember, JsonProperty("우선매도호가단위")]
    public string? 우선매도호가단위
    {
        get; set;
    }
    /// <summary>우선매수호가단위</summary>
    [DataMember, JsonProperty("우선매수호가단위")]
    public string? 우선매수호가단위
    {
        get; set;
    }
    /// <summary>체결거래량</summary>
    [DataMember, JsonProperty("체결거래량")]
    public string? 체결거래량
    {
        get; set;
    }
    /// <summary>sign</summary>
    [DataMember, JsonProperty("sign")]
    public string? Sign
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? 누적거래량
    {
        get; set;
    }
    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금")]
    public string? 누적거래대금
    {
        get; set;
    }
    /// <summary>체결강도</summary>
    [DataMember, JsonProperty("체결강도")]
    public string? 체결강도
    {
        get; set;
    }
}