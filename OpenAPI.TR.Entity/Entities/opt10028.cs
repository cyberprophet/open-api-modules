using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>시가대비등락률요청</summary>
public class Opt10028 : TR
{
    /// <summary>시가대비등락률</summary>
    [DataMember, JsonProperty("시가대비등락률")]
    public MultiOpt10028[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.정렬구분
    /// 2.거래량조건
    /// 3.시장구분
    /// 4.상하한포함
    /// 5.종목조건
    /// 6.신용조건
    /// 7.거래대금조건
    /// 8.등락조건
    /// </summary>
    public override string[] Id => new[] { "정렬구분", "거래량조건", "시장구분", "상하한포함", "종목조건", "신용조건", "거래대금조건", "등락조건" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "시가대비등락률요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10028);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "등락률", "시가", "고가", "저가", "시가대비", "현재거래량", "체결강도" };
}