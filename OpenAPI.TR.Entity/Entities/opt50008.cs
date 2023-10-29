using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>프로그램매매추이차트요청</summary>
public class Opt50008 : TR
{
    /// <summary>투자자별매도수금액</summary>
    [DataMember, JsonProperty("투자자별매도수금액")]
    public MultiOpt50008[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.시간구분
    /// </summary>
    public override string[] Id => new[] { "종목코드", "시간구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "프로그램매매추이차트요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50008);
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
    public override string[] Multiple => new[] { "체결시간", "투자자별매도금액", "투자자별매수금액", "투자자별순매수금액" };
}