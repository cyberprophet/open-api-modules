using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종별투자자순매수요청</summary>
public class OPT10051 : TR
{
    /// <summary>업종별순매수</summary>
    [DataMember, JsonProperty("업종별순매수")]
    public MultiOPT10051[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.금액수량구분
    /// 3.기준일자
    /// </summary>
    public override string[] Id => new[] { "시장구분", "금액수량구분", "기준일자" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "업종별투자자순매수요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10051);
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
    public override string[] Multiple => new[] { "업종코드", "업종명", "현재가", "대비부호", "전일대비", "등락율", "거래량", "증권순매수", "보험순매수", "투신순매수", "은행순매수", "종신금순매수", "기금순매수", "기타법인순매수", "개인순매수", "외국인순매수", "내국인대우외국인순매수", "국가순매수", "사모펀드순매수", "기관계순매수" };
}