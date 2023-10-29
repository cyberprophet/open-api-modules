using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물시세추이요청</summary>
public class Opt50007 : TR
{
    /// <summary>선물현재가정보</summary>
    [DataMember, JsonProperty("선물현재가정보")]
    public SingleOpt50007? SingleResponse
    {
        get; set;
    }
    /// <summary>선물시세추이</summary>
    [DataMember, JsonProperty("선물시세추이")]
    public MultiOpt50007[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.시간단위
    /// 3.시간검색
    /// </summary>
    public override string[] Id => new[] { "종목코드", "시간단위", "시간검색" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선물시세추이요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50007);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "현재가", "대비기호", "전일대비", "등락율", "시가", "고가", "저가", "누적거래량", "누적거래대금", "내재가치", "시간가치", "이론가", "괴리율" };
    public override string[] Multiple => new[] { "체결시간", "시가n", "고가n", "저가n", "현재가n", "대비기호n", "전일대비n", "체결량", "누적거래량n", "미결제약정", "미결제증감", "시장베이시스", "코스피200", "종목명", "내재가치n" };
}