using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식호가요청</summary>
public class Opt10004 : TR
{
    /// <summary>주식호가</summary>
    [DataMember, JsonProperty("주식호가")]
    public MultiOpt10004[]? MultiResponse
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
        get => "주식호가요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10004);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Multiple => new[]
    {
        "호가잔량기준시간",
        "매도10차선잔량대비",
        "매도10차선잔량",
        "매도10차선호가",
        "매도9차선잔량대비",
        "매도9차선잔량",
        "매도9차선호가",
        "매도8차선잔량대비",
        "매도8차선잔량",
        "매도8차선호가",
        "매도7차선잔량대비",
        "매도7차선잔량",
        "매도7차선호가",
        "매도6차선잔량대비",
        "매도6우선잔량",
        "매도6차선호가",
        "매도5차선잔량대비",
        "매도5차선잔량",
        "매도5차선호가",
        "매도4차선잔량대비",
        "매도4차선잔량",
        "매도4차선호가",
        "매도3차선잔량대비",
        "매도3차선잔량",
        "매도3차선호가",
        "매도2차선잔량대비",
        "매도2차선잔량",
        "매도2차선호가",
        "매도1차선잔량대비",
        "매도최우선잔량",
        "매도최우선호가",
        "매수최우선호가",
        "매수최우선잔량",
        "매수1차선잔량대비",
        "매수2차선호가",
        "매수2차선잔량",
        "매수2차선잔량대비",
        "매수3차선호가",
        "매수3차선잔량",
        "매수3차선잔량대비",
        "매수4차선호가",
        "매수4차선잔량",
        "매수4차선잔량대비",
        "매수5차선호가",
        "매수5차선잔량",
        "매수5차선잔량대비",
        "매수6우선호가",
        "매수6우선잔량",
        "매수6차선잔량대비",
        "매수7차선호가",
        "매수7차선잔량",
        "매수7차선잔량대비",
        "매수8차선호가",
        "매수8차선잔량",
        "매수8차선잔량대비",
        "매수9차선호가",
        "매수9차선잔량",
        "매수9차선잔량대비",
        "매수10차선호가",
        "매수10차선잔량",
        "매수10차선잔량대비",
        "총매도잔량직전대비",
        "총매도잔량",
        "총매수잔량",
        "총매수잔량직전대비",
        "시간외매도잔량대비",
        "시간외매도잔량",
        "시간외매수잔량",
        "시간외매수잔량대비"
    };
    public override string[] Single => Array.Empty<string>();
}