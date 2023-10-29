using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>외인한도소진율증가상위</summary>
public class Opt10036 : TR
{
    /// <summary>외인한도소진율증가상위</summary>
    [DataMember, JsonProperty("외인한도소진율증가상위")]
    public MultiOpt10036[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.기간
    /// </summary>
    public override string[] Id => new[] { "시장구분", "기간" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "외인한도소진율증가상위";
    }
    public override string TrCode
    {
        get => nameof(Opt10036);
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
    public override string[] Multiple => new[] { "순위", "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "거래량", "보유주식수", "취득가능주식수", "기준한도소진율", "한도소진율", "소진율증가" };
}