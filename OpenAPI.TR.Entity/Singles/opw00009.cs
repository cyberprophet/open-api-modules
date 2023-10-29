using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌별주문체결현황</summary>
public class SingleOpw00009
{
    /// <summary>매도약정금액</summary>
    [DataMember, JsonProperty("매도약정금액")]
    public string? SaleCommitmentAmount
    {
        get; set;
    }
    /// <summary>매수약정금액</summary>
    [DataMember, JsonProperty("매수약정금액")]
    public string? PurchaseAgreementAmount
    {
        get; set;
    }
    /// <summary>약정금액</summary>
    [DataMember, JsonProperty("약정금액")]
    public string? ContractAmount
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