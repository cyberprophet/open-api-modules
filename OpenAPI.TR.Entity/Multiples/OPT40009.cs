using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETFNAV배열</summary>
public class MultiOPT40009
{
    /// <summary>NAV</summary>
    [DataMember, JsonProperty(nameof(NAV))]
    public string? NAV
    {
        get; set;
    }
    /// <summary>NAV전일대비</summary>
    [DataMember, JsonProperty("NAV전일대비")]
    public string? ComparedToThePreviousDayOfNAV
    {
        get; set;
    }
    /// <summary>NAV등락율</summary>
    [DataMember, JsonProperty("NAV등락율")]
    public string? NAVInclusionRate
    {
        get; set;
    }
    /// <summary>추적오차율</summary>
    [DataMember, JsonProperty("추적오차율")]
    public string? TrackingErrorRate
    {
        get; set;
    }
    /// <summary>괴리율</summary>
    [DataMember, JsonProperty("괴리율")]
    public string? DisparateRatio
    {
        get; set;
    }
    /// <summary>주식수</summary>
    [DataMember, JsonProperty("주식수")]
    public string? NumberOfShares
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public string? AStandardPrice
    {
        get; set;
    }
    /// <summary>외인보유수량</summary>
    [DataMember, JsonProperty("외인보유수량")]
    public string? AmountHeldByForeigners
    {
        get; set;
    }
    /// <summary>대용가</summary>
    [DataMember, JsonProperty("대용가")]
    public string? ASubstituteFor
    {
        get; set;
    }
    /// <summary>모름</summary>
    [DataMember, JsonProperty("모름")]
    public string? DontKnow
    {
        get; set;
    }
    /// <summary>환산가격</summary>
    [DataMember, JsonProperty("환산가격")]
    public string? ConversionPrice
    {
        get; set;
    }
    /// <summary>DR/주</summary>
    [DataMember, JsonProperty("DR/주")]
    public string? DR
    {
        get; set;
    }
    /// <summary>원주가격</summary>
    [DataMember, JsonProperty("원주가격")]
    public string? CircumferentialPrice
    {
        get; set;
    }
}