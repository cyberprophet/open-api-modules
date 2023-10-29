using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식기관요청</summary>
public class OPT10009 : TR
{
    /// <summary>주식기관</summary>
    [DataMember, JsonProperty("주식기관")]
    public MultiOPT10009[]? MultiResponse
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
        get => "주식기관요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10009);
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
    public override string[] Multiple => new[] { "날짜", "종가", "대비", "기관기간누적", "기관일변순매매", "외국인일변순매매", "외국인지분율" };
}