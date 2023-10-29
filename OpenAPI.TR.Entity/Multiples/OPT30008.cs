using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW민감도지표</summary>
public class MultiOPT30008
{
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? ConcludingTime
    {
        get; set;
    }
    /// <summary>내재변동성</summary>
    [DataMember, JsonProperty("내재변동성")]
    public string? IntrinsicVolatility
    {
        get; set;
    }
    /// <summary>델타</summary>
    [DataMember, JsonProperty("델타")]
    public string? Delta
    {
        get; set;
    }
    /// <summary>감마</summary>
    [DataMember, JsonProperty("감마")]
    public string? Gamma
    {
        get; set;
    }
    /// <summary>쎄타</summary>
    [DataMember, JsonProperty("쎄타")]
    public string? Seta
    {
        get; set;
    }
    /// <summary>베가</summary>
    [DataMember, JsonProperty("베가")]
    public string? Vega
    {
        get; set;
    }
    /// <summary>로</summary>
    [DataMember, JsonProperty("로")]
    public string? Rho
    {
        get; set;
    }
    /// <summary>X-Ray순간체결량증거금100%구분</summary>
    [DataMember, JsonProperty("X-Ray순간체결량증거금100%구분")]
    public string? ClassificationOfXRayInstantaneousContractAmountMargin
    {
        get; set;
    }
}