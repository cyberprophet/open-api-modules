using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주문인출가능금액요청</summary>
public class Opw00010 : TR
{
    /// <summary>주문인출가능금액</summary>
    [DataMember, JsonProperty("주문인출가능금액")]
    public SingleOpw00010? SingleResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.비밀번호입력매체구분
    /// 4.입출금액
    /// 5.종목번호
    /// 6.매매구분
    /// 7.매매수량
    /// 8.매수가격
    /// 9.예상매수단가
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "비밀번호입력매체구분", "입출금액", "종목번호", "매매구분", "매매수량", "매수가격", "예상매수단가" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "주문인출가능금액요청";
    }
    public override string TrCode
    {
        get => nameof(Opw00010);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "증거금20주문가능금액", "증거금20주문가능수량", "증거금30주문가능금액", "증거금30주문가능수량", "증거금40주문가능금액", "증거금40주문가능수량", "증거금50주문가능금액", "증거금50주문가능수량", "증거금60주문가능금액", "증거금60주문가능수량", "증거금감면60주문가능금", "증거금감면60주문가능수", "증거금100주문가능금액", "증거금100주문가능수량", "전일재사용가능금액", "금일재사용가능금액", "예수금", "대용금", "미수금", "주문가능대용", "주문가능현금", "인출가능금액", "익일인출가능금액", "매입금액", "수수료", "매입정산금", "D2추정예수금", "증거금감면적용구분" };
    public override string[] Multiple => Array.Empty<string>();
}