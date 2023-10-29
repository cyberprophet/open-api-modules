using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>테마구성종목요청</summary>
public class Opt90002 : TR
{
    /// <summary>테마구성종목단일</summary>
    [DataMember, JsonProperty("테마구성종목단일")]
    public SingleOpt90002? SingleResponse
    {
        get; set;
    }
    /// <summary>테마구성종목</summary>
    [DataMember, JsonProperty("테마구성종목")]
    public MultiOpt90002[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.날짜구분
    /// 2.종목코드
    /// </summary>
    public override string[] Id => new[] { "날짜구분", "종목코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "테마구성종목요청";
    }
    public override string TrCode
    {
        get => nameof(Opt90002);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "등락률", "기간수익률" };
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "등락기호", "전일대비", "등락율", "누적거래량", "매도호가", "매도잔량", "매수호가", "매수잔량", "기간수익률n" };
}