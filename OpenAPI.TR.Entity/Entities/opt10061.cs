using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별투자자기관별합계요청</summary>
public class Opt10061 : TR
{
    /// <summary>종목별투자자기관별합계</summary>
    [DataMember, JsonProperty("종목별투자자기관별합계")]
    public MultiOpt10061[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.시작일자
    /// 3.종료일자
    /// 4.금액수량구분
    /// 5.매매구분
    /// 6.단위구분
    /// </summary>
    public override string[] Id => new[] { "종목코드", "시작일자", "종료일자", "금액수량구분", "매매구분", "단위구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "종목별투자자기관별합계요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10061);
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
    public override string[] Multiple => new[] { "개인투자자", "외국인투자자", "기관계", "금융투자", "보험", "투신", "기타금융", "은행", "연기금등", "사모펀드", "국가", "기타법인", "내외국인" };
}