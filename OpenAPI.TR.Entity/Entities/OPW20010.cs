using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵예탁금및증거금조회요청</summary>
public class OPW20010 : TR
{
    /// <summary>선옵예탁금및증거금조회</summary>
    [DataMember, JsonProperty("선옵예탁금및증거금조회")]
    public SingleOPW20010? SingleResponse
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
        get => "선옵예탁금및증거금조회요청";
    }
    public override string TrCode
    {
        get => nameof(OPW20010);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "예탁총액", "예탁현금", "에탁대용", "증거금총액", "증거금현금", "증거금대용금", "주문가능총액", "주문가능현금", "주문가능대용금", "추가증거금총액", "추가증거금현금", "추가증거금대용금", "인출가능총액", "인출가능현금", "인출가능대용금", "순자산금액", "익일예탁총액", "개장예탁총액", "선물정산차금", "선물청산손익", "선물평가손익", "선물약정금액", "옵션결제차금", "옵션청산손익", "옵션평가손익", "옵션약정금액", "전일장종료예탁총액", "전일장종료예탁현금", "전일장종료예탁대용금" };
    public override string[] Multiple => Array.Empty<string>();
}