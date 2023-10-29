using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식선물시세표요청</summary>
public class Opt50044 : TR
{
    /// <summary>거래량합계</summary>
    [DataMember, JsonProperty("거래량합계")]
    public SingleOpt50044? SingleResponse
    {
        get; set;
    }
    /// <summary>주식선물시세표</summary>
    [DataMember, JsonProperty("주식선물시세표")]
    public MultiOpt50044[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.근월물구분
    /// 2.입력구분
    /// </summary>
    public override string[] Id => new[] { "근월물구분", "입력구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "주식선물시세표요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50044);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "거래량합계", "거래대금합계" };
    public override string[] Multiple => new[] { "종목코드", "종목표준코드", "종목명", "현재가", "대비기호", "전일대비", "등락율", "누적거래량", "누적거래대금", "미결제약정", "미결제약정전일대비", "이론가", "괴리율", "시장베이시스", "최우선매수호가", "최우선매도호가", "코스피200" };
}