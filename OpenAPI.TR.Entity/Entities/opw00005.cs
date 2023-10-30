using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>체결잔고요청</summary>
public class Opw00005 : TR
{
    /// <summary>체결잔고</summary>
    [DataMember, JsonProperty("체결잔고")]
    public SingleOpw00005? SingleResponse
    {
        get; set;
    }
    /// <summary>종목별체결잔고</summary>
    [DataMember, JsonProperty("종목별체결잔고")]
    public MultiOpw00005[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.비밀번호입력매체구분
    /// </summary>
    public override string[] Id => new[]
    {
        "계좌번호",
        "비밀번호",
        "비밀번호입력매체구분"
    };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "체결잔고요청";
    }
    public override string TrCode
    {
        get => nameof(Opw00005);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[]
    {
        "예수금",
        "예수금D+1",
        "예수금D+2",
        "출금가능금액",
        "미수확보금",
        "대용금",
        "권리대용금",
        "주문가능현금",
        "현금미수금",
        "신용이자미납금",
        "기타대여금",
        "미상환융자금",
        "증거금현금",
        "증거금대용",
        "주식매수총액",
        "평가금액합계",
        "총손익합계",
        "총손익률",
        "총재매수가능금액",
        "20주문가능금액",
        "30주문가능금액",
        "40주문가능금액",
        "50주문가능금액",
        "60주문가능금액",
        "100주문가능금액",
        "신용융자합계",
        "신용융자대주합계",
        "신용담보비율",
        "예탁담보대출금액",
        "매도담보대출금액",
        "조회건수"
    };
    public override string[] Multiple => new[]
    {
        "신용구분",
        "대출일",
        "만기일",
        "종목번호",
        "종목명",
        "결제잔고",
        "현재잔고",
        "현재가",
        "매입단가",
        "매입금액",
        "평가금액",
        "평가손익",
        "손익률"
    };
}