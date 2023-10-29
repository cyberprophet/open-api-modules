using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일별변동성분석그래프요청</summary>
public class OPT50024 : TR
{
    /// <summary>일별변동성분석그래프</summary>
    [DataMember, JsonProperty("일별변동성분석그래프")]
    public MultiOPT50024[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.역사적변동성1
    /// 2.역사적변동성2
    /// 3.역사적변동성3
    /// 4.기간
    /// </summary>
    public override string[] Id => new[] { "역사적변동성1", "역사적변동성2", "역사적변동성3", "기간" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "일별변동성분석그래프요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50024);
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
    public override string[] Multiple => new[] { "일자", "대표내재변동성", "콜내재변동성", "풋내재변동성", "선물대표내재변동성", "선물콜내재변동성", "선물풋내재변동성", "역사적변동성1", "역사적변동성2", "역사적변동성3", "선물역사적변동성1", "선물역사적변동성2", "선물역사적변동성3", "시작일자" };
}