using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>증거금세부내역조회요청</summary>
public class Opw00013 : TR
{
    /// <summary>증거금세부내역조회</summary>
    [DataMember, JsonProperty("증거금세부내역조회")]
    public SingleOpw00013? SingleResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "증거금세부내역조회요청";
    }
    public override string TrCode
    {
        get => nameof(Opw00013);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "금일재사용대상금액", "금일재사용사용금액", "금일재사용가능금액", "금일재사용제한금액", "금일재사용가능금액최종", "전일재사용대상금액", "전일재사용사용금액", "전일재사용가능금액", "전일재사용제한금액", "전일재사용가능금액최종", "현금금액", "현금증거금", "사용가능현금", "현금사용제한금액", "사용가능현금최종", "대용금액", "대용증거금", "사용가능대용", "대용사용제한금액", "사용가능대용최종", "신용보증금현금", "신용보증금대용", "신용담보금현금", "신용담보금대용", "미수금", "대주담보금재사용금", "20주문가능금액", "30주문가능금액", "40주문가능금액", "50주문가능금액", "60주문가능금액", "100주문가능금액", "금일신용상환손실금액", "전일신용상환손실금액", "금일대주상환손실대용증거금", "전일대주상환손실대용증거금", "평가대용금(현물사용제외)", "평가대용비율", "신용대용증거금", "현금주문대용증거금", "신용주문대용증거금", "신용대용환산금", "대용가능금액", "대용가능금액2", "현금대용부족금", "신용대용부족금", "현금주문가능대용금", "신용주문가능대용금" };
    public override string[] Multiple => Array.Empty<string>();
}