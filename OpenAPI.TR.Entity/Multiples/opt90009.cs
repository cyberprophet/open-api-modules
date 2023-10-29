using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>외국인기관매매상위</summary>
public class MultiOpt90009
{
    /// <summary>외인순매도종목코드</summary>
    [DataMember, JsonProperty("외인순매도종목코드")]
    public string? ForeignersNetSellingStockCode
    {
        get; set;
    }
    /// <summary>외인순매도종목명</summary>
    [DataMember, JsonProperty("외인순매도종목명")]
    public string? ForeignersNetSellingItemName
    {
        get; set;
    }
    /// <summary>외인순매도금액</summary>
    [DataMember, JsonProperty("외인순매도금액")]
    public string? NetSellingAmountOfForeigners
    {
        get; set;
    }
    /// <summary>외인순매도수량</summary>
    [DataMember, JsonProperty("외인순매도수량")]
    public string? NetSellingVolumeOfForeigners
    {
        get; set;
    }
    /// <summary>대칭구분</summary>
    [DataMember, JsonProperty("대칭구분")]
    public string? SymmetricClassification
    {
        get; set;
    }
    /// <summary>외인순매수종목코드</summary>
    [DataMember, JsonProperty("외인순매수종목코드")]
    public string? ForeignersNetPurchaseItemCode
    {
        get; set;
    }
    /// <summary>외인순매수종목명</summary>
    [DataMember, JsonProperty("외인순매수종목명")]
    public string? ForeignersNetPurchaseItemName
    {
        get; set;
    }
    /// <summary>외인순매수금액</summary>
    [DataMember, JsonProperty("외인순매수금액")]
    public string? NetPurchaseAmountOfForeigners
    {
        get; set;
    }
    /// <summary>외인순매수수량</summary>
    [DataMember, JsonProperty("외인순매수수량")]
    public string? NetPurchaseQuantityForForeigners
    {
        get; set;
    }
    /// <summary>기관순매도종목코드</summary>
    [DataMember, JsonProperty("기관순매도종목코드")]
    public string? InstitutionalNetSellingStockCode
    {
        get; set;
    }
    /// <summary>기관순매도종목명</summary>
    [DataMember, JsonProperty("기관순매도종목명")]
    public string? InstitutionalNetSellingItemName
    {
        get; set;
    }
    /// <summary>기관순매도금액</summary>
    [DataMember, JsonProperty("기관순매도금액")]
    public string? InstitutionalNetSellingAmount
    {
        get; set;
    }
    /// <summary>기관순매도수량</summary>
    [DataMember, JsonProperty("기관순매도수량")]
    public string? InstitutionalNetSalesVolume
    {
        get; set;
    }
    /// <summary>기관순매수종목코드</summary>
    [DataMember, JsonProperty("기관순매수종목코드")]
    public string? InstitutionalNetPurchaseItemCode
    {
        get; set;
    }
    /// <summary>기관순매수종목명</summary>
    [DataMember, JsonProperty("기관순매수종목명")]
    public string? NetPurchaseItemNameOfInstitution
    {
        get; set;
    }
    /// <summary>기관순매수금액</summary>
    [DataMember, JsonProperty("기관순매수금액")]
    public string? InstitutionalNetPurchaseAmount
    {
        get; set;
    }
    /// <summary>기관순매수수량</summary>
    [DataMember, JsonProperty("기관순매수수량")]
    public string? InstitutionalNetPurchaseQuantity
    {
        get; set;
    }
}