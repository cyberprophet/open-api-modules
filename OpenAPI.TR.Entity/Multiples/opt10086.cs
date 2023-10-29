using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일별주가</summary>
public class MultiOpt10086
{
    /// <summary>날짜</summary>
    [DataMember, JsonProperty("날짜")]
    public string? Date
    {
        get; set;
    }
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가")]
    public string? MarketPrice
    {
        get; set;
    }
    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가")]
    public string? HighPrice
    {
        get; set;
    }
    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가")]
    public string? LowPrice
    {
        get; set;
    }
    /// <summary>종가</summary>
    [DataMember, JsonProperty("종가")]
    public string? ClosingPrice
    {
        get; set;
    }
    /// <summary>전일비</summary>
    [DataMember, JsonProperty("전일비")]
    public string? FullTimeCost
    {
        get; set;
    }
    /// <summary>등락률</summary>
    [DataMember, JsonProperty("등락률")]
    public string? FluctuationRate
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? VolumeOfTransaction
    {
        get; set;
    }
    /// <summary>금액(백만)</summary>
    [DataMember, JsonProperty("금액(백만)")]
    public string? Amount
    {
        get; set;
    }
    /// <summary>신용비</summary>
    [DataMember, JsonProperty("신용비")]
    public string? CreditCost
    {
        get; set;
    }
    /// <summary>개인</summary>
    [DataMember, JsonProperty("개인")]
    public string? Individual
    {
        get; set;
    }
    /// <summary>기관</summary>
    [DataMember, JsonProperty("기관")]
    public string? Institution
    {
        get; set;
    }
    /// <summary>외인수량</summary>
    [DataMember, JsonProperty("외인수량")]
    public string? ExternalPhosphorus
    {
        get; set;
    }
    /// <summary>외국계</summary>
    [DataMember, JsonProperty("외국계")]
    public string? TheForeignWorld
    {
        get; set;
    }
    /// <summary>프로그램</summary>
    [DataMember, JsonProperty("프로그램")]
    public string? Program
    {
        get; set;
    }
    /// <summary>외인비</summary>
    [DataMember, JsonProperty("외인비")]
    public string? ForeignCost
    {
        get; set;
    }
    /// <summary>체결강도</summary>
    [DataMember, JsonProperty("체결강도")]
    public string? FasteningStrength
    {
        get; set;
    }
    /// <summary>외인보유</summary>
    [DataMember, JsonProperty("외인보유")]
    public string? ForeignOwnership
    {
        get; set;
    }
    /// <summary>외인비중</summary>
    [DataMember, JsonProperty("외인비중")]
    public string? ProportionOfForeigners
    {
        get; set;
    }
    /// <summary>외인순매수</summary>
    [DataMember, JsonProperty("외인순매수")]
    public string? NetForeignPurchase
    {
        get; set;
    }
    /// <summary>기관순매수</summary>
    [DataMember, JsonProperty("기관순매수")]
    public string? NetPurchaseOfAnInstitutionalPurchase
    {
        get; set;
    }
    /// <summary>개인순매수</summary>
    [DataMember, JsonProperty("개인순매수")]
    public string? IndividualNetPurchase
    {
        get; set;
    }
    /// <summary>신용잔고율</summary>
    [DataMember, JsonProperty("신용잔고율")]
    public string? CreditBalanceRatio
    {
        get; set;
    }
}