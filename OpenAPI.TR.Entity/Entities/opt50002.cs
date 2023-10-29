using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵일자별체결요청</summary>
public class Opt50002 : TR
{
    /// <summary>선옵종목명</summary>
    [DataMember, JsonProperty("선옵종목명")]
    public SingleOpt50002? SingleResponse
    {
        get; set;
    }
    /// <summary>선옵일자별체결</summary>
    [DataMember, JsonProperty("선옵일자별체결")]
    public MultiOpt50002[]? MultiResponse
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
        get => "선옵일자별체결요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50002);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "종목명", "현재가", "대비기호", "전일대비", "등락율", "누적거래량" };
    public override string[] Multiple => new[] { "체결일자", "현재가n", "대비기호n", "전일대비n", "등락율n", "거래량", "시가", "고가", "저가", "예상체결가", "미결제약정", "예상체결가전일종가대비기호", "예상체결가전일종가대비", "예상체결가전일종가대비등락율" };
}