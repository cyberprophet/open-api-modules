using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>거래원별ELW순매매상위요청</summary>
public class OPT30002 : TR
{
    /// <summary>거래원별ELW순매매상위</summary>
    [DataMember, JsonProperty("거래원별ELW순매매상위")]
    public MultiOPT30002[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.발행사코드
    /// 2.거래량구분
    /// 3.매매구분
    /// 4.기간
    /// 5.거래종료ELW제외
    /// </summary>
    public override string[] Id => new[] { "발행사코드", "거래량구분", "매매구분", "기간", "거래종료ELW제외" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "거래원별ELW순매매상위요청";
    }
    public override string TrCode
    {
        get => nameof(OPT30002);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "주가등락", "등락율", "거래량", "순매수", "매수거래량", "매도거래량" };
}