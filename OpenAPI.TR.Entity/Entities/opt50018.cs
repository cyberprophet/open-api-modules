using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>풋콜옵션비율차트요청</summary>
public class Opt50018 : TR
{
    /// <summary>풋콜옵션비율차트</summary>
    [DataMember, JsonProperty("풋콜옵션비율차트")]
    public MultiOpt50018[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시간단위
    /// </summary>
    public override string[] Id => new[] { "시간단위" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "풋콜옵션비율차트요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50018);
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
    public override string[] Multiple => new[] { "체결시간", "콜풋RATIO", "코스피200" };
}