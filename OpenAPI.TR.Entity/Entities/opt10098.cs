using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>시간외단일가등락율순위요청</summary>
public class Opt10098 : TR
{
    /// <summary>시간외단일가등락율순위</summary>
    [DataMember, JsonProperty("시간외단일가등락율순위")]
    public MultiOpt10098[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.정렬기준
    /// 3.종목조건
    /// 4.거래량조건
    /// 5.신용조건
    /// 6.거래대금
    /// </summary>
    public override string[] Id => new[] { "시장구분", "정렬기준", "종목조건", "거래량조건", "신용조건", "거래대금" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "시간외단일가등락율순위요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10098);
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
    public override string[] Multiple => new[] { "순위", "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "등락률", "매도총잔량", "매수총잔량", "누적거래량", "누적거래대금", "당일종가", "당일종가등락률" };
}