using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>전일대비등락률상위요청</summary>
public class Opt10027 : TR
{
    /// <summary>전일대비등락률상위</summary>
    [DataMember, JsonProperty("전일대비등락률상위")]
    public MultiOpt10027[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.정렬구분
    /// 3.거래량조건
    /// 4.종목조건
    /// 5.신용조건
    /// 6.상하한포함
    /// 7.가격조건
    /// 8.거래대금조건
    /// </summary>
    public override string[] Id => new[] { "시장구분", "정렬구분", "거래량조건", "종목조건", "신용조건", "상하한포함", "가격조건", "거래대금조건" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "전일대비등락률상위요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10027);
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
    public override string[] Multiple => new[] { "종목분류", "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "등락률", "매도잔량", "매수잔량", "현재거래량", "체결강도", "횟수" };
}