using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식거래원요청</summary>
public class Opt10002 : TR
{
    /// <summary>주식거래원</summary>
    [DataMember, JsonProperty("주식거래원")]
    public MultiOpt10002[]? MultiResponse
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
        get => "주식거래원요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10002);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "등락부호", "기준가", "전일대비", "등락율", "매도거래원명1", "매도거래원1", "매도거래량1", "매수거래원명1", "매수거래원1", "매수거래량1", "매도거래원명2", "매도거래원2", "매도거래량2", "매수거래원명2", "매수거래원2", "매수거래량2", "매도거래원명3", "매도거래원3", "매도거래량3", "매수거래원명3", "매수거래원3", "매수거래량3", "매도거래원명4", "매도거래원4", "매도거래량4", "매수거래원명4", "매수거래원4", "매수거래량4", "매도거래원명5", "매도거래원5", "매도거래량5", "매수거래원명5", "매수거래원5", "매수거래량5" };
}