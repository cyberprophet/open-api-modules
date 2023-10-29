using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW가격급등락요청</summary>
public class OPT30001 : TR
{
    /// <summary>기준가시간</summary>
    [DataMember, JsonProperty("기준가시간")]
    public SingleOPT30001? SingleResponse
    {
        get; set;
    }
    /// <summary>ELW가격급등락</summary>
    [DataMember, JsonProperty("ELW가격급등락")]
    public MultiOPT30001[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.등락구분
    /// 2.시간구분
    /// 3.시간
    /// 4.거래량구분
    /// 5.발행사코드
    /// 6.기초자산코드
    /// 7.권리구분
    /// 8.LP코드
    /// 9.거래종료ELW제외
    /// </summary>
    public override string[] Id => new[] { "등락구분", "시간구분", "시간", "거래량구분", "발행사코드", "기초자산코드", "권리구분", "LP코드", "거래종료ELW제외" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "ELW가격급등락요청";
    }
    public override string TrCode
    {
        get => nameof(OPT30001);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "기준가시간" };
    public override string[] Multiple => new[] { "종목코드", "순위", "종목명", "대비기호", "전일대비", "거래종료ELW기준가", "현재가", "기준대비", "거래량", "급등율" };
}