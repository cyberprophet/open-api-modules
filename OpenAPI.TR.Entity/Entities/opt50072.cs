using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물월차트요청</summary>
public class Opt50072 : TR
{
    /// <summary>선물월차트</summary>
    [DataMember, JsonProperty("선물월차트")]
    public MultiOpt50072[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.기준일자
    /// </summary>
    public override string[] Id => new[] { "종목코드", "기준일자" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선물월차트요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50072);
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
    public override string[] Multiple => new[] { "현재가", "누적거래량", "일자", "시가", "고가", "저가", "전일종가" };
}