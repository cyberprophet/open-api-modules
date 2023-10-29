using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>전업종지수요청</summary>
public class Opt20003 : TR
{
    /// <summary>전업종지수</summary>
    [DataMember, JsonProperty("전업종지수")]
    public MultiOpt20003[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.업종코드
    /// </summary>
    public override string[] Id => new[] { "업종코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "전업종지수요청";
    }
    public override string TrCode
    {
        get => nameof(Opt20003);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "대비기호", "전일대비", "등락률", "거래량", "비중", "거래대금", "상한", "상승", "보합", "하락", "하한", "상장종목수" };
}