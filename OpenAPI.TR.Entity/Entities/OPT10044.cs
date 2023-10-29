using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일별기관매매종목요청</summary>
public class OPT10044 : TR
{
    /// <summary>일별기관매매종목</summary>
    [DataMember, JsonProperty("일별기관매매종목")]
    public MultiOPT10044[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시작일자
    /// 2.종료일자
    /// 3.매매구분
    /// 4.시장구분
    /// </summary>
    public override string[] Id => new[] { "시작일자", "종료일자", "매매구분", "시장구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "일별기관매매종목요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10044);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "순매수수량", "순매수금액", "추정평균가", "현재가", "평균가대비", "대비율" };
}