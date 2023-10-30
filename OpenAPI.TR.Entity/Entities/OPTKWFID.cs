using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>관심종목정보요청</summary>
public class OPTKWFID : TR
{
    /// <summary>관심종목정보</summary>
    [DataMember, JsonProperty("관심종목정보")]
    public MultiOPTKWFID[]? MultiResponse
    {
        get; set;
    }
    public override string[] Id
    {
        get => Array.Empty<string>();
    }
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "관심종목정보요청";
    }
    public override string TrCode
    {
        get => nameof(OPTKWFID);
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
    public override string[] Multiple => new[]
    {
        "종목코드",
        "종목명",
        "현재가",
        "기준가",
        "전일대비",
        "전일대비기호",
        "등락율",
        "거래량",
        "거래대금",
        "체결량",
        "체결강도",
        "전일거래량대비",
        "매도호가",
        "매수호가",
        "매도1차호가",
        "매도2차호가",
        "매도3차호가",
        "매도4차호가",
        "매도5차호가",
        "매수1차호가",
        "매수2차호가",
        "매수3차호가",
        "매수4차호가",
        "매수5차호가",
        "상한가",
        "하한가",
        "시가",
        "고가",
        "저가",
        "종가",
        "체결시간",
        "예상체결가",
        "예상체결량",
        "자본금",
        "액면가",
        "시가총액",
        "주식수",
        "호가시간",
        "일자",
        "우선매도잔량",
        "우선매수잔량",
        "우선매도건수",
        "우선매수건수",
        "총매도잔량",
        "총매수잔량",
        "총매도건수",
        "총매수건수",
        "패리티",
        "기어링",
        "손익분기",
        "자본지지",
        "ELW행사가",
        "전환비율",
        "ELW만기일",
        "미결제약정",
        "미결제전일대비",
        "이론가",
        "내재변동성",
        "델타",
        "감마",
        "쎄타",
        "베가",
        "로"
    };
    protected internal override string LookupScreenNo
    {
        get => (count++ + 7000).ToString("D4");
    }
    static uint count;
}