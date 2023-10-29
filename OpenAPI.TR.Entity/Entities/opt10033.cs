using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>신용비율상위요청</summary>
public class Opt10033 : TR
{
    /// <summary>신용비율상위</summary>
    [DataMember, JsonProperty("신용비율상위")]
    public MultiOpt10033[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.거래량구분
    /// 3.종목조건
    /// 4.상하한포함
    /// 5.신용조건
    /// </summary>
    public override string[] Id => new[] { "시장구분", "거래량구분", "종목조건", "상하한포함", "신용조건" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "신용비율상위요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10033);
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
    public override string[] Multiple => new[] { "종목정보", "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "등락률", "신용비율", "매도잔량", "매수잔량", "현재거래량" };
}