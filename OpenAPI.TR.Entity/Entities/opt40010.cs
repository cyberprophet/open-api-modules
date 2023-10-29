using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF시간대별추이요청</summary>
public class Opt40010 : TR
{
    /// <summary>ETF시간대별추이</summary>
    [DataMember, JsonProperty("ETF시간대별추이")]
    public MultiOpt40010[]? MultiResponse
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
        get => nameof(Opt40010);
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
    public override string[] Multiple => new[] { "현재가", "대비기호", "전일대비", "거래량", "외인순매수" };
}