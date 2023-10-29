using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>예수금상세현황요청</summary>
public class Opw00001 : TR
{
    /// <summary>예수금상세현황</summary>
    [DataMember, JsonProperty("예수금상세현황")]
    public SingleOpw00001? SingleResponse
    {
        get; set;
    }
    /// <summary>종목별예수금현황</summary>
    [DataMember, JsonProperty("종목별예수금현황")]
    public MultiOpw00001[]? MultiResponse
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
        get => "예수금상세현황요청";
    }
    public override string TrCode
    {
        get => nameof(Opw00001);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "예수금", "주식증거금현금", "수익증권증거금현금", "익일수익증권매도정산대금", "해외주식원화대용설정금", "신용보증금현금", "신용담보금현금", "추가담보금현금", "기타증거금", "미수확보금", "공매도대금", "신용설정평가금", "수표입금액", "기타수표입금액", "신용담보재사용", "코넥스기본예탁금", "ELW예탁평가금", "신용대주권리예정금액", "생계형가입금액", "생계형입금가능금액", "대용금평가금액(합계)", "잔고대용평가금액", "위탁대용잔고평가금액", "수익증권대용평가금액", "위탁증거금대용", "신용보증금대용", "신용담보금대용", "추가담보금대용", "권리대용금", "출금가능금액", "랩출금가능금액", "주문가능금액", "수익증권매수가능금액", "20%종목주문가능금액", "30%종목주문가능금액", "40%종목주문가능금액", "100%종목주문가능금액", "현금미수금", "현금미수연체료", "현금미수금합계", "신용이자미납", "신용이자미납연체료", "신용이자미납합계", "기타대여금", "기타대여금연체료", "기타대여금합계", "미상환융자금", "융자금합계", "대주금합계", "신용담보비율", "중도이용료", "최소주문가능금액", "대출총평가금액", "예탁담보대출잔고", "매도담보대출잔고", "d+1추정예수금", "d+1매도매수정산금", "d+1매수정산금", "d+1미수변제소요금", "d+1매도정산금", "d+1출금가능금액", "d+2추정예수금", "d+2매도매수정산금", "d+2매수정산금", "d+2미수변제소요금", "d+2매도정산금", "d+2출금가능금액", "출력건수" };
    public override string[] Multiple => new[] { "통화코드", "외화예수금", "원화대용평가금", "해외주식증거금", "출금가능금액(예수금)", "주문가능금액(예수금)", "외화미수(합계)", "외화현금미수금", "연체료", "d+1외화예수금", "d+2외화예수금", "d+3외화예수금", "d+4외화예수금" };
}