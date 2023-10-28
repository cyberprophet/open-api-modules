using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵시간대별체결</summary>
public class MultiOpt50001
{
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
    /// <summary>체결량</summary>
    [DataMember, JsonProperty("체결량")]
    public string? 체결량
    {
        get; set;
    }
    /// <summary>미결제약정n</summary>
    [DataMember, JsonProperty("미결제약정n")]
    public string? 미결제약정n
    {
        get; set;
    }
    /// <summary>코스피200</summary>
    [DataMember, JsonProperty("코스피200")]
    public string? 코스피200
    {
        get; set;
    }
    /// <summary>시장베이시스n</summary>
    [DataMember, JsonProperty("시장베이시스n")]
    public string? 시장베이시스n
    {
        get; set;
    }
    /// <summary>역사적변동성</summary>
    [DataMember, JsonProperty("역사적변동성")]
    public string? 역사적변동성
    {
        get; set;
    }
    /// <summary>표면이자</summary>
    [DataMember, JsonProperty("표면이자")]
    public string? 표면이자
    {
        get; set;
    }
    /// <summary>배당액지수</summary>
    [DataMember, JsonProperty("배당액지수")]
    public string? 배당액지수
    {
        get; set;
    }
    /// <summary>기준가n</summary>
    [DataMember, JsonProperty("기준가n")]
    public string? 기준가n
    {
        get; set;
    }
    /// <summary>등락율n</summary>
    [DataMember, JsonProperty("등락율n")]
    public string? 등락율n
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? 누적거래량
    {
        get; set;
    }
}