using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW종목상세요청</summary>
public class OPT30007 : TR
{
    /// <summary>ELW종목상세</summary>
    [DataMember, JsonProperty("ELW종목상세")]
    public MultiOPT30007[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.발행사코드
    /// 2.기초자산코드
    /// 3.권리구분
    /// 4.LP코드
    /// 5.정렬구분
    /// 6.거래종료ELW제외
    /// </summary>
    public override string[] Id => new[] { "발행사코드", "기초자산코드", "권리구분", "LP코드", "정렬구분", "거래종료ELW제외" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "ELW종목상세요청";
    }
    public override string TrCode
    {
        get => nameof(OPT30007);
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
    public override string[] Multiple => new[] { "기초자산코드", "발행사명", "회차", "기초자산명", "콜풋구분", "신주인수권행사종료일", "잔존일수", "현재가", "대비기호", "전일대비", "등락율", "누적거래량", "거래량대비", "누적거래대금", "매도호가", "매수호가", "패리티", "기어링비율", "손익분기율", "자본지지점", "이론가", "내재변동성", "델타", "레버리지", "LP보유비율", "행사가격", "전환비율", "최종거래일", "종목명", "조기종료여부", "KO접근도" };
}