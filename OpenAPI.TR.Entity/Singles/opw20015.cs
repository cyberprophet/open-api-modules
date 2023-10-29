using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>옵션행사가</summary>
public class SingleOpw20015
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>ATM행사가격</summary>
    [DataMember, JsonProperty("ATM행사가격")]
    public string? ATMOfferPrice
    {
        get; set;
    }
    /// <summary>위치</summary>
    [DataMember, JsonProperty("위치")]
    public string? Location
    {
        get; set;
    }
    /// <summary>조회건수</summary>
    [DataMember, JsonProperty("조회건수")]
    public string? NumberOfInquiries
    {
        get; set;
    }
}