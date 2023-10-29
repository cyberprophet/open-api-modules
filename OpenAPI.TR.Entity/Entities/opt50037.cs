using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>코스피200지수요청</summary>
public class Opt50037 : TR
{
    /// <summary>코스피200지수</summary>
    [DataMember, JsonProperty("코스피200지수")]
    public MultiOpt50037[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.기준일자
    /// </summary>
    public override string[] Id => new[] { "종목코드", "기준일자" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "코스피200지수요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50037);
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
    public override string[] Multiple => new[] { "일자", "코스피200" };
}