using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>당일주요거래원요청</summary>
public class Opt10040 : TR
{
    /// <summary>당일주요거래원싱글</summary>
    [DataMember, JsonProperty("당일주요거래원싱글")]
    public SingleOpt10040? SingleResponse
    {
        get; set;
    }
    /// <summary>당일주요거래원</summary>
    [DataMember, JsonProperty("당일주요거래원")]
    public MultiOpt10040[]? MultiResponse
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
        get => "당일주요거래원요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10040);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "매도거래원별증감1", "매도거래원수량1", "매도거래원1", "매도거래원코드1", "매수거래원1", "매수거래원코드1", "매수거래원수량1", "매수거래원별증감1", "매도거래원별증감2", "매도거래원수량2", "매도거래원2", "매도거래원코드2", "매수거래원2", "매수거래원코드2", "매수거래원수량2", "매수거래원별증감2", "매도거래원별증감3", "매도거래원수량3", "매도거래원3", "매도거래원코드3", "매수거래원3", "매수거래원코드3", "매수거래원수량3", "매수거래원별증감3", "매도거래원별증감4", "매도거래원수량4", "매도거래원4", "매도거래원코드4", "매수거래원4", "매수거래원코드4", "매수거래원수량4", "매수거래원별증감4", "매도거래원별증감5", "매도거래원수량5", "매도거래원5", "매도거래원코드5", "매수거래원5", "매수거래원코드5", "매수거래원수량5", "매수거래원별증감5", "외국계매도추정합변동", "외국계매도추정합", "외국계매수추정합", "외국계매수추정합변동" };
    public override string[] Multiple => new[] { "매도이탈시간", "매도수량", "매도상위이탈원", "매수이탈시간", "매수수량", "매수상위이탈원", "조회일자", "조회시간" };
}