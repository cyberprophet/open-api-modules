using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF시간대별추이요청</summary>
public class Opt40006 : TR
{
    /// <summary>ETF종목정보</summary>
    [DataMember, JsonProperty("ETF종목정보")]
    public SingleOpt40006? SingleResponse
    {
        get; set;
    }
    /// <summary>ETF시간대별추이</summary>
    [DataMember, JsonProperty("ETF시간대별추이")]
    public MultiOpt40006[]? MultiResponse
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
        get => "ETF시간대별추이요청";
    }
    public override string TrCode
    {
        get => nameof(Opt40006);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "종목명", "ETF대상지수명", "원주가격", "ETF과세유형", "ETN과세유형" };
    public override string[] Multiple => new[] { "시간", "종가", "대비기호", "전일대비", "등락율", "거래량", "NAV", "거래대금", "NAV지수", "NAVETF", "추적", "추적지수", "추적지수전일대비", "추적지수전일대비기호" };
}