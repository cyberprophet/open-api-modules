using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>당일거래량상위요청</summary>
public class Opt10030 : TR
{
    /// <summary>당일거래량상위</summary>
    [DataMember, JsonProperty("당일거래량상위")]
    public MultiOpt10030[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.정렬구분
    /// 3.관리종목포함
    /// 4.신용구분
    /// 5.거래량구분
    /// 6.가격구분
    /// 7.거래대금구분
    /// 8.장운영구분
    /// </summary>
    public override string[] Id => new[] { "시장구분", "정렬구분", "관리종목포함", "신용구분", "거래량구분", "가격구분", "거래대금구분", "장운영구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "당일거래량상위요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10030);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "등락률", "거래량", "전일비", "거래회전율", "거래금액" };
}