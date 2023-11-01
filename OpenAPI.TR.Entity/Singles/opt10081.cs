using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식일봉차트</summary>
public class SingleOpt10081
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    [NotMapped]
    public string? Name
    {
        get; set;
    }
}