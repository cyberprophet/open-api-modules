using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>고저가근접요청</summary>
public class OPT10018 : TR
{
    /// <summary>고저가근접</summary>
    [DataMember, JsonProperty("고저가근접")]
    public MultiOPT10018[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.고저구분
    /// 2.근접율
    /// 3.시장구분
    /// 4.거래량구분
    /// 5.종목조건
    /// 6.신용조건
    /// </summary>
    public override string[] Id => new[] { "고저구분", "근접율", "시장구분", "거래량구분", "종목조건", "신용조건" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "고저가근접요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10018);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "등락률", "거래량", "매도호가", "매수호가", "당일고가", "당일저가" };
}