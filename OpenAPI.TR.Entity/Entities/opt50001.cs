using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵현재가정보요청</summary>
public class Opt50001 : TR
{
    /// <summary>선옵현재가정보</summary>
    [DataMember, JsonProperty("선옵현재가정보")]
    public SingleOpt50001? SingleResponse
    {
        get; set;
    }
    /// <summary>선옵시간대별체결</summary>
    [DataMember, JsonProperty("선옵시간대별체결")]
    public MultiOpt50001[]? MultiResponse
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
        get => "선옵현재가정보요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50001);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "현재가", "대비기호", "전일대비", "등락율", "거래량", "거래량대비", "기준가", "이론가", "이론베이시스", "괴리도", "괴리율", "시장베이시스", "누적거래대금", "상한가", "하한가", "CB상한가", "CB하한가", "대용가", "최종거래일", "잔존일수", "영업일기준잔존일", "상장중최고가", "상장중최고가대비율", "상장중최고가일", "상장중최저가", "상장중최저가대비율", "상장중최저가일", "종목명", "호가시간", "매도수익율5", "매도건수5", "매도수량5", "매도수익율4", "매도건수4", "매도수량4", "매도호가4", "매도호가5", "매도수익율3", "매도건수3", "매도수량3", "매도호가3", "매도수익율2", "매도건수2", "매도수량2", "매도호가2", "매도수익율1", "매도건수1", "매도수량1", "매도호가1", "매수호가1", "매수수량1", "매수건수1", "매수수익율1", "매수호가2", "매수수량2", "매수건수2", "매수수익율2", "매수호가3", "매수수량3", "매수건수3", "매수수익율3", "매수호가4", "매수수량4", "매수건수4", "매수수익율4", "매수호가5", "매수수량5", "매수건수5", "매수수익율5", "시가", "고가", "저가", "2차저항", "1차저항", "피봇", "1차저지", "2차저지", "미결제약정", "미결제약정전일대비", "매도호가총건수", "매도호가총잔량", "순매수잔량", "매수호가총잔량", "매수호가총건수", "매도호가총잔량직전대비", "매수호가총잔량직전대비", "예상체결가", "예상체결가전일종가대비기호", "예상체결가전일종가대비", "예상체결가전일종가대비등락율", "이자율" };
    public override string[] Multiple => new[] { "체결시간", "현재가n", "대비기호n", "전일대비n", "체결량", "미결제약정n", "코스피200", "시장베이시스n", "역사적변동성", "표면이자", "배당액지수", "기준가n", "등락율n", "누적거래량" };
}