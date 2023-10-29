using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>베이시스추이차트요청</summary>
public class Opt50017 : TR
{
    /// <summary>베이시스추이차트</summary>
    [DataMember, JsonProperty("베이시스추이차트")]
    public MultiOpt50017[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.시간단위
    /// </summary>
    public override string[] Id => new[] { "종목코드", "시간단위" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "베이시스추이차트요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50017);
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
    public override string[] Multiple => new[] { "현재가", "체결시간", "거래량", "시장베이시스", "시가", "고가", "저가", "괴리율" };
}