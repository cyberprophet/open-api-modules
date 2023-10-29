using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일별계좌수익률상세현황요청</summary>
public class OPW00016 : TR
{
    /// <summary>일별계좌수익률상세현황</summary>
    [DataMember, JsonProperty("일별계좌수익률상세현황")]
    public SingleOPW00016? SingleResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.평가시작일
    /// 4.평가종료일
    /// 5.비밀번호입력매체구분
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "평가시작일", "평가종료일", "비밀번호입력매체구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "일별계좌수익률상세현황요청";
    }
    public override string TrCode
    {
        get => nameof(OPW00016);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "관리사원번호", "관리자명", "관리자지점", "예수금_초", "예수금_말", "유가증권평가금액_초", "유가증권평가금액_말", "대주담보금_초", "대주담보금_말", "신용융자금_초", "신용융자금_말", "현금미수금_초", "현금미수금_말", "원화대용금_초", "원화대용금_말", "대주평가금_초", "대주평가금_말", "권리평가금_초", "권리평가금_말", "대출금_초", "대출금_말", "기타대여금_초", "기타대여금_말", "신용이자미납금_초", "신용이자미납금_말", "신용이자_초", "신용이자_말", "순자산액계_초", "순자산액계_말", "투자원금평잔", "평가손익", "수익률", "회전율", "기간내총입금", "기간내총출금", "기간내총입고", "기간내총출고", "선물대용매도금액", "위탁대용매도금액" };
    public override string[] Multiple => Array.Empty<string>();
}