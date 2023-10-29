using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종현재가일별요청</summary>
public class Opt20009 : TR
{
    /// <summary>업종현재가일별</summary>
    [DataMember, JsonProperty("업종현재가일별")]
    public SingleOpt20009? SingleResponse
    {
        get; set;
    }
    /// <summary>업종현재가_일별반복</summary>
    [DataMember, JsonProperty("업종현재가_일별반복")]
    public MultiOpt20009[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.업종코드
    /// </summary>
    public override string[] Id => new[] { "시장구분", "업종코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "업종현재가일별요청";
    }
    public override string TrCode
    {
        get => nameof(Opt20009);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "현재가", "전일대비기호", "전일대비", "등락률", "거래량", "거래대금", "거래형성종목수", "거래형성비율", "시가", "고가", "저가", "상한", "상승", "보합", "하락", "하한", "52주최고가", "52주최고가일", "52주최고가대비율", "52주최저가", "52주최저가일", "52주최저가대비율" };
    public override string[] Multiple => new[] { "일자n", "현재가n", "전일대비기호n", "전일대비n", "등락률n", "누적거래량n" };
}