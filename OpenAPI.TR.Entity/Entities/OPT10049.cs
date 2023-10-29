using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW투자지표요청</summary>
public class OPT10049 : TR
{
    /// <summary>ELW투자지표</summary>
    [DataMember, JsonProperty("ELW투자지표")]
    public SingleOPT10049? SingleResponse
    {
        get; set;
    }
    /// <summary>ELW투자지표배열</summary>
    [DataMember, JsonProperty("ELW투자지표배열")]
    public MultiOPT10049[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.연속구분
    /// 2.연속키
    /// 3.종목코드
    /// </summary>
    public override string[] Id => new[] { "연속구분", "연속키", "종목코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "ELW투자지표요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10049);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "연속구분", "연속키" };
    public override string[] Multiple => new[] { "시간", "패리티", "프리미엄", "기어링비율", "손익분기율", "현재가", "레버리지" };
}