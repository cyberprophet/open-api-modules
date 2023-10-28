using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>민감도지표추이</summary>
public class MultiOpt50023
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? 일자
    {
        get; set;
    }
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? 체결시간
    {
        get; set;
    }
    /// <summary>현재가n</summary>
    [DataMember, JsonProperty("현재가n")]
    public string? 현재가n
    {
        get; set;
    }
    /// <summary>이론가n</summary>
    [DataMember, JsonProperty("이론가n")]
    public string? 이론가n
    {
        get; set;
    }
    /// <summary>내재변동성n</summary>
    [DataMember, JsonProperty("내재변동성n")]
    public string? 내재변동성n
    {
        get; set;
    }
    /// <summary>델타n</summary>
    [DataMember, JsonProperty("델타n")]
    public string? 델타n
    {
        get; set;
    }
    /// <summary>감마n</summary>
    [DataMember, JsonProperty("감마n")]
    public string? 감마n
    {
        get; set;
    }
    /// <summary>세타n</summary>
    [DataMember, JsonProperty("세타n")]
    public string? 세타n
    {
        get; set;
    }
    /// <summary>베가n</summary>
    [DataMember, JsonProperty("베가n")]
    public string? 베가n
    {
        get; set;
    }
    /// <summary>로n</summary>
    [DataMember, JsonProperty("로n")]
    public string? 로n
    {
        get; set;
    }
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가")]
    public string? 시가
    {
        get; set;
    }
    /// <summary>고가n</summary>
    [DataMember, JsonProperty("고가n")]
    public string? 고가n
    {
        get; set;
    }
    /// <summary>저가n</summary>
    [DataMember, JsonProperty("저가n")]
    public string? 저가n
    {
        get; set;
    }
    /// <summary>대비기호n</summary>
    [DataMember, JsonProperty("대비기호n")]
    public string? 대비기호n
    {
        get; set;
    }
    /// <summary>전일대비n</summary>
    [DataMember, JsonProperty("전일대비n")]
    public string? 전일대비n
    {
        get; set;
    }
    /// <summary>등락율n</summary>
    [DataMember, JsonProperty("등락율n")]
    public string? 등락율n
    {
        get; set;
    }
    /// <summary>누적거래량n</summary>
    [DataMember, JsonProperty("누적거래량n")]
    public string? 누적거래량n
    {
        get; set;
    }
    /// <summary>미결제약정n</summary>
    [DataMember, JsonProperty("미결제약정n")]
    public string? 미결제약정n
    {
        get; set;
    }
}