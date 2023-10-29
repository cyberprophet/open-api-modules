using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>장중투자자별매매상위요청</summary>
public class OPT10065 : TR
{
    /// <summary>장중투자자별매매상위</summary>
    [DataMember, JsonProperty("장중투자자별매매상위")]
    public MultiOPT10065[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.매매구분
    /// 2.시장구분
    /// 3.기관구분
    /// </summary>
    public override string[] Id => new[] { "매매구분", "시장구분", "기관구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "장중투자자별매매상위요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10065);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "매도량", "매수량", "순매도" };
}