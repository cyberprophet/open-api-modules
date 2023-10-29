using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>당일상위이탈원요청</summary>
public class Opt10053 : TR
{
    /// <summary>당일상위이탈원</summary>
    [DataMember, JsonProperty("당일상위이탈원")]
    public MultiOpt10053[]? MultiResponse
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
        get => "당일상위이탈원요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10053);
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
    public override string[] Multiple => new[] { "매도이탈시간", "매도수량", "매도상위이탈원", "매수이탈시간", "매수수량", "매수상위이탈원", "조회일자", "조회시간" };
}