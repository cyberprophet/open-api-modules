using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ETF전체시세요청</summary>
public class Opt40004 : TR
{
    /// <summary>ETF전체시세</summary>
    [DataMember, JsonProperty("ETF전체시세")]
    public MultiOpt40004[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.과세유형
    /// 2.NAV대비
    /// 3.운용사
    /// 4.과세여부
    /// 5.추적지수
    /// </summary>
    public override string[] Id => new[] { "과세유형", "NAV대비", "운용사", "과세여부", "추적지수" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "ETF전체시세요청";
    }
    public override string TrCode
    {
        get => nameof(Opt40004);
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
    public override string[] Multiple => new[] { "종목코드", "종목분류", "종목명", "종가", "대비기호", "전일대비", "대비율", "거래량", "NAV", "추적오차율", "과표기준", "배당전기준", "전일배당금", "추적지수명", "배수", "추적지수코드", "추적지수", "추적등락율" };
}