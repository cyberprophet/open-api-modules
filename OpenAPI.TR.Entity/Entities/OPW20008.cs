using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌별결제예상내역조회요청</summary>
public class OPW20008 : TR
{
    /// <summary>계좌별결제예상내역조회</summary>
    [DataMember, JsonProperty("계좌별결제예상내역조회")]
    public SingleOPW20008? SingleResponse
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
        get => "계좌별결제예상내역조회요청";
    }
    public override string TrCode
    {
        get => nameof(OPW20008);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "계좌명", "예탁총액", "추정예탁총액", "예탁현금", "추정예탁현금", "선물당일차금", "선물갱신차금", "선물최종결제차금", "선물예상정산손익", "옵션매수대금", "옵션매도대금", "옵션행사차금", "옵션배정차금", "주식옵션행사대금", "주식옵션배정대금", "인수도대금", "전일대용매도체결금액", "금일대용매도체결금액", "선물수수료", "옵션수수료", "결제가격수신여부", "유지증거금총액", "유지증거금총액부족액", "유지증거금현금부족액", "옵션잔고평가손익", "예탁대용", "익일결제예정금액" };
    public override string[] Multiple => Array.Empty<string>();
}