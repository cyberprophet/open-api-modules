using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW일별민감도지표요청</summary>
public class OPT10048 : TR
{
    /// <summary>ELW일별민감도지표</summary>
    [DataMember, JsonProperty("ELW일별민감도지표")]
    public MultiOPT10048[]? MultiResponse
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
        get => "ELW일별민감도지표요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10048);
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
    public override string[] Multiple => new[] { "일자", "IV", "델타", "감마", "쎄타", "베가", "로", "LP" };
}