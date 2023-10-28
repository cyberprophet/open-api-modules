using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>장중투자자별매매상위</summary>
public class MultiOPT10065
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
    /// <summary>매도량</summary>
    [DataMember, JsonProperty("매도량")]
    public string? 매도량
    {
        get; set;
    }
    /// <summary>매수량</summary>
    [DataMember, JsonProperty("매수량")]
    public string? 매수량
    {
        get; set;
    }
    /// <summary>순매도</summary>
    [DataMember, JsonProperty("순매도")]
    public string? 순매도
    {
        get; set;
    }
}