using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF종목정보요청</summary>
public class Opt40002 : TR
{
    /// <summary>ETF종목정보</summary>
    [DataMember, JsonProperty("ETF종목정보")]
    public SingleOpt40002? SingleResponse
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
        get => "ETF종목정보요청";
    }
    public override string TrCode
    {
        get => nameof(Opt40002);
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
    public override string[] Multiple => Array.Empty<string>();
}