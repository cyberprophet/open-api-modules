using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵체결추이요청</summary>
public class OPT50006 : TR
{
    /// <summary>선옵종목명</summary>
    [DataMember, JsonProperty("선옵종목명")]
    public SingleOPT50006? SingleResponse
    {
        get; set;
    }
    /// <summary>선옵체결추이</summary>
    [DataMember, JsonProperty("선옵체결추이")]
    public MultiOPT50006[]? MultiResponse
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
        get => "선옵체결추이요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50006);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "종목명" };
    public override string[] Multiple => new[] { "체결시간", "현재가", "대비기호", "전일대비", "체결량", "누적거래량", "미결제약정", "미결제증감", "전일거래량대비", "전일거래량", "기준가" };
}