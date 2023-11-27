using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식호가</summary>
public class MultiOpt10004
{
    /// <summary>호가잔량기준시간</summary>
    [DataMember, JsonProperty("호가잔량기준시간"), StringLength(0x10)]
    public string? QuoteBalanceStandardTime
    {
        get; set;
    }
    /// <summary>매도10차선잔량대비</summary>
    [DataMember, JsonProperty("매도10차선잔량대비"), StringLength(0x10)]
    public string? ComparedToTenthAskBalance
    {
        get; set;
    }
    /// <summary>매도10차선잔량</summary>
    [DataMember, JsonProperty("매도10차선잔량"), StringLength(0x10)]
    public string? TenthAskBalance
    {
        get; set;
    }
    /// <summary>매도10차선호가</summary>
    [DataMember, JsonProperty("매도10차선호가"), StringLength(0x10)]
    public string? TenthAskPrice
    {
        get; set;
    }
    /// <summary>매도9차선잔량대비</summary>
    [DataMember, JsonProperty("매도9차선잔량대비"), StringLength(0x10)]
    public string? ComparedToNinthAskBalance
    {
        get; set;
    }
    /// <summary>매도9차선잔량</summary>
    [DataMember, JsonProperty("매도9차선잔량"), StringLength(0x10)]
    public string? NinthAskBalance
    {
        get; set;
    }
    /// <summary>매도9차선호가</summary>
    [DataMember, JsonProperty("매도9차선호가"), StringLength(0x10)]
    public string? NinthAskPrice
    {
        get; set;
    }
    /// <summary>매도8차선잔량대비</summary>
    [DataMember, JsonProperty("매도8차선잔량대비"), StringLength(0x10)]
    public string? ComparedToEighthAskBalance
    {
        get; set;
    }
    /// <summary>매도8차선잔량</summary>
    [DataMember, JsonProperty("매도8차선잔량"), StringLength(0x10)]
    public string? EighthAskBalance
    {
        get; set;
    }
    /// <summary>매도8차선호가</summary>
    [DataMember, JsonProperty("매도8차선호가"), StringLength(0x10)]
    public string? EighthAskPrice
    {
        get; set;
    }
    /// <summary>매도7차선잔량대비</summary>
    [DataMember, JsonProperty("매도7차선잔량대비"), StringLength(0x10)]
    public string? ComparedToSeventhAskBalance
    {
        get; set;
    }
    /// <summary>매도7차선잔량</summary>
    [DataMember, JsonProperty("매도7차선잔량"), StringLength(0x10)]
    public string? SeventhAskBalance
    {
        get; set;
    }
    /// <summary>매도7차선호가</summary>
    [DataMember, JsonProperty("매도7차선호가"), StringLength(0x10)]
    public string? SeventhAskPrice
    {
        get; set;
    }
    /// <summary>매도6차선잔량대비</summary>
    [DataMember, JsonProperty("매도6차선잔량대비"), StringLength(0x10)]
    public string? ComparedToSixthAskBalance
    {
        get; set;
    }
    /// <summary>매도6우선잔량</summary>
    [DataMember, JsonProperty("매도6우선잔량"), StringLength(0x10)]
    public string? SixthAskBalance
    {
        get; set;
    }
    /// <summary>매도6차선호가</summary>
    [DataMember, JsonProperty("매도6차선호가"), StringLength(0x10)]
    public string? SixthAskPrice
    {
        get; set;
    }
    /// <summary>매도5차선잔량대비</summary>
    [DataMember, JsonProperty("매도5차선잔량대비"), StringLength(0x10)]
    public string? ComparedToFifthAskBalance
    {
        get; set;
    }
    /// <summary>매도5차선잔량</summary>
    [DataMember, JsonProperty("매도5차선잔량"), StringLength(0x10)]
    public string? FifthAskBalance
    {
        get; set;
    }
    /// <summary>매도5차선호가</summary>
    [DataMember, JsonProperty("매도5차선호가"), StringLength(0x10)]
    public string? FifthAskPrice
    {
        get; set;
    }
    /// <summary>매도4차선잔량대비</summary>
    [DataMember, JsonProperty("매도4차선잔량대비"), StringLength(0x10)]
    public string? ComparedToFourthAskBalance
    {
        get; set;
    }
    /// <summary>매도4차선잔량</summary>
    [DataMember, JsonProperty("매도4차선잔량"), StringLength(0x10)]
    public string? FourthAskBalance
    {
        get; set;
    }
    /// <summary>매도4차선호가</summary>
    [DataMember, JsonProperty("매도4차선호가"), StringLength(0x10)]
    public string? FourthAskPrice
    {
        get; set;
    }
    /// <summary>매도3차선잔량대비</summary>
    [DataMember, JsonProperty("매도3차선잔량대비"), StringLength(0x10)]
    public string? ComparedToThirdAskBalance
    {
        get; set;
    }
    /// <summary>매도3차선잔량</summary>
    [DataMember, JsonProperty("매도3차선잔량"), StringLength(0x10)]
    public string? ThirdAskBalance
    {
        get; set;
    }
    /// <summary>매도3차선호가</summary>
    [DataMember, JsonProperty("매도3차선호가"), StringLength(0x10)]
    public string? ThirdAskPrice
    {
        get; set;
    }
    /// <summary>매도2차선잔량대비</summary>
    [DataMember, JsonProperty("매도2차선잔량대비"), StringLength(0x10)]
    public string? ComparedToSecondAskBalance
    {
        get; set;
    }
    /// <summary>매도2차선잔량</summary>
    [DataMember, JsonProperty("매도2차선잔량"), StringLength(0x10)]
    public string? SecondAskBalance
    {
        get; set;
    }
    /// <summary>매도2차선호가</summary>
    [DataMember, JsonProperty("매도2차선호가"), StringLength(0x10)]
    public string? SecondAskPrice
    {
        get; set;
    }
    /// <summary>매도1차선잔량대비</summary>
    [DataMember, JsonProperty("매도1차선잔량대비"), StringLength(0x10)]
    public string? ComparedToFirstAskBalance
    {
        get; set;
    }
    /// <summary>매도최우선잔량</summary>
    [DataMember, JsonProperty("매도최우선잔량"), StringLength(0x10)]
    public string? FirstAskBalance
    {
        get; set;
    }
    /// <summary>매도최우선호가</summary>
    [DataMember, JsonProperty("매도최우선호가"), StringLength(0x10)]
    public string? FirstAskPrice
    {
        get; set;
    }
    /// <summary>매수최우선호가</summary>
    [DataMember, JsonProperty("매수최우선호가"), StringLength(0x10)]
    public string? FirstBidPrice
    {
        get; set;
    }
    /// <summary>매수최우선잔량</summary>
    [DataMember, JsonProperty("매수최우선잔량"), StringLength(0x10)]
    public string? FirstBidBalance
    {
        get; set;
    }
    /// <summary>매수1차선잔량대비</summary>
    [DataMember, JsonProperty("매수1차선잔량대비"), StringLength(0x10)]
    public string? ComparedToFirstBidBalance
    {
        get; set;
    }
    /// <summary>매수2차선호가</summary>
    [DataMember, JsonProperty("매수2차선호가"), StringLength(0x10)]
    public string? SecondBidPrice
    {
        get; set;
    }
    /// <summary>매수2차선잔량</summary>
    [DataMember, JsonProperty("매수2차선잔량"), StringLength(0x10)]
    public string? SecondBidBalance
    {
        get; set;
    }
    /// <summary>매수2차선잔량대비</summary>
    [DataMember, JsonProperty("매수2차선잔량대비"), StringLength(0x10)]
    public string? ComparedToSecondBidBalance
    {
        get; set;
    }
    /// <summary>매수3차선호가</summary>
    [DataMember, JsonProperty("매수3차선호가"), StringLength(0x10)]
    public string? ThirdBidPrice
    {
        get; set;
    }
    /// <summary>매수3차선잔량</summary>
    [DataMember, JsonProperty("매수3차선잔량"), StringLength(0x10)]
    public string? ThirdBidBalance
    {
        get; set;
    }
    /// <summary>매수3차선잔량대비</summary>
    [DataMember, JsonProperty("매수3차선잔량대비"), StringLength(0x10)]
    public string? ComparedToThirdBidBalance
    {
        get; set;
    }
    /// <summary>매수4차선호가</summary>
    [DataMember, JsonProperty("매수4차선호가"), StringLength(0x10)]
    public string? FourthBidPrice
    {
        get; set;
    }
    /// <summary>매수4차선잔량</summary>
    [DataMember, JsonProperty("매수4차선잔량"), StringLength(0x10)]
    public string? FourthBidBalance
    {
        get; set;
    }
    /// <summary>매수4차선잔량대비</summary>
    [DataMember, JsonProperty("매수4차선잔량대비"), StringLength(0x10)]
    public string? ComparedToFourthBidBalance
    {
        get; set;
    }
    /// <summary>매수5차선호가</summary>
    [DataMember, JsonProperty("매수5차선호가"), StringLength(0x10)]
    public string? FifthBidPrice
    {
        get; set;
    }
    /// <summary>매수5차선잔량</summary>
    [DataMember, JsonProperty("매수5차선잔량"), StringLength(0x10)]
    public string? FifthBidBalance
    {
        get; set;
    }
    /// <summary>매수5차선잔량대비</summary>
    [DataMember, JsonProperty("매수5차선잔량대비"), StringLength(0x10)]
    public string? ComparedToFifthBidBalance
    {
        get; set;
    }
    /// <summary>매수6우선호가</summary>
    [DataMember, JsonProperty("매수6우선호가"), StringLength(0x10)]
    public string? SixthBidPrice
    {
        get; set;
    }
    /// <summary>매수6우선잔량</summary>
    [DataMember, JsonProperty("매수6우선잔량"), StringLength(0x10)]
    public string? SixthBidBalance
    {
        get; set;
    }
    /// <summary>매수6차선잔량대비</summary>
    [DataMember, JsonProperty("매수6차선잔량대비"), StringLength(0x10)]
    public string? ComparedToSixthBidBalance
    {
        get; set;
    }
    /// <summary>매수7차선호가</summary>
    [DataMember, JsonProperty("매수7차선호가"), StringLength(0x10)]
    public string? SeventhBidPrice
    {
        get; set;
    }
    /// <summary>매수7차선잔량</summary>
    [DataMember, JsonProperty("매수7차선잔량"), StringLength(0x10)]
    public string? SeventhBidBalance
    {
        get; set;
    }
    /// <summary>매수7차선잔량대비</summary>
    [DataMember, JsonProperty("매수7차선잔량대비"), StringLength(0x10)]
    public string? ComparedToSeventhBidBalance
    {
        get; set;
    }
    /// <summary>매수8차선호가</summary>
    [DataMember, JsonProperty("매수8차선호가"), StringLength(0x10)]
    public string? EighthBidPrice
    {
        get; set;
    }
    /// <summary>매수8차선잔량</summary>
    [DataMember, JsonProperty("매수8차선잔량"), StringLength(0x10)]
    public string? EighthBidBalance
    {
        get; set;
    }
    /// <summary>매수8차선잔량대비</summary>
    [DataMember, JsonProperty("매수8차선잔량대비"), StringLength(0x10)]
    public string? ComparedToEighthBidBalance
    {
        get; set;
    }
    /// <summary>매수9차선호가</summary>
    [DataMember, JsonProperty("매수9차선호가"), StringLength(0x10)]
    public string? NinthBidPrice
    {
        get; set;
    }
    /// <summary>매수9차선잔량</summary>
    [DataMember, JsonProperty("매수9차선잔량"), StringLength(0x10)]
    public string? NinthBidBalance
    {
        get; set;
    }
    /// <summary>매수9차선잔량대비</summary>
    [DataMember, JsonProperty("매수9차선잔량대비"), StringLength(0x10)]
    public string? ComparedToNinthBidBalance
    {
        get; set;
    }
    /// <summary>매수10차선호가</summary>
    [DataMember, JsonProperty("매수10차선호가"), StringLength(0x10)]
    public string? TenthBidPrice
    {
        get; set;
    }
    /// <summary>매수10차선잔량</summary>
    [DataMember, JsonProperty("매수10차선잔량"), StringLength(0x10)]
    public string? TenthBidBalance
    {
        get; set;
    }
    /// <summary>매수10차선잔량대비</summary>
    [DataMember, JsonProperty("매수10차선잔량대비"), StringLength(0x10)]
    public string? ComparedToTenthBidBalance
    {
        get; set;
    }
    /// <summary>총매도잔량직전대비</summary>
    [DataMember, JsonProperty("총매도잔량직전대비"), StringLength(0x10)]
    public string? ComparedToTotalAskBalance
    {
        get; set;
    }
    /// <summary>총매도잔량</summary>
    [DataMember, JsonProperty("총매도잔량"), StringLength(0x10)]
    public string? TotalAskBalance
    {
        get; set;
    }
    /// <summary>총매수잔량</summary>
    [DataMember, JsonProperty("총매수잔량"), StringLength(0x10)]
    public string? TotalBidBalance
    {
        get; set;
    }
    /// <summary>총매수잔량직전대비</summary>
    [DataMember, JsonProperty("총매수잔량직전대비"), StringLength(0x10)]
    public string? ComparedToTotalBidBalance
    {
        get; set;
    }
    /// <summary>시간외매도잔량대비</summary>
    [DataMember, JsonProperty("시간외매도잔량대비"), StringLength(0x10)]
    public string? ComparedToAfterMarketAskBalance
    {
        get; set;
    }
    /// <summary>시간외매도잔량</summary>
    [DataMember, JsonProperty("시간외매도잔량"), StringLength(0x10)]
    public string? AfterMarketAskBalance
    {
        get; set;
    }
    /// <summary>시간외매수잔량</summary>
    [DataMember, JsonProperty("시간외매수잔량"), StringLength(0x10)]
    public string? AfterMarketBidBalance
    {
        get; set;
    }
    /// <summary>시간외매수잔량대비</summary>
    [DataMember, JsonProperty("시간외매수잔량대비"), StringLength(0x10)]
    public string? ComparedToAfterMarketBidBalance
    {
        get; set;
    }
}