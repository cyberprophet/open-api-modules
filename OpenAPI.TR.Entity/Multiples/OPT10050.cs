using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW민감도지표배열</summary>
public class MultiOPT10050
{
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? 체결시간
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>ELW이론가</summary>
    [DataMember, JsonProperty("ELW이론가")]
    public string? ELW이론가
    {
        get; set;
    }
    /// <summary>IV</summary>
    [DataMember, JsonProperty("IV")]
    public string? IV
    {
        get; set;
    }
    /// <summary>델타</summary>
    [DataMember, JsonProperty("델타")]
    public string? 델타
    {
        get; set;
    }
    /// <summary>감마</summary>
    [DataMember, JsonProperty("감마")]
    public string? 감마
    {
        get; set;
    }
    /// <summary>쎄타</summary>
    [DataMember, JsonProperty("쎄타")]
    public string? 쎄타
    {
        get; set;
    }
    /// <summary>베가</summary>
    [DataMember, JsonProperty("베가")]
    public string? 베가
    {
        get; set;
    }
    /// <summary>로</summary>
    [DataMember, JsonProperty("로")]
    public string? 로
    {
        get; set;
    }
    /// <summary>LP</summary>
    [DataMember, JsonProperty("LP")]
    public string? LP
    {
        get; set;
    }
}