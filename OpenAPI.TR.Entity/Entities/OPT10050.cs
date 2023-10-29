using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW민감도지표요청</summary>
public class OPT10050 : TR
{
    /// <summary>ELW민감도지표배열</summary>
    [DataMember, JsonProperty("ELW민감도지표배열")]
    public MultiOPT10050[]? MultiResponse
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
        get => nameof(OPT10050);
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
    public override string[] Multiple => new[] { "체결시간", "현재가", "ELW이론가", "IV", "델타", "감마", "쎄타", "베가", "로", "LP" };
}