using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>대차거래추이요청</summary>
public class OPT10068 : TR
{
    /// <summary>대차거래추이</summary>
    [DataMember, JsonProperty("대차거래추이")]
    public MultiOPT10068[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시작일자
    /// 2.종료일자
    /// 3.전체구분
    /// 4.종목코드
    /// </summary>
    public override string[] Id => new[] { "시작일자", "종료일자", "전체구분", "종목코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "대차거래추이요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10068);
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
    public override string[] Multiple => new[] { "일자", "대차거래체결주수", "대차거래상환주수", "대차거래증감", "잔고주수", "잔고금액" };
}