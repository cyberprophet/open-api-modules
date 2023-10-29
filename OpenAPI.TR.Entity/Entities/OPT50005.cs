using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵시간별거래량요청</summary>
public class OPT50005 : TR
{
    /// <summary>선옵시간별거래량</summary>
    [DataMember, JsonProperty("선옵시간별거래량")]
    public MultiOPT50005[]? MultiResponse
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
        get => "선옵시간별거래량요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50005);
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
    public override string[] Multiple => new[] { "체결시간", "미결제약정", "누적거래량", "체결량" };
}