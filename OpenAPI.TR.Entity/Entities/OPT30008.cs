using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW민감도지표요청</summary>
public class OPT30008 : TR
{
    /// <summary>ELW민감도지표</summary>
    [DataMember, JsonProperty("ELW민감도지표")]
    public MultiOPT30008[]? MultiResponse
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
        get => "ELW민감도지표요청";
    }
    public override string TrCode
    {
        get => nameof(OPT30008);
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
    public override string[] Multiple => new[] { "체결시간", "내재변동성", "델타", "감마", "쎄타", "베가", "로", "X-Ray순간체결량증거금100%구분" };
}