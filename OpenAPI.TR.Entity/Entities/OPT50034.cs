using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵전일가격요청</summary>
public class OPT50034 : TR
{
    /// <summary>선옵전일가격</summary>
    [DataMember, JsonProperty("선옵전일가격")]
    public MultiOPT50034[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.기간
    /// </summary>
    public override string[] Id => new[] { "종목코드", "기간" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선옵전일가격요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50034);
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
    public override string[] Multiple => new[] { "현재가", "체결시간" };
}