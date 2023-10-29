using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>잔량율급증요청</summary>
public class OPT10022 : TR
{
    /// <summary>잔량율급증</summary>
    [DataMember, JsonProperty("잔량율급증")]
    public MultiOPT10022[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.비율구분
    /// 3.시간구분
    /// 4.거래량구분
    /// 5.종목조건
    /// </summary>
    public override string[] Id => new[] { "시장구분", "비율구분", "시간구분", "거래량구분", "종목조건" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "잔량율급증요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10022);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "기준률", "현재비율", "급증률", "총매도잔량", "총매수잔량" };
}