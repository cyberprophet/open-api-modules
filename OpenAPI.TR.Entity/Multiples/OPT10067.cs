using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>대차거래내역</summary>
public class MultiOPT10067
{
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>대차거래체결주수</summary>
    [DataMember, JsonProperty("대차거래체결주수")]
    public string? 대차거래체결주수
    {
        get; set;
    }
    /// <summary>대차거래상환주수</summary>
    [DataMember, JsonProperty("대차거래상환주수")]
    public string? 대차거래상환주수
    {
        get; set;
    }
    /// <summary>잔고주수</summary>
    [DataMember, JsonProperty("잔고주수")]
    public string? 잔고주수
    {
        get; set;
    }
    /// <summary>잔고금액</summary>
    [DataMember, JsonProperty("잔고금액")]
    public string? 잔고금액
    {
        get; set;
    }
}