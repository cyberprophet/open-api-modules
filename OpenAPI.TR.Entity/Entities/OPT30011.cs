using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW근접율요청</summary>
public class OPT30011 : TR
{
    /// <summary>ELW근접율</summary>
    [DataMember, JsonProperty("ELW근접율")]
    public MultiOPT30011[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// </summary>
    public override string[] Id => new[] { "종목코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "ELW근접율요청";
    }
    public override string TrCode
    {
        get => nameof(OPT30011);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "대비기호", "전일대비", "등락율", "누적거래량", "근접율" };
}