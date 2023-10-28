using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>당일매매일지</summary>
public class MultiOpt10170
{
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>매수평균가</summary>
    [DataMember, JsonProperty("매수평균가")]
    public string? 매수평균가
    {
        get; set;
    }
    /// <summary>매수수량</summary>
    [DataMember, JsonProperty("매수수량")]
    public string? 매수수량
    {
        get; set;
    }
    /// <summary>매도평균가</summary>
    [DataMember, JsonProperty("매도평균가")]
    public string? 매도평균가
    {
        get; set;
    }
    /// <summary>매도수량</summary>
    [DataMember, JsonProperty("매도수량")]
    public string? 매도수량
    {
        get; set;
    }
    /// <summary>수수료_제세금</summary>
    [DataMember, JsonProperty("수수료_제세금")]
    public string? 수수료_제세금
    {
        get; set;
    }
    /// <summary>손익금액</summary>
    [DataMember, JsonProperty("손익금액")]
    public string? 손익금액
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
    /// <summary>수익률</summary>
    [DataMember, JsonProperty("수익률")]
    public string? 수익률
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
}