using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>프로그램매매추이요청</summary>
public class Opt10001 : TR
{
    /// <summary>프로그램매매추이</summary>
    [DataMember, JsonProperty("프로그램매매추이")]
    public MultiOpt10001[]? MultiResponse
    {
        get; set;
    }
    public override string[] Id => new[] { "날짜", "시간구분", "금액수량구분", "시장구분", "분틱구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "프로그램매매추이요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10001);
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
    public override string[] Multiple => new[] { "체결시간", "일자", "차익거래매도", "차익거래매수", "차익거래순매수", "비차익거래매도", "비차익거래매수", "비차익거래순매수", "차익거래매도수량", "차익거래매수수량", "차익거래순매수수량", "비차익거래매도수량", "비차익거래매수수량", "비차익거래순매수수량", "전체매도", "전체매수", "전체순매수", "KOSPI200", "BASIS" };
}