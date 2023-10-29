using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>외국계창구매매상위요청</summary>
public class Opt10037 : TR
{
    /// <summary>외국계창구매매상위</summary>
    [DataMember, JsonProperty("외국계창구매매상위")]
    public MultiOpt10037[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.기간
    /// 3.매매구분
    /// 4.정렬구분
    /// 5.현재가조건
    /// </summary>
    public override string[] Id => new[] { "시장구분", "기간", "매매구분", "정렬구분", "현재가조건" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "외국계창구매매상위요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10037);
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
    public override string[] Multiple => new[] { "순위", "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "등락율", "매도거래량", "매수거래량", "순매수거래량", "순매수대금", "거래량", "거래대금" };
}