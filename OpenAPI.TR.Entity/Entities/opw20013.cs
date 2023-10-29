using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌미결제청산가능수량조회요청</summary>
public class Opw20013 : TR
{
    /// <summary>계좌미결제청산가능수량조회</summary>
    [DataMember, JsonProperty("계좌미결제청산가능수량조회")]
    public SingleOpw20013? SingleResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.종목코드
    /// 4.주문가격
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "종목코드", "주문가격" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "계좌미결제청산가능수량조회요청";
    }
    public override string TrCode
    {
        get => nameof(Opw20013);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "미결제수량", "청산가능수량", "현재증거금총액", "현재증거금현금", "예상위탁증거금", "예상현금증거금" };
    public override string[] Multiple => Array.Empty<string>();
}