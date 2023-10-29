using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW등락율순위요청</summary>
public class OPT30009 : TR
{
    /// <summary>ELW등락율순위</summary>
    [DataMember, JsonProperty("ELW등락율순위")]
    public MultiOPT30009[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.정렬구분
    /// 2.권리구분
    /// 3.거래종료제외
    /// </summary>
    public override string[] Id => new[] { "정렬구분", "권리구분", "거래종료제외" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "ELW등락율순위요청";
    }
    public override string TrCode
    {
        get => nameof(OPT30009);
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
    public override string[] Multiple => new[] { "순위", "종목코드", "종목명", "현재가", "대비기호", "전일대비", "등락률", "매도잔량", "매수잔량", "거래량", "거래대금" };
}