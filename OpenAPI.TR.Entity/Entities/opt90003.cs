using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>프로그램순매수상위50요청</summary>
public class Opt90003 : TR
{
    /// <summary>프로그램순매수상위50</summary>
    [DataMember, JsonProperty("프로그램순매수상위50")]
    public MultiOpt90003[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.매매상위구분
    /// 2.금액수량구분
    /// 3.시장구분
    /// </summary>
    public override string[] Id => new[] { "매매상위구분", "금액수량구분", "시장구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "프로그램순매수상위50요청";
    }
    public override string TrCode
    {
        get => nameof(Opt90003);
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
    public override string[] Multiple => new[] { "순위", "종목코드", "종목명", "현재가", "등락기호", "전일대비", "등락율", "누적거래량", "프로그램매도금액", "프로그램매수금액", "프로그램순매수금액" };
}