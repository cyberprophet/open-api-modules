using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>베이시스추이차트요청</summary>
public class Opt50016 : TR
{
    /// <summary>전일종가</summary>
    [DataMember, JsonProperty("전일종가")]
    public SingleOpt50016? SingleResponse
    {
        get; set;
    }
    /// <summary>베이시스추이차트</summary>
    [DataMember, JsonProperty("베이시스추이차트")]
    public MultiOpt50016[]? MultiResponse
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
        get => "베이시스추이차트요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50016);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "전일종가" };
    public override string[] Multiple => new[] { "체결시간", "현재가", "대비기호", "전일대비", "코스피200", "시장베이시스", "이론가", "괴리율", "거래량", "시가" };
}