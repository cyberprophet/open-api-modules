using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물가격대별비중차트요청</summary>
public class OPT50014 : TR
{
    /// <summary>선물현재가정보</summary>
    [DataMember, JsonProperty("선물현재가정보")]
    public SingleOPT50014? SingleResponse
    {
        get; set;
    }
    /// <summary>선물가격대별비중차트</summary>
    [DataMember, JsonProperty("선물가격대별비중차트")]
    public MultiOPT50014[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.봉갯수
    /// </summary>
    public override string[] Id => new[] { "종목코드", "봉갯수" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선물가격대별비중차트요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50014);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "현재가", "대비기호", "전일대비", "등락율", "고가", "저가", "누적거래량", "미결제약정", "종목명", "누적거래대금" };
    public override string[] Multiple => new[] { "구간구분", "거래량", "비중" };
}