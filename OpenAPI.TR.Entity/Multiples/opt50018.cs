using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>풋콜옵션비율차트</summary>
public class MultiOpt50018
{
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? 체결시간
    {
        get; set;
    }
    /// <summary>콜풋RATIO</summary>
    [DataMember, JsonProperty("콜풋RATIO")]
    public string? 콜풋RATIO
    {
        get; set;
    }
    /// <summary>코스피200</summary>
    [DataMember, JsonProperty("코스피200")]
    public string? 코스피200
    {
        get; set;
    }
}