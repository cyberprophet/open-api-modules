using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>당일상위이탈원</summary>
public class MultiOpt10053
{
    /// <summary>매도이탈시간</summary>
    [DataMember, JsonProperty("매도이탈시간")]
    public string? OutOfSaleTime
    {
        get; set;
    }
    /// <summary>매도수량</summary>
    [DataMember, JsonProperty("매도수량")]
    public string? SalesVolume
    {
        get; set;
    }
    /// <summary>매도상위이탈원</summary>
    [DataMember, JsonProperty("매도상위이탈원")]
    public string? TopSellingDefectors
    {
        get; set;
    }
    /// <summary>매수이탈시간</summary>
    [DataMember, JsonProperty("매수이탈시간")]
    public string? TimeToLeaveTheBuyoutTime
    {
        get; set;
    }
    /// <summary>매수수량</summary>
    [DataMember, JsonProperty("매수수량")]
    public string? PurchaseQuantity
    {
        get; set;
    }
    /// <summary>매수상위이탈원</summary>
    [DataMember, JsonProperty("매수상위이탈원")]
    public string? TopBuyersLeave
    {
        get; set;
    }
    /// <summary>조회일자</summary>
    [DataMember, JsonProperty("조회일자")]
    public string? InquiryDate
    {
        get; set;
    }
    /// <summary>조회시간</summary>
    [DataMember, JsonProperty("조회시간")]
    public string? ViewTime
    {
        get; set;
    }
}