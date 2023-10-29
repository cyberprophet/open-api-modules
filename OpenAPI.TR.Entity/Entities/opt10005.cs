using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식일주월시분요청</summary>
public class Opt10005 : TR
{
    /// <summary>주식일주월시분</summary>
    [DataMember, JsonProperty("주식일주월시분")]
    public MultiOpt10005[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// </summary>
    public override string[] Id => new[] { "종목코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "주식일주월시분요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10005);
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
    public override string[] Multiple => new[] { "날짜", "시가", "고가", "저가", "종가", "대비", "등락률", "거래량", "거래대금", "체결강도", "외인보유", "외인비중", "외인순매수", "기관순매수", "개인순매수", "외국계", "신용잔고율", "프로그램" };
}