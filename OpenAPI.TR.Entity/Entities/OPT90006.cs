using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>프로그램매매차익잔고추이요청</summary>
public class OPT90006 : TR
{
    /// <summary>프로그램매매차익잔고추이</summary>
    [DataMember, JsonProperty("프로그램매매차익잔고추이")]
    public MultiOPT90006[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.날짜
    /// </summary>
    public override string[] Id => new[] { "날짜" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "프로그램매매차익잔고추이요청";
    }
    public override string TrCode
    {
        get => nameof(OPT90006);
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
    public override string[] Multiple => new[] { "일자", "매수차익거래수량", "매수차익거래금액", "매수차익거래증감액", "매도차익거래수량", "매도차익거래금액", "매도차익거래증감액" };
}