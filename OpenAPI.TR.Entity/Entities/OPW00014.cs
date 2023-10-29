using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>비밀번호일치여부요청</summary>
public class OPW00014 : TR
{
    /// <summary>비밀번호일치여부</summary>
    [DataMember, JsonProperty("비밀번호일치여부")]
    public SingleOPW00014? SingleResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.비밀번호입력매체구분
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "비밀번호입력매체구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "비밀번호일치여부요청";
    }
    public override string TrCode
    {
        get => nameof(OPW00014);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "일치여부" };
    public override string[] Multiple => Array.Empty<string>();
}