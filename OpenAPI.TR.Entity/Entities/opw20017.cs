using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>신용융자 가능문의</summary>
public class Opw20017 : TR
{
    /// <summary>신용융자가능여부</summary>
    [DataMember, JsonProperty("신용융자가능여부")]
    public SingleOpw20017? SingleResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// </summary>
    public override string[] Id => new[] { "종목코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "신용융자 가능문의";
    }
    public override string TrCode
    {
        get => nameof(Opw20017);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "신용가능여부" };
    public override string[] Multiple => Array.Empty<string>();
}