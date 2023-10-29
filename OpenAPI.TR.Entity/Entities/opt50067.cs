using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>옵션분차트요청</summary>
public class Opt50067 : TR
{
    /// <summary>옵션분차트</summary>
    [DataMember, JsonProperty("옵션분차트")]
    public MultiOpt50067[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.시간단위
    /// </summary>
    public override string[] Id => new[] { "종목코드", "시간단위" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "옵션분차트요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50067);
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
    public override string[] Multiple => new[] { "현재가", "거래량", "체결시간", "시가", "고가", "저가", "전일종가" };
}