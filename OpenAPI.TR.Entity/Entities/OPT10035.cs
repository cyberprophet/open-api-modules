using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>외인연속순매매상위요청</summary>
public class OPT10035 : TR
{
    /// <summary>외인연속순매매상위</summary>
    [DataMember, JsonProperty("외인연속순매매상위")]
    public MultiOPT10035[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.매매구분
    /// 3.기준일구분
    /// </summary>
    public override string[] Id => new[] { "시장구분", "매매구분", "기준일구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "외인연속순매매상위요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10035);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "D-1", "D-2", "D-3", "합계", "한도소진율", "전일대비1", "전일대비2", "전일대비3" };
}