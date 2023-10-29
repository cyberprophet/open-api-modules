using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물틱차트요청</summary>
public class Opt50028 : TR
{
    /// <summary>선물틱차트</summary>
    [DataMember, JsonProperty("선물틱차트")]
    public SingleOpt50028? SingleResponse
    {
        get; set;
    }
    /// <summary>선물틱차트조회</summary>
    [DataMember, JsonProperty("선물틱차트조회")]
    public MultiOpt50028[]? MultiResponse
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
        get => "선물틱차트요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50028);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "종목코드", "마지막틱갯수" };
    public override string[] Multiple => new[] { "현재가", "거래량", "체결시간", "시가", "고가", "저가", "전일종가" };
}