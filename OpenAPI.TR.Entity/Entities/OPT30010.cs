using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW잔량순위요청</summary>
public class OPT30010 : TR
{
    /// <summary>ELW잔량순위</summary>
    [DataMember, JsonProperty("ELW잔량순위")]
    public MultiOPT30010[]? MultiResponse
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
        get => "ELW잔량순위요청";
    }
    public override string TrCode
    {
        get => nameof(OPT30010);
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
    public override string[] Multiple => new[] { "종목코드", "순위", "종목명", "현재가", "대비기호", "전일대비", "등락률", "거래량", "매도잔량", "매수잔량", "순매수잔량", "거래대금" };
}