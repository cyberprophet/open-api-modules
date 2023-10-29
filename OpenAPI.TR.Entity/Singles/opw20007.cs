using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵잔고현황정산가기준합계</summary>
public class SingleOpw20007
{
    /// <summary>약정금액합계</summary>
    [DataMember, JsonProperty("약정금액합계")]
    public string? TotalAmountOfContract
    {
        get; set;
    }
    /// <summary>평가손익합계</summary>
    [DataMember, JsonProperty("평가손익합계")]
    public string? TotalValuationGainsAndLosses
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