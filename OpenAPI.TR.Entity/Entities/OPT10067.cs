using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>대차거래내역요청</summary>
public class OPT10067 : TR
{
    /// <summary>대차거래내역</summary>
    [DataMember, JsonProperty("대차거래내역")]
    public MultiOPT10067[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.기준일자
    /// 2.시장구분
    /// </summary>
    public override string[] Id => new[] { "기준일자", "시장구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "대차거래내역요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10067);
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
    public override string[] Multiple => new[] { "종목명", "종목코드", "대차거래체결주수", "대차거래상환주수", "잔고주수", "잔고금액" };
}