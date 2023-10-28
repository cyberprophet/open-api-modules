using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>발동종목</summary>
public class MultiOpt10054
{
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
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? 누적거래량
    {
        get; set;
    }
    /// <summary>발동가격</summary>
    [DataMember, JsonProperty("발동가격")]
    public string? 발동가격
    {
        get; set;
    }
    /// <summary>동적괴리율</summary>
    [DataMember, JsonProperty("동적괴리율")]
    public string? 동적괴리율
    {
        get; set;
    }
    /// <summary>매매체결처리시각</summary>
    [DataMember, JsonProperty("매매체결처리시각")]
    public string? 매매체결처리시각
    {
        get; set;
    }
    /// <summary>VI해제시각</summary>
    [DataMember, JsonProperty("VI해제시각")]
    public string? VI해제시각
    {
        get; set;
    }
    /// <summary>VI적용구분</summary>
    [DataMember, JsonProperty("VI적용구분")]
    public string? VI적용구분
    {
        get; set;
    }
    /// <summary>동적기준가격</summary>
    [DataMember, JsonProperty("동적기준가격")]
    public string? 동적기준가격
    {
        get; set;
    }
    /// <summary>정적기준가격</summary>
    [DataMember, JsonProperty("정적기준가격")]
    public string? 정적기준가격
    {
        get; set;
    }
    /// <summary>정적괴리율</summary>
    [DataMember, JsonProperty("정적괴리율")]
    public string? 정적괴리율
    {
        get; set;
    }
    /// <summary>시가대비등락률</summary>
    [DataMember, JsonProperty("시가대비등락률")]
    public string? 시가대비등락률
    {
        get; set;
    }
    /// <summary>VI발동횟수</summary>
    [DataMember, JsonProperty("VI발동횟수")]
    public string? VI발동횟수
    {
        get; set;
    }
}