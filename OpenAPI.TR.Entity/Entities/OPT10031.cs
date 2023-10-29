using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>전일거래량상위요청</summary>
public class OPT10031 : TR
{
    /// <summary>전일거래량상위</summary>
    [DataMember, JsonProperty("전일거래량상위")]
    public MultiOPT10031[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.조회구분
    /// 3.순위시작
    /// 4.순위끝
    /// </summary>
    public override string[] Id => new[] { "시장구분", "조회구분", "순위시작", "순위끝" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "전일거래량상위요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10031);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "거래량" };
}