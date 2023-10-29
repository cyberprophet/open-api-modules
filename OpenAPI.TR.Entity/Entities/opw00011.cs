using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>증거금율별주문가능수량조회요청</summary>
public class Opw00011 : TR
{
    /// <summary>증거금율별주문가능수량조회</summary>
    [DataMember, JsonProperty("증거금율별주문가능수량조회")]
    public SingleOpw00011? SingleResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.비밀번호입력매체구분
    /// 4.종목번호
    /// 5.매수가격
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "비밀번호입력매체구분", "종목번호", "매수가격" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "증거금율별주문가능수량조회요청";
    }
    public override string TrCode
    {
        get => nameof(Opw00011);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "종목증거금율", "계좌증거금율", "적용증거금율", "증거금20주문가능금액", "증거금20주문가능수량", "증거금20전일재사용금액", "증거금20금일재사용금액", "증거금30주문가능금액", "증거금30주문가능수량", "증거금30전일재사용금액", "증거금30금일재사용금액", "증거금40주문가능금액", "증거금40주문가능수량", "증거금40전일재사용금액", "증거금40금일재사용금액", "증거금50주문가능금액", "증거금50주문가능수량", "증거금50전일재사용금액", "증거금50금일재사용금액", "증거금60주문가능금액", "증거금60주문가능수량", "증거금60전일재사용금액", "증거금60금일재사용금액", "증거금100주문가능금액", "증거금100주문가능수량", "증거금100전일재사용금액", "증거금100금일재사용금액", "미수불가주문가능금액", "미수불가주문가능수량", "미수불가전일재사용금액", "미수불가금일재사용금액", "예수금", "대용금", "미수금", "주문가능대용", "주문가능현금" };
    public override string[] Multiple => Array.Empty<string>();
}