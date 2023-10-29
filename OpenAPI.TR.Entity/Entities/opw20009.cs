using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵계좌별주문가능수량요청</summary>
public class Opw20009 : TR
{
    /// <summary>선옵계좌별주문가능수량</summary>
    [DataMember, JsonProperty("선옵계좌별주문가능수량")]
    public SingleOpw20009? SingleResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.종목코드
    /// 4.매도수구분
    /// 5.주문유형
    /// 6.주문가격
    /// 7.비밀번호입력매체구분
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "종목코드", "매도수구분", "주문유형", "주문가격", "비밀번호입력매체구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선옵계좌별주문가능수량요청";
    }
    public override string TrCode
    {
        get => nameof(Opw20009);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "예탁총액", "예탁현금", "위탁증거금", "현금증거금", "주문가능금액", "주문가능총액", "신규가능수량", "청산가능수량", "총가능수량", "주문가능총액", "필요증거금총액", "총액부족액", "주문가능현금", "필요증거금현금", "현금부족액", "주문가능대용금", "필요증거금대용금", "대용금부족액" };
    public override string[] Multiple => Array.Empty<string>();
}