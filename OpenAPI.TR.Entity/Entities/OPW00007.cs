using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌별주문체결내역상세요청</summary>
public class OPW00007 : TR
{
    /// <summary>출력건수</summary>
    [DataMember, JsonProperty("출력건수")]
    public SingleOPW00007? SingleResponse
    {
        get; set;
    }
    /// <summary>계좌별주문체결내역상세</summary>
    [DataMember, JsonProperty("계좌별주문체결내역상세")]
    public MultiOPW00007[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.주문일자
    /// 2.계좌번호
    /// 3.비밀번호
    /// 4.비밀번호입력매체구분
    /// 5.조회구분
    /// 6.주식채권구분
    /// 7.매도수구분
    /// 8.종목코드
    /// 9.시작주문번호
    /// </summary>
    public override string[] Id => new[] { "주문일자", "계좌번호", "비밀번호", "비밀번호입력매체구분", "조회구분", "주식채권구분", "매도수구분", "종목코드", "시작주문번호" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "계좌별주문체결내역상세요청";
    }
    public override string TrCode
    {
        get => nameof(OPW00007);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "출력건수" };
    public override string[] Multiple => new[] { "주문번호", "종목번호", "매매구분", "신용구분", "주문수량", "주문단가", "확인수량", "접수구분", "반대여부", "주문시간", "원주문", "종목명", "주문구분", "대출일", "체결수량", "체결단가", "주문잔량", "통신구분", "정정취소", "확인시간" };
}