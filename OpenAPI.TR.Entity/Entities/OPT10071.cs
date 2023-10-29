using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>시간대별전일비거래비중요청</summary>
public class OPT10071 : TR
{
    /// <summary>시간대별전일비거래비중</summary>
    [DataMember, JsonProperty("시간대별전일비거래비중")]
    public MultiOPT10071[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.시간구분
    /// </summary>
    public override string[] Id => new[] { "종목코드", "시간구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "시간대별전일비거래비중요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10071);
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
    public override string[] Multiple => new[] { "시간", "현재가", "대비기호", "전일대비", "대비율", "체결거래량", "누적거래량", "순간비율", "누적비율" };
}