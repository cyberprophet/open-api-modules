using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌별주문체결현황요청</summary>
public class Opw00009 : TR
{
    /// <summary>계좌별주문체결현황</summary>
    [DataMember, JsonProperty("계좌별주문체결현황")]
    public SingleOpw00009? SingleResponse
    {
        get; set;
    }
    /// <summary>계좌별주문체결현황배열</summary>
    [DataMember, JsonProperty("계좌별주문체결현황배열")]
    public MultiOpw00009[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.주문일자
    /// 2.계좌번호
    /// 3.비밀번호
    /// 4.비밀번호입력매체구분
    /// 5.주식채권구분
    /// 6.시장구분
    /// 7.매도수구분
    /// 8.조회구분
    /// 9.종목코드
    /// 10.시작주문번호
    /// </summary>
    public override string[] Id => new[] { "주문일자", "계좌번호", "비밀번호", "비밀번호입력매체구분", "주식채권구분", "시장구분", "매도수구분", "조회구분", "종목코드", "시작주문번호" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "계좌별주문체결현황요청";
    }
    public override string TrCode
    {
        get => nameof(Opw00009);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "매도약정금액", "매수약정금액", "약정금액", "조회건수" };
    public override string[] Multiple => new[] { "주식채권구분", "주문번호", "종목번호", "매매구분", "주문유형구분", "주문수량", "주문단가", "확인수량", "예약반대", "체결번호", "접수구분", "원주문번호", "종목명", "결제구분", "신용거래구분", "체결수량", "체결단가", "통신구분", "정정취소구분", "체결시간" };
}