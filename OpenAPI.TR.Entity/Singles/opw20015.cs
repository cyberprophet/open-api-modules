using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>옵션행사가</summary>
public class SingleOpw20015
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>ATM행사가격</summary>
    [DataMember, JsonProperty("ATM행사가격")]
    public string? ATM행사가격
    {
        get; set;
    }
    /// <summary>위치</summary>
    [DataMember, JsonProperty("위치")]
    public string? 위치
    {
        get; set;
    }
    /// <summary>조회건수</summary>
    [DataMember, JsonProperty("조회건수")]
    public string? 조회건수
    {
        get; set;
    }
}