using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF시간대별체결요청</summary>
public class Opt40007 : TR
{
    /// <summary>ETF시간대별체결</summary>
    [DataMember, JsonProperty("ETF시간대별체결")]
    public SingleOpt40007? SingleResponse
    {
        get; set;
    }
    /// <summary>ETF시간대별체결배열</summary>
    [DataMember, JsonProperty("ETF시간대별체결배열")]
    public MultiOpt40007[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// </summary>
    public override string[] Id => new[] { "종목코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "ETF시간대별체결요청";
    }
    public override string TrCode
    {
        get => nameof(Opt40007);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "종목분류", "종목명", "ETF대상지수명", "ETF대상지수코드", "대상지수대비율", "원주가격" };
    public override string[] Multiple => new[] { "체결시간", "현재가", "대비기호", "전일대비", "거래량" };
}