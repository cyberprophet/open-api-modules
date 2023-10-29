using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF수익율요청</summary>
public class OPT40001 : TR
{
    /// <summary>ETF수익율</summary>
    [DataMember, JsonProperty("ETF수익율")]
    public MultiOPT40001[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.모름
    /// 3.기간
    /// </summary>
    public override string[] Id => new[] { "종목코드", "모름", "기간" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "ETF수익율요청";
    }
    public override string TrCode
    {
        get => nameof(OPT40001);
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
    public override string[] Multiple => new[] { "ETF수익률", "체결수익률", "외인순매수수량", "기관순매수수량" };
}