using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF일자별체결요청</summary>
public class Opt40008 : TR
{
    /// <summary>ETF일자별체결</summary>
    [DataMember, JsonProperty("ETF일자별체결")]
    public SingleOpt40008? SingleResponse
    {
        get; set;
    }
    /// <summary>ETF순매수수량배열</summary>
    [DataMember, JsonProperty("ETF순매수수량배열")]
    public MultiOpt40008[]? MultiResponse
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
        get => "ETF일자별체결요청";
    }
    public override string TrCode
    {
        get => nameof(Opt40008);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "체결시간", "현재가", "대비기호", "전일대비", "거래량" };
    public override string[] Multiple => new[] { "일자", "현재가n", "대비기호n", "전일대비n", "누적거래량", "외인순매수수량", "기관순매수수량" };
}