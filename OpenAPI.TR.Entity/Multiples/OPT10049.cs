using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW투자지표배열</summary>
public class MultiOPT10049
{
    /// <summary>시간</summary>
    [DataMember, JsonProperty("시간")]
    public string? Time
    {
        get; set;
    }
    /// <summary>패리티</summary>
    [DataMember, JsonProperty("패리티")]
    public string? Parity
    {
        get; set;
    }
    /// <summary>프리미엄</summary>
    [DataMember, JsonProperty("프리미엄")]
    public string? Premium
    {
        get; set;
    }
    /// <summary>기어링비율</summary>
    [DataMember, JsonProperty("기어링비율")]
    public string? GearingRatio
    {
        get; set;
    }
    /// <summary>손익분기율</summary>
    [DataMember, JsonProperty("손익분기율")]
    public string? BreakEvenRate
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? ThePresentPrice
    {
        get; set;
    }
    /// <summary>레버리지</summary>
    [DataMember, JsonProperty("레버리지")]
    public string? Leverage
    {
        get; set;
    }
}