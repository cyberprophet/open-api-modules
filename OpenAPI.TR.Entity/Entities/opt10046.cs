using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>체결강도추이시간별요청</summary>
public class Opt10046 : TR
{
    /// <summary>체결강도시간별</summary>
    [DataMember, JsonProperty("체결강도시간별")]
    public MultiOpt10046[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.틱구분
    /// 3.체결강도구분
    /// </summary>
    public override string[] Id => new[] { "종목코드", "틱구분", "체결강도구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "체결강도추이시간별요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10046);
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
    public override string[] Multiple => new[] { "체결시간", "현재가", "전일대비", "전일대비기호", "등락율", "거래량", "누적거래대금", "누적거래량", "체결강도", "체결강도5분", "체결강도20분", "체결강도60분" };
}