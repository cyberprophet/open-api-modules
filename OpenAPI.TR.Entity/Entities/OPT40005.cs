using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF일별추이요청</summary>
public class OPT40005 : TR
{
    /// <summary>ETF일별추이</summary>
    [DataMember, JsonProperty("ETF일별추이")]
    public MultiOPT40005[]? MultiResponse
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
        get => "ETF일별추이요청";
    }
    public override string TrCode
    {
        get => nameof(OPT40005);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => Array.Empty<string>();
    public override string[] Multiple => new[] { "체결시간", "종가", "대비기호", "전일대비", "대비율", "거래량", "NAV", "누적거래대금", "NAV/지수괴리율", "NAV/ETF괴리율", "추적오차율", "추적지수", "추적대비기호", "추적전일대비" };
}