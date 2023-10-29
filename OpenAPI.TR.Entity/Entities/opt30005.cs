using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW조건검색요청</summary>
public class Opt30005 : TR
{
    /// <summary>ELW조건검색</summary>
    [DataMember, JsonProperty("ELW조건검색")]
    public MultiOpt30005[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.발행사코드
    /// 2.기초자산코드
    /// 3.권리구분
    /// 4.LP코드
    /// 5.정렬구분
    /// </summary>
    public override string[] Id => new[] { "발행사코드", "기초자산코드", "권리구분", "LP코드", "정렬구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "ELW조건검색요청";
    }
    public override string TrCode
    {
        get => nameof(Opt30005);
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
    public override string[] Multiple => new[] { "종목코드", "발행사명", "회차", "기초자산명", "권리구분", "만기일", "현재가", "대비구분", "전일대비", "등락율", "거래량", "거래량대비", "거래대금", "전일거래량", "매도호가", "매수호가", "패리티", "기어링비율", "손익분기율", "자본지지점", "이론가", "내재변동성", "델타", "레버리지", "행사가격", "전환비율", "LP보유비율", "손익분기점", "최종거래일", "상장일", "LP초종공급일", "종목명", "잔존일수", "괴리율", "LP회원사명", "LP회원사명1", "LP회원사명2", "Xray순간체결량정리매매구분", "Xray순간체결량증거금100구분" };
}