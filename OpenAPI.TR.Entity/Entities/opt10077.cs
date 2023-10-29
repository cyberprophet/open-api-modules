using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>당일실현손익상세요청</summary>
public class Opt10077 : TR
{
    /// <summary>당일실현손익</summary>
    [DataMember, JsonProperty("당일실현손익")]
    public SingleOpt10077? SingleResponse
    {
        get; set;
    }
    /// <summary>당일실현손익상세</summary>
    [DataMember, JsonProperty("당일실현손익상세")]
    public MultiOpt10077[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.종목코드
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "종목코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "당일실현손익상세요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10077);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "당일실현손익" };
    public override string[] Multiple => new[] { "종목명", "체결량", "매입단가", "체결가", "당일매도손익", "손익율", "당일매매수수료", "당일매매세금", "종목코드" };
}