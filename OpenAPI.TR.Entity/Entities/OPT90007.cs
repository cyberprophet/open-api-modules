using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>프로그램매매누적추이요청</summary>
public class OPT90007 : TR
{
    /// <summary>프로그램매매누적추이</summary>
    [DataMember, JsonProperty("프로그램매매누적추이")]
    public MultiOPT90007[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.날짜
    /// 2.금액수량구분
    /// 3.시장구분
    /// </summary>
    public override string[] Id => new[] { "날짜", "금액수량구분", "시장구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "프로그램매매누적추이요청";
    }
    public override string TrCode
    {
        get => nameof(OPT90007);
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
    public override string[] Multiple => new[] { "일자", "KOSPI200", "BASIS", "차익거래당일", "차익거래누적", "비차익거래당일", "비차익거래누적", "전체당일", "전체누적" };
}