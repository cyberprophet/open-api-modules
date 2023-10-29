using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>신용매매동향요청</summary>
public class Opt10013 : TR
{
    /// <summary>신용매매동향</summary>
    [DataMember, JsonProperty("신용매매동향")]
    public MultiOpt10013[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.일자
    /// 3.조회구분
    /// </summary>
    public override string[] Id => new[] { "종목코드", "일자", "조회구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "신용매매동향요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10013);
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
    public override string[] Multiple => new[] { "일자", "현재가", "전일대비기호", "전일대비", "거래량", "신규", "상환", "잔고", "금액", "대비", "공여율", "잔고율" };
}