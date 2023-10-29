using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW종목상세요청</summary>
public class Opt30006 : TR
{
    /// <summary>ELW종목상세1</summary>
    [DataMember, JsonProperty("ELW종목상세1")]
    public SingleOpt30006? SingleResponse
    {
        get; set;
    }
    /// <summary>ELW종목상세2</summary>
    [DataMember, JsonProperty("ELW종목상세2")]
    public MultiOpt30006[]? MultiResponse
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
        get => "ELW종목상세요청";
    }
    public override string TrCode
    {
        get => nameof(Opt30006);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "조기종료여부" };
    public override string[] Multiple => new[] { "이론가", "괴리율", "내재변동성", "손익분기율", "행사가격", "전환비율", "보상율", "가격상승참여율", "권리유형", "잔존일수", "주식수", "LP보유비율", "LP보유수량", "스프레드", "패리티", "기어링비율", "상장일", "최종거래일", "신주인수권행사종료일", "신주인수권행사게시일", "LP최종공급일", "지급일", "투자지표산출여부", "지급대리인", "결제방법", "권리행사방식", "한글발행기관명", "확정지급금액", "KO베리어", "XRay순간체결량증거금100%구분" };
}