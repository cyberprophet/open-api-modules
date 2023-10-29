using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵타임스프레드차트요청</summary>
public class OPT50012 : TR
{
    /// <summary>선옵타임스프레드차트</summary>
    [DataMember, JsonProperty("선옵타임스프레드차트")]
    public MultiOPT50012[]? MultiResponse
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
        get => "선옵타임스프레드차트요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50012);
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
    public override string[] Multiple => new[] { "현재가", "체결시간" };
}