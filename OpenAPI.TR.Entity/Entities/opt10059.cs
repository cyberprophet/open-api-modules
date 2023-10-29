using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별투자자기관별요청</summary>
public class Opt10059 : TR
{
    /// <summary>종목별투자자기관별</summary>
    [DataMember, JsonProperty("종목별투자자기관별")]
    public MultiOpt10059[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.일자
    /// 2.종목코드
    /// 3.금액수량구분
    /// 4.매매구분
    /// 5.단위구분
    /// </summary>
    public override string[] Id => new[] { "일자", "종목코드", "금액수량구분", "매매구분", "단위구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "종목별투자자기관별요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10059);
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
    public override string[] Multiple => new[] { "일자", "현재가", "대비기호", "전일대비", "등락율", "누적거래량", "누적거래대금", "개인투자자", "외국인투자자", "기관계", "금융투자", "보험", "투신", "기타금융", "은행", "연기금등", "사모펀드", "국가", "기타법인", "내외국인" };
}