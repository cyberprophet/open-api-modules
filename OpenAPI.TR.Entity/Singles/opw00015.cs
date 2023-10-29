using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>위탁종합거래내역</summary>
public class SingleOpw00015
{
    /// <summary>계좌번호</summary>
    [DataMember, JsonProperty("계좌번호")]
    public string? AccountNumber
    {
        get; set;
    }
    /// <summary>출력건수</summary>
    [DataMember, JsonProperty("출력건수")]
    public string? NumberOfOutputs
    {
        get; set;
    }
}