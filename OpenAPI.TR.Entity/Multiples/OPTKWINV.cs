using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>관심종목투자자정보</summary>
public class MultiOPTKWINV
{
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>매도수량</summary>
    [DataMember, JsonProperty("매도수량")]
    public string? 매도수량
    {
        get; set;
    }
    /// <summary>매수수량</summary>
    [DataMember, JsonProperty("매수수량")]
    public string? 매수수량
    {
        get; set;
    }
    /// <summary>순매수수량</summary>
    [DataMember, JsonProperty("순매수수량")]
    public string? 순매수수량
    {
        get; set;
    }
    /// <summary>매도금액</summary>
    [DataMember, JsonProperty("매도금액")]
    public string? 매도금액
    {
        get; set;
    }
    /// <summary>매수금액</summary>
    [DataMember, JsonProperty("매수금액")]
    public string? 매수금액
    {
        get; set;
    }
    /// <summary>순매수금액</summary>
    [DataMember, JsonProperty("순매수금액")]
    public string? 순매수금액
    {
        get; set;
    }
}