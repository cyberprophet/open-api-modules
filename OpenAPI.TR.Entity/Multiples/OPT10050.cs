using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW민감도지표배열</summary>
public class MultiOPT10050
{
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? ConcludingTime
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>ELW이론가</summary>
    [DataMember, JsonProperty("ELW이론가")]
    public string? ELWTheorist
    {
        get; set;
    }
    /// <summary>IV</summary>
    [DataMember, JsonProperty(nameof(IV))]
    public string? IV
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
    public string? As
    {
        get; set;
    }
    /// <summary>LP</summary>
    [DataMember, JsonProperty(nameof(LP))]
    public string? LP
    {
        get; set;
    }
}