using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>대차거래상위10종목요청</summary>
public class OPT10069 : TR
{
    /// <summary>대차거래상위10종목합계</summary>
    [DataMember, JsonProperty("대차거래상위10종목합계")]
    public SingleOPT10069? SingleResponse
    {
        get; set;
    }
    /// <summary>대차거래상위10종목</summary>
    [DataMember, JsonProperty("대차거래상위10종목")]
    public MultiOPT10069[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시작일자
    /// 2.종료일자
    /// 3.시장구분
    /// </summary>
    public override string[] Id => new[] { "시작일자", "종료일자", "시장구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "대차거래상위10종목요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10069);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "대차거래체결주수합", "대차거래상환주수합", "잔고주수합", "잔고금액합", "대차거래체결주수비율", "대차거래상환주수비율", "잔고주수비율", "잔고금액비율" };
    public override string[] Multiple => new[] { "종목명", "종목코드", "대차거래체결주수", "대차거래상환주수", "잔고주수", "잔고금액" };
}