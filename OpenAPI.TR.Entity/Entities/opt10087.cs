using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>시간외단일가요청</summary>
public class Opt10087 : TR
{
    /// <summary>시간외단일가</summary>
    [DataMember, JsonProperty("시간외단일가")]
    public MultiOpt10087[]? MultiResponse
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
        get => "시간외단일가요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10087);
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
    public override string[] Multiple => new[] { "호가잔량기준시간", "시간외단일가_매도호가직전대비5", "시간외단일가_매도호가직전대비4", "시간외단일가_매도호가직전대비3", "시간외단일가_매도호가직전대비2", "시간외단일가_매도호가직전대비1", "시간외단일가_매도호가수량5", "시간외단일가_매도호가수량4", "시간외단일가_매도호가수량3", "시간외단일가_매도호가수량2", "시간외단일가_매도호가수량1", "시간외단일가_매도호가5", "시간외단일가_매도호가4", "시간외단일가_매도호가3", "시간외단일가_매도호가2", "시간외단일가_매도호가1", "시간외단일가_매수호가1", "시간외단일가_매수호가2", "시간외단일가_매수호가3", "시간외단일가_매수호가4", "시간외단일가_매수호가5", "시간외단일가_매수호가수량1", "시간외단일가_매수호가수량2", "시간외단일가_매수호가수량3", "시간외단일가_매수호가수량4", "시간외단일가_매수호가수량5", "시간외단일가_매수호가직전대비1", "시간외단일가_매수호가직전대비2", "시간외단일가_매수호가직전대비3", "시간외단일가_매수호가직전대비4", "시간외단일가_매수호가직전대비5", "시간외단일가_매도호가총잔량", "시간외단일가_매수호가총잔량", "매도호가총잔량직전대비", "매도호가총잔량", "매수호가총잔량", "매수호가총잔량직전대비", "시간외매도호가총잔량직전대비", "시간외매도호가총잔량", "시간외매수호가총잔량", "시간외매수호가총잔량직전대비", "시간외단일가_현재가", "시간외단일가_전일대비기호", "시간외단일가_전일대비", "시간외단일가_등락률", "시간외단일가_누적거래량" };
}