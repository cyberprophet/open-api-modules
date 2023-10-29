using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일자별실현손익요청</summary>
public class Opt10074 : TR
{
    /// <summary>일자별실현손익단일</summary>
    [DataMember, JsonProperty("일자별실현손익단일")]
    public SingleOpt10074? SingleResponse
    {
        get; set;
    }
    /// <summary>일자별실현손익</summary>
    [DataMember, JsonProperty("일자별실현손익")]
    public MultiOpt10074[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.시작일자
    /// 3.종료일자
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "시작일자", "종료일자" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "일자별실현손익요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10074);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "총매수금액", "총매도금액", "실현손익", "매매수수료", "매매세금" };
    public override string[] Multiple => new[] { "일자", "매수금액", "매도금액", "당일매도손익", "당일매매수수료", "당일매매세금" };
}