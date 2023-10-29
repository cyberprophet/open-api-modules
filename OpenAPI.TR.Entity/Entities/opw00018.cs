using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌평가잔고내역요청</summary>
public class Opw00018 : TR
{
    /// <summary>계좌평가결과</summary>
    [DataMember, JsonProperty("계좌평가결과")]
    public SingleOpw00018? SingleResponse
    {
        get; set;
    }
    /// <summary>계좌평가잔고개별합산</summary>
    [DataMember, JsonProperty("계좌평가잔고개별합산")]
    public MultiOpw00018[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.비밀번호입력매체구분
    /// 4.조회구분
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "비밀번호입력매체구분", "조회구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "계좌평가잔고내역요청";
    }
    public override string TrCode
    {
        get => nameof(Opw00018);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "총매입금액", "총평가금액", "총평가손익금액", "총수익률(%)", "추정예탁자산", "총대출금", "총융자금액", "총대주금액", "조회건수" };
    public override string[] Multiple => new[] { "종목번호", "종목명", "평가손익", "수익률(%)", "매입가", "전일종가", "보유수량", "매매가능수량", "현재가", "전일매수수량", "전일매도수량", "금일매수수량", "금일매도수량", "매입금액", "매입수수료", "평가금액", "평가수수료", "세금", "수수료합", "보유비중(%)", "신용구분", "신용구분명", "대출일" };
}