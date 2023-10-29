using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌별당일현황요청</summary>
public class OPW00017 : TR
{
    /// <summary>계좌별당일현황</summary>
    [DataMember, JsonProperty("계좌별당일현황")]
    public SingleOPW00017? SingleResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.비밀번호입력매체구분
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "비밀번호입력매체구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "계좌별당일현황요청";
    }
    public override string TrCode
    {
        get => nameof(OPW00017);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "D+2추정예수금", "신용이자미납금", "기타대여금", "일반주식평가금액D+2", "예탁담보대출금D+2", "예탁담보주식평가금액D+2", "신용융자금D+2", "신용융자평가금D+2", "신용대주담보금D+2", "신용대주평가금D+2", "입금금액", "출금금액", "입고금액", "출고금액", "매도금액", "매수금액", "수수료", "세금", "주식매입자금대출금", "RP평가금액", "채권평가금액", "ELS평가금액", "신용이자금액", "매도대금담보대출이자금액", "배당금액" };
    public override string[] Multiple => Array.Empty<string>();
}