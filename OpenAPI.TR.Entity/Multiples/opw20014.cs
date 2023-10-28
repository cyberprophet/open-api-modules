using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵내재변동성</summary>
public class MultiOpw20014
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>매도매수구분</summary>
    [DataMember, JsonProperty("매도매수구분")]
    public string? 매도매수구분
    {
        get; set;
    }
    /// <summary>미결제수량</summary>
    [DataMember, JsonProperty("미결제수량")]
    public string? 미결제수량
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>내재변동성</summary>
    [DataMember, JsonProperty("내재변동성")]
    public string? 내재변동성
    {
        get; set;
    }
    /// <summary>이론지수</summary>
    [DataMember, JsonProperty("이론지수")]
    public string? 이론지수
    {
        get; set;
    }
    /// <summary>잔존일수</summary>
    [DataMember, JsonProperty("잔존일수")]
    public string? 잔존일수
    {
        get; set;
    }
}