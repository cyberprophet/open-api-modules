using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>거래대금상위요청</summary>
public class OPT10032 : TR
{
    /// <summary>거래대금상위</summary>
    [DataMember, JsonProperty("거래대금상위")]
    public MultiOPT10032[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.관리종목포함
    /// </summary>
    public override string[] Id => new[] { "시장구분", "관리종목포함" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "거래대금상위요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10032);
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
    public override string[] Multiple => new[] { "종목코드", "현재순위", "전일순위", "종목명", "현재가", "전일대비기호", "전일대비", "등락률", "매도호가", "매수호가", "현재거래량", "전일거래량", "거래대금" };
}