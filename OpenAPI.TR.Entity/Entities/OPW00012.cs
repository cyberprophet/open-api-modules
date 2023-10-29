using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>신용보증금율별주문가능수량조회요청</summary>
public class OPW00012 : TR
{
    /// <summary>신용보증금율별주문가능수량조회</summary>
    [DataMember, JsonProperty("신용보증금율별주문가능수량조회")]
    public SingleOPW00012? SingleResponse
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
        get => "신용보증금율별주문가능수량조회요청";
    }
    public override string TrCode
    {
        get => nameof(OPW00012);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "종목보증금율", "종목보증금율명", "보증금30주문가능금액", "보증금30주문가능수량", "보증금30전일재사용금액", "보증금30금일재사용금액", "보증금40주문가능금액", "보증금40주문가능수량", "보증금40전일재사용금액", "보증금40금일재사용금액", "보증금50주문가능금액", "보증금50주문가능수량", "보증금50전일재사용금액", "보증금50금일재사용금액", "보증금60주문가능금액", "보증금60주문가능수량", "보증금60전일재사용금액", "보증금60금일재사용금액", "예수금", "대용금", "미수금", "주문가능대용", "주문가능현금", "미수가능금액", "미수가능수량", "미수불가금액", "미수불가수량" };
    public override string[] Multiple => Array.Empty<string>();
}