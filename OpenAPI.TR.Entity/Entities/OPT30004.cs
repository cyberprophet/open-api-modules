using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW괴리율요청</summary>
public class OPT30004 : TR
{
    /// <summary>ELW괴리율</summary>
    [DataMember, JsonProperty("ELW괴리율")]
    public MultiOPT30004[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.발행사코드
    /// 2.기초자산코드
    /// 3.권리구분
    /// 4.LP코드
    /// 5.거래종료ELW제외
    /// </summary>
    public override string[] Id => new[] { "발행사코드", "기초자산코드", "권리구분", "LP코드", "거래종료ELW제외" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "ELW괴리율요청";
    }
    public override string TrCode
    {
        get => nameof(OPT30004);
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
    public override string[] Multiple => new[] { "종목코드", "발행사명", "회차", "기초자산명", "권리구분", "괴리율", "베이시스", "잔존일수", "이론가", "현재가", "대비구분", "전일대비", "등락율", "거래량", "종목명" };
}