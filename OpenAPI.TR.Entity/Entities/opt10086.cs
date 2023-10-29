using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일별주가요청</summary>
public class Opt10086 : TR
{
    /// <summary>일별주가</summary>
    [DataMember, JsonProperty("일별주가")]
    public MultiOpt10086[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.조회일자
    /// 3.표시구분
    /// </summary>
    public override string[] Id => new[] { "종목코드", "조회일자", "표시구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "일별주가요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10086);
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
    public override string[] Multiple => new[] { "날짜", "시가", "고가", "저가", "종가", "전일비", "등락률", "거래량", "금액(백만)", "신용비", "개인", "기관", "외인수량", "외국계", "프로그램", "외인비", "체결강도", "외인보유", "외인비중", "외인순매수", "기관순매수", "개인순매수", "신용잔고율" };
}