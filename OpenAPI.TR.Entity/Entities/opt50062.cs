using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물미결제약정분차트요청</summary>
public class Opt50062 : TR
{
    /// <summary>선물현재가정보</summary>
    [DataMember, JsonProperty("선물현재가정보")]
    public SingleOpt50062? SingleResponse
    {
        get; set;
    }
    /// <summary>선물미결제약정분차트</summary>
    [DataMember, JsonProperty("선물미결제약정분차트")]
    public MultiOpt50062[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.시간단위
    /// </summary>
    public override string[] Id => new[] { "종목코드", "시간단위" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선물미결제약정분차트요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50062);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "현재가s", "대비기호s", "전일대비s", "등락율s", "고가s", "저가s", "누적거래량s", "미결제약정s", "종목명s" };
    public override string[] Multiple => new[] { "현재가", "체결시간", "미결제약정", "미결제증감" };
}