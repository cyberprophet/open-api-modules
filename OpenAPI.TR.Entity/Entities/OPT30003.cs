using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELWLP보유일별추이요청</summary>
public class OPT30003 : TR
{
    /// <summary>ELWLP보유일별추이</summary>
    [DataMember, JsonProperty("ELWLP보유일별추이")]
    public MultiOPT30003[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.기초자산코드
    /// 2.기준일자
    /// </summary>
    public override string[] Id => new[] { "기초자산코드", "기준일자" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "ELWLP보유일별추이요청";
    }
    public override string TrCode
    {
        get => nameof(OPT30003);
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
    public override string[] Multiple => new[] { "일자", "현재가", "대비구분", "전일대비", "등락율", "거래량", "거래대금", "변동수량", "LP보유수량", "비중" };
}