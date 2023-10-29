using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목시간별프로그램매매추이</summary>
public class MultiOpt90008
{
    /// <summary>시간</summary>
    [DataMember, JsonProperty("시간")]
    public string? Time
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>대비기호</summary>
    [DataMember, JsonProperty("대비기호")]
    public string? ContrastSymbol
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
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
    /// <summary>프로그램매도금액</summary>
    [DataMember, JsonProperty("프로그램매도금액")]
    public string? ProgramSalesAmount
    {
        get; set;
    }
    /// <summary>프로그램매수금액</summary>
    [DataMember, JsonProperty("프로그램매수금액")]
    public string? ProgramPurchaseAmount
    {
        get; set;
    }
    /// <summary>프로그램순매수금액</summary>
    [DataMember, JsonProperty("프로그램순매수금액")]
    public string? NetPurchaseAmountOfProgram
    {
        get; set;
    }
    /// <summary>프로그램순매수금액증감</summary>
    [DataMember, JsonProperty("프로그램순매수금액증감")]
    public string? IncreaseOrDecreaseTheNetPurchaseAmountOfTheProgram
    {
        get; set;
    }
    /// <summary>프로그램매도수량</summary>
    [DataMember, JsonProperty("프로그램매도수량")]
    public string? ProgramSalesQuantity
    {
        get; set;
    }
    /// <summary>프로그램매수수량</summary>
    [DataMember, JsonProperty("프로그램매수수량")]
    public string? ProgramPurchaseQuantity
    {
        get; set;
    }
    /// <summary>프로그램순매수수량</summary>
    [DataMember, JsonProperty("프로그램순매수수량")]
    public string? ProgramNetPurchaseQuantity
    {
        get; set;
    }
    /// <summary>프로그램순매수수량증감</summary>
    [DataMember, JsonProperty("프로그램순매수수량증감")]
    public string? IncreaseInProgramNetPurchaseQuantity
    {
        get; set;
    }
    /// <summary>기준가시간</summary>
    [DataMember, JsonProperty("기준가시간")]
    public string? BasePriceTime
    {
        get; set;
    }
    /// <summary>대차거래상환주수합</summary>
    [DataMember, JsonProperty("대차거래상환주수합")]
    public string? LoanTransactionConversionSum
    {
        get; set;
    }
    /// <summary>잔고수주합</summary>
    [DataMember, JsonProperty("잔고수주합")]
    public string? BalanceOrder
    {
        get; set;
    }
}