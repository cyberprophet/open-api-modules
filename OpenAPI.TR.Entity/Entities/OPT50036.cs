using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주요지수변동성차트요청</summary>
public class OPT50036 : TR
{
    /// <summary>주요지수변동성차트</summary>
    [DataMember, JsonProperty("주요지수변동성차트")]
    public MultiOPT50036[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.기준일자
    /// 3.기간
    /// 4.차트구분
    /// </summary>
    public override string[] Id => new[] { "종목코드", "기준일자", "기간", "차트구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "주요지수변동성차트요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50036);
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
    public override string[] Multiple => new[] { "일자", "전일종가", "선물역사적변동성" };
}