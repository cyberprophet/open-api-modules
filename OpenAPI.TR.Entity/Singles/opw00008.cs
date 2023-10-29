using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌별익일결제예정내역</summary>
public class SingleOpw00008
{
    /// <summary>매매일자</summary>
    [DataMember, JsonProperty("매매일자")]
    public string? DateOfSale
    {
        get; set;
    }
    /// <summary>결제일자</summary>
    [DataMember, JsonProperty("결제일자")]
    public string? PaymentDate
    {
        get; set;
    }
    /// <summary>매도정산합</summary>
    [DataMember, JsonProperty("매도정산합")]
    public string? SalesSettlementSum
    {
        get; set;
    }
    /// <summary>매수정산합</summary>
    [DataMember, JsonProperty("매수정산합")]
    public string? PurchaseSettlementSum
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