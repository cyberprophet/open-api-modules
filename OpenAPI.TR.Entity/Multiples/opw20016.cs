using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>신용융자가능종목</summary>
public class MultiOpw20016
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>신용보즘금율</summary>
    [DataMember, JsonProperty("신용보즘금율")]
    public string? 신용보즘금율
    {
        get; set;
    }
    /// <summary>대용가</summary>
    [DataMember, JsonProperty("대용가")]
    public string? 대용가
    {
        get; set;
    }
    /// <summary>전일종가</summary>
    [DataMember, JsonProperty("전일종가")]
    public string? 전일종가
    {
        get; set;
    }
    /// <summary>신용한도초과여부</summary>
    [DataMember, JsonProperty("신용한도초과여부")]
    public string? 신용한도초과여부
    {
        get; set;
    }
    /// <summary>신용한도초과</summary>
    [DataMember, JsonProperty("신용한도초과")]
    public string? 신용한도초과
    {
        get; set;
    }
}