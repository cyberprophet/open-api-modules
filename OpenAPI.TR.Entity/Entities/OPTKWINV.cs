using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>관심종목투자자정보요청</summary>
public class OPTKWINV : TR
{
    /// <summary>관심종목투자자정보</summary>
    [DataMember, JsonProperty("관심종목투자자정보")]
    public MultiOPTKWINV[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// </summary>
    public override string[] Id => new[] { "종목코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "관심종목투자자정보요청";
    }
    public override string TrCode
    {
        get => nameof(OPTKWINV);
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
    public override string[] Multiple => new[] { "종목명", "매도수량", "매수수량", "순매수수량", "매도금액", "매수금액", "순매수금액" };
}