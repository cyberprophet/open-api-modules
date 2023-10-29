using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>대차거래상위10종목요청</summary>
public class Opt99999 : TR
{
    /// <summary>대차거래상위10종목합계</summary>
    [DataMember, JsonProperty("대차거래상위10종목합계")]
    public MultiOpt99999[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시작일자
    /// 2.종료일자
    /// 3.시장구분
    /// </summary>
    public override string[] Id => new[] { "시작일자", "종료일자", "시장구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "대차거래상위10종목요청";
    }
    public override string TrCode
    {
        get => nameof(Opt99999);
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
    public override string[] Multiple => new[] { "일자1", "일자2", "일자3", "일자4", "일자5", "일자6", "일자7", "일자8" };
}