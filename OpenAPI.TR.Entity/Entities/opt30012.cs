using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW종목상세정보요청</summary>
public class Opt30012 : TR
{
    /// <summary>ELW종목상세정보</summary>
    [DataMember, JsonProperty("ELW종목상세정보")]
    public SingleOpt30012? SingleResponse
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
        get => "ELW종목상세정보요청";
    }
    public override string TrCode
    {
        get => nameof(Opt30012);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "자산코드", "현재가", "전일대비기호", "전일대비", "등락율", "LP회원사명", "LP회원사명1", "LP회원사명2", "ELW권리내용", "ELW만기평가가격", "ELW이론가", "괴리율", "ELW내재변동성", "예상권리가", "ELW손익분기율", "ELW행사가", "ELW전환비율", "ELW보상율", "ELW가격상승참여율", "ELW권리유형", "ELW잔존일수", "주식수", "ELW LP주문가능", "LP보유비율", "LP보유수량", "ELW스프레드", "ELW패리티", "ELW기어링", "ELW상장일", "ELW최종거래일", "만기일", "행사일", "LP공급종료일", "ELW지급일", "ELW투자지표산출", "ELW지급대리인", "ELW결재방법", "ELW권리행사방식", "ELW발행기관", "확정지급액", "KO베리어", "IV", "종기종료ELW발생", "기초자산1", "기초자산구성비율1", "기초자산2", "기초자산구성비율2", "기초자산3", "기초자산구성비율3", "기초자산4", "기초자산구성비율4", "기초자산5", "기초자산구성비율5", "평가시작일자", "평가종료일자", "평가시작시간", "평가종료시간", "평가가격", "평가완료여부", "전체최고가", "전체최저가", "직후최고가", "직후최저가", "후반장최고가", "후반장최저가" };
    public override string[] Multiple => Array.Empty<string>();
}