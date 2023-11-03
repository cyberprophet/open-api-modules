using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식기본정보요청</summary>
public class Opt10001 : TR
{
    /// <summary>주식기본정보</summary>
    [DataMember, JsonProperty("주식기본정보")]
    public SingleOpt10001? SingleResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// </summary>
    public override string[] Id => new[]
    {
        "종목코드"
    };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "주식기본정보요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10001);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[]
    {
        "종목코드",
        "종목명",
        "결산월",
        "액면가",
        "자본금",
        "상장주식",
        "신용비율",
        "연중최고",
        "연중최저",
        "시가총액",
        "시가총액비중",
        "외인소진률",
        "대용가",
        "PER",
        "EPS",
        "ROE",
        "PBR",
        "EV",
        "BPS",
        "매출액",
        "영업이익",
        "당기순이익",
        "250최고",
        "250최저",
        "시가",
        "고가",
        "저가",
        "상한가",
        "하한가",
        "기준가",
        "예상체결가",
        "예상체결수량",
        "250최고가일",
        "250최고가대비율",
        "250최저가일",
        "250최저가대비율",
        "현재가",
        "대비기호",
        "전일대비",
        "등락율",
        "거래량",
        "거래대비",
        "액면가단위",
        "유통주식",
        "유통비율"
    };
    public override string[] Multiple => Array.Empty<string>();
}