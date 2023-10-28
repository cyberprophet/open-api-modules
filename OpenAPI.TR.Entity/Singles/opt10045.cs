using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>기관추정평균가</summary>
public class SingleOpt10045
{
    /// <summary>기관추정평균가</summary>
    [DataMember, JsonProperty("기관추정평균가")]
    public string? 기관추정평균가
    {
        get; set;
    }
    /// <summary>외인추정평균가</summary>
    [DataMember, JsonProperty("외인추정평균가")]
    public string? 외인추정평균가
    {
        get; set;
    }
}