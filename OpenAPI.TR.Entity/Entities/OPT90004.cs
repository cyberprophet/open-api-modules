using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별프로그램매매현황요청</summary>
public class OPT90004 : TR
{
    /// <summary>종목별프로그램매매합계</summary>
    [DataMember, JsonProperty("종목별프로그램매매합계")]
    public SingleOPT90004? SingleResponse
    {
        get; set;
    }
    /// <summary>종목별프로그램매매현황</summary>
    [DataMember, JsonProperty("종목별프로그램매매현황")]
    public MultiOPT90004[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.일자
    /// 2.시장구분
    /// </summary>
    public override string[] Id => new[] { "일자", "시장구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "종목별프로그램매매현황요청";
    }
    public override string TrCode
    {
        get => nameof(OPT90004);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "합계1", "합계2", "합계3", "합계4", "합계5", "합계6" };
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "등락기호", "전일대비", "매수체결수량", "매수체결금액", "매도체결수량", "매도체결금액", "순매수대금", "전체거래비율" };
}