using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>고저PER요청</summary>
public class Opt10026 : TR
{
    /// <summary>고저PER</summary>
    [DataMember, JsonProperty("고저PER")]
    public MultiOpt10026[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.PER구분
    /// </summary>
    public override string[] Id => new[] { "시장구분", "PER구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "고저PER요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10026);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "PER", "현재가", "전일대비기호", "전일대비", "등락률", "현재거래량", "매도호가" };
}