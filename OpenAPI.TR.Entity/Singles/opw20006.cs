using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵잔고상세현황합계</summary>
public class SingleOpw20006
{
    /// <summary>선물매도수량</summary>
    [DataMember, JsonProperty("선물매도수량")]
    public string? 선물매도수량
    {
        get; set;
    }
    /// <summary>선물매수수량</summary>
    [DataMember, JsonProperty("선물매수수량")]
    public string? 선물매수수량
    {
        get; set;
    }
    /// <summary>콜매도수량</summary>
    [DataMember, JsonProperty("콜매도수량")]
    public string? 콜매도수량
    {
        get; set;
    }
    /// <summary>콜매수수량</summary>
    [DataMember, JsonProperty("콜매수수량")]
    public string? 콜매수수량
    {
        get; set;
    }
    /// <summary>풋매도수량</summary>
    [DataMember, JsonProperty("풋매도수량")]
    public string? 풋매도수량
    {
        get; set;
    }
    /// <summary>풋매수수량</summary>
    [DataMember, JsonProperty("풋매수수량")]
    public string? 풋매수수량
    {
        get; set;
    }
    /// <summary>선물매도금액</summary>
    [DataMember, JsonProperty("선물매도금액")]
    public string? 선물매도금액
    {
        get; set;
    }
    /// <summary>선물매수금액</summary>
    [DataMember, JsonProperty("선물매수금액")]
    public string? 선물매수금액
    {
        get; set;
    }
    /// <summary>콜매도금액</summary>
    [DataMember, JsonProperty("콜매도금액")]
    public string? 콜매도금액
    {
        get; set;
    }
    /// <summary>콜매수금액</summary>
    [DataMember, JsonProperty("콜매수금액")]
    public string? 콜매수금액
    {
        get; set;
    }
    /// <summary>풋매도금액</summary>
    [DataMember, JsonProperty("풋매도금액")]
    public string? 풋매도금액
    {
        get; set;
    }
    /// <summary>풋매수금액</summary>
    [DataMember, JsonProperty("풋매수금액")]
    public string? 풋매수금액
    {
        get; set;
    }
    /// <summary>약정합계</summary>
    [DataMember, JsonProperty("약정합계")]
    public string? 약정합계
    {
        get; set;
    }
    /// <summary>손익합계</summary>
    [DataMember, JsonProperty("손익합계")]
    public string? 손익합계
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