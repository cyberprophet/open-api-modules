using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>당일전일체결대량요청</summary>
public class Opt10055 : TR
{
    /// <summary>당일전일체결대량</summary>
    [DataMember, JsonProperty("당일전일체결대량")]
    public MultiOpt10055[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.당일전일
    /// </summary>
    public override string[] Id => new[] { "종목코드", "당일전일" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "당일전일체결대량요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10055);
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
    public override string[] Multiple => new[] { "체결시간", "체결가", "전일대비기호", "전일대비", "등락율", "체결량", "누적거래량", "누적거래대금" };
}