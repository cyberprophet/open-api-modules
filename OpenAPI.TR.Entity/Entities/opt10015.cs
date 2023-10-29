using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일별거래상세요청</summary>
public class Opt10015 : TR
{
    /// <summary>일별거래상세</summary>
    [DataMember, JsonProperty("일별거래상세")]
    public MultiOpt10015[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.시작일자
    /// </summary>
    public override string[] Id => new[] { "종목코드", "시작일자" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "일별거래상세요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10015);
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
    public override string[] Multiple => new[] { "일자", "종가", "전일대비기호", "전일대비", "등락율", "거래량", "거래대금", "장전거래량", "장전거래비중", "장중거래량", "장중거래비중", "장후거래량", "장후거래비중", "합계3", "기간중거래량", "체결강도", "외인보유", "외인비중", "외인순매수", "기관순매수", "개인순매수", "외국계", "신용잔고율", "프로그램", "장전거래대금", "장전거래대금비중", "장중거래대금", "장중거래대금비중", "장후거래대금", "장후거래대금비중" };
}