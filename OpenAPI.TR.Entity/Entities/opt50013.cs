using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물가격대별비중차트요청</summary>
public class Opt50013 : TR
{
    /// <summary>선물가격대별비중차트</summary>
    [DataMember, JsonProperty("선물가격대별비중차트")]
    public MultiOpt50013[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.봉갯수
    /// </summary>
    public override string[] Id => new[] { "종목코드", "봉갯수" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선물가격대별비중차트요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50013);
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
    public override string[] Multiple => new[] { "현재가", "거래량", "체결시간" };
}