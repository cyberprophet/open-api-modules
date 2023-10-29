using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종별주가요청</summary>
public class OPT20002 : TR
{
    /// <summary>업종별주가</summary>
    [DataMember, JsonProperty("업종별주가")]
    public MultiOPT20002[]? MultiResponse
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
        get => "업종별주가요청";
    }
    public override string TrCode
    {
        get => nameof(OPT20002);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "등락률", "현재거래량", "매도호가", "매수호가", "시가", "고가", "저가" };
}