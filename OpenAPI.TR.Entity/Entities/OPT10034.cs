using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>외인기간별매매상위요청</summary>
public class OPT10034 : TR
{
    /// <summary>외인기간별매매상위</summary>
    [DataMember, JsonProperty("외인기간별매매상위")]
    public MultiOPT10034[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.매매구분
    /// 3.기간
    /// </summary>
    public override string[] Id => new[] { "시장구분", "매매구분", "기간" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "외인기간별매매상위요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10034);
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
    public override string[] Multiple => new[] { "순위", "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "매도호가", "매수호가", "거래량", "순매수량", "취득가능주식수" };
}