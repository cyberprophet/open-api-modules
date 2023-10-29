using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>예상체결등락률상위요청</summary>
public class Opt10029 : TR
{
    /// <summary>예상체결등락률상위</summary>
    [DataMember, JsonProperty("예상체결등락률상위")]
    public MultiOpt10029[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.정렬구분
    /// 3.거래량조건
    /// 4.종목조건
    /// 5.신용조건
    /// 6.가격조건
    /// </summary>
    public override string[] Id => new[] { "시장구분", "정렬구분", "거래량조건", "종목조건", "신용조건", "가격조건" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "예상체결등락률상위요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10029);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "예상체결가", "기준가", "전일대비기호", "전일대비", "등락률", "예상체결량", "매도잔량", "매도호가", "매수호가", "매수잔량" };
}