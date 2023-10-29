using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵증거금상세내역요청</summary>
public class Opw20012 : TR
{
    /// <summary>선옵증거금상세내역</summary>
    [DataMember, JsonProperty("선옵증거금상세내역")]
    public SingleOpw20012? SingleResponse
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
        get => "선옵증거금상세내역요청";
    }
    public override string TrCode
    {
        get => nameof(Opw20012);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "예탁총액", "예탁현금", "예탁대용", "위탁증거금총액", "위탁현금증거금", "유지증거금총액", "추가증거금총액", "추가증거금현금", "신규위탁증거금총액", "선물신규주문증거금총액", "신규스프레드증거금", "옵션신규매수주문", "옵션신규매도주문", "위험위탁증거금", "옵션가격증거금", "가격변동증거금", "선물스프레드증거금", "인수도증거금", "최소증거금", "당일옵션순매수대금", "옵션매수대금", "선물체결순손익", "선물정산차금", "옵션매도결제대금", "옵션매수결제대금", "수수료합계", "선물최종결제차금", "인수도대금", "옵션행사대금", "옵션배정대금", "주문가능총액", "주문가능현금", "인출가능총액", "인출가능현금", "계좌명", "계좌번호", "조회일자", "예탁평가총액", "익일예탁총액", "전일대용매도금", "금일대용매도금액", "미수연체료", "전일장종료예탁총액", "전일장종료예탁현금", "장중인출가능금액변경여부" };
    public override string[] Multiple => Array.Empty<string>();
}