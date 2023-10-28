using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>당일전일체결대량</summary>
public class MultiOpt10055
{
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? 체결시간
    {
        get; set;
    }
    /// <summary>체결가</summary>
    [DataMember, JsonProperty("체결가")]
    public string? 체결가
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
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? 등락율
    {
        get; set;
    }
    /// <summary>체결량</summary>
    [DataMember, JsonProperty("체결량")]
    public string? 체결량
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
}