using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식선물거래량상위종목요청</summary>
public class OPT50043 : TR
{
    /// <summary>주식선물거래량상위종목</summary>
    [DataMember, JsonProperty("주식선물거래량상위종목")]
    public MultiOPT50043[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.거래대금구분
    /// </summary>
    public override string[] Id => new[] { "거래대금구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "주식선물거래량상위종목요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50043);
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
    public override string[] Multiple => new[] { "종목코드", "종목표준코드", "종목명", "현재가", "대비기호", "전일대비", "등락율", "누적거래량" };
}