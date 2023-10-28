using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌미결제청산가능수량조회</summary>
public class SingleOpw20013
{
    /// <summary>미결제수량</summary>
    [DataMember, JsonProperty("미결제수량")]
    public string? 미결제수량
    {
        get; set;
    }
    /// <summary>청산가능수량</summary>
    [DataMember, JsonProperty("청산가능수량")]
    public string? 청산가능수량
    {
        get; set;
    }
    /// <summary>현재증거금총액</summary>
    [DataMember, JsonProperty("현재증거금총액")]
    public string? 현재증거금총액
    {
        get; set;
    }
    /// <summary>현재증거금현금</summary>
    [DataMember, JsonProperty("현재증거금현금")]
    public string? 현재증거금현금
    {
        get; set;
    }
    /// <summary>예상위탁증거금</summary>
    [DataMember, JsonProperty("예상위탁증거금")]
    public string? 예상위탁증거금
    {
        get; set;
    }
    /// <summary>예상현금증거금</summary>
    [DataMember, JsonProperty("예상현금증거금")]
    public string? 예상현금증거금
    {
        get; set;
    }
}