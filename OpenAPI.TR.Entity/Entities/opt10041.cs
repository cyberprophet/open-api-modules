using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>조기종료통화단위요청</summary>
public class Opt10041 : TR
{
    /// <summary>조기종료통화단위</summary>
    [DataMember, JsonProperty("조기종료통화단위")]
    public MultiOpt10041[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.영웅클럽구분
    /// </summary>
    public override string[] Id => new[] { "종목코드", "영웅클럽구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "조기종료통화단위요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10041);
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
    public override string[] Multiple => new[] { "조기종료여부", "통화단위" };
}