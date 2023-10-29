using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF시간대별체결요청</summary>
public class OPT40009 : TR
{
    /// <summary>ETFNAV배열</summary>
    [DataMember, JsonProperty("ETFNAV배열")]
    public MultiOPT40009[]? MultiResponse
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
        get => nameof(OPT40009);
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
    public override string[] Multiple => new[] { "NAV", "NAV전일대비", "NAV등락율", "추적오차율", "괴리율", "주식수", "기준가", "외인보유수량", "대용가", "모름", "환산가격", "DR/주", "원주가격" };
}