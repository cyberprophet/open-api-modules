using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>프로그램매매추이</summary>
public class MultiOpt10001
{
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? 체결시간
    {
        get; set;
    }
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? 일자
    {
        get; set;
    }
    /// <summary>차익거래매도</summary>
    [DataMember, JsonProperty("차익거래매도")]
    public string? 차익거래매도
    {
        get; set;
    }
    /// <summary>차익거래매수</summary>
    [DataMember, JsonProperty("차익거래매수")]
    public string? 차익거래매수
    {
        get; set;
    }
    /// <summary>차익거래순매수</summary>
    [DataMember, JsonProperty("차익거래순매수")]
    public string? 차익거래순매수
    {
        get; set;
    }
    /// <summary>비차익거래매도</summary>
    [DataMember, JsonProperty("비차익거래매도")]
    public string? 비차익거래매도
    {
        get; set;
    }
    /// <summary>비차익거래매수</summary>
    [DataMember, JsonProperty("비차익거래매수")]
    public string? 비차익거래매수
    {
        get; set;
    }
    /// <summary>비차익거래순매수</summary>
    [DataMember, JsonProperty("비차익거래순매수")]
    public string? 비차익거래순매수
    {
        get; set;
    }
    /// <summary>차익거래매도수량</summary>
    [DataMember, JsonProperty("차익거래매도수량")]
    public string? 차익거래매도수량
    {
        get; set;
    }
    /// <summary>차익거래매수수량</summary>
    [DataMember, JsonProperty("차익거래매수수량")]
    public string? 차익거래매수수량
    {
        get; set;
    }
    /// <summary>차익거래순매수수량</summary>
    [DataMember, JsonProperty("차익거래순매수수량")]
    public string? 차익거래순매수수량
    {
        get; set;
    }
    /// <summary>비차익거래매도수량</summary>
    [DataMember, JsonProperty("비차익거래매도수량")]
    public string? 비차익거래매도수량
    {
        get; set;
    }
    /// <summary>비차익거래매수수량</summary>
    [DataMember, JsonProperty("비차익거래매수수량")]
    public string? 비차익거래매수수량
    {
        get; set;
    }
    /// <summary>비차익거래순매수수량</summary>
    [DataMember, JsonProperty("비차익거래순매수수량")]
    public string? 비차익거래순매수수량
    {
        get; set;
    }
    /// <summary>전체매도</summary>
    [DataMember, JsonProperty("전체매도")]
    public string? 전체매도
    {
        get; set;
    }
    /// <summary>전체매수</summary>
    [DataMember, JsonProperty("전체매수")]
    public string? 전체매수
    {
        get; set;
    }
    /// <summary>전체순매수</summary>
    [DataMember, JsonProperty("전체순매수")]
    public string? 전체순매수
    {
        get; set;
    }
    /// <summary>KOSPI200</summary>
    [DataMember, JsonProperty("KOSPI200")]
    public string? KOSPI200
    {
        get; set;
    }
    /// <summary>BASIS</summary>
    [DataMember, JsonProperty("BASIS")]
    public string? BASIS
    {
        get; set;
    }
}