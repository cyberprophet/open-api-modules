using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>장중투자자별매매차트요청</summary>
public class Opt10064 : TR
{
    /// <summary>장중투자자별매매차트</summary>
    [DataMember, JsonProperty("장중투자자별매매차트")]
    public MultiOpt10064[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.금액수량구분
    /// 3.매매구분
    /// 4.종목코드
    /// </summary>
    public override string[] Id => new[] { "시장구분", "금액수량구분", "매매구분", "종목코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "장중투자자별매매차트요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10064);
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
    public override string[] Multiple => new[] { "시간", "외국인투자자", "기관계", "투신", "보험", "은행", "연기금등", "기타법인", "국가" };
}