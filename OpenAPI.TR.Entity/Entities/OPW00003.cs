using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>추정자산조회요청</summary>
public class OPW00003 : TR
{
    /// <summary>추정자산조회</summary>
    [DataMember, JsonProperty("추정자산조회")]
    public SingleOPW00003? SingleResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.상장폐지조회구분
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "상장폐지조회구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "추정자산조회요청";
    }
    public override string TrCode
    {
        get => nameof(OPW00003);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "추정예탁자산" };
    public override string[] Multiple => Array.Empty<string>();
}