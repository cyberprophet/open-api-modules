using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물옵션청산주문위탁증거금가계산요청</summary>
public class OPW20001 : TR
{
    /// <summary>선옵위탁증거금가계산</summary>
    [DataMember, JsonProperty("선옵위탁증거금가계산")]
    public SingleOPW20001? SingleResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.입력건수
    /// 4.종목코드
    /// 5.매수매도구분
    /// 6.주문수량
    /// 7.잔고수량
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "입력건수", "종목코드", "매수매도구분", "주문수량", "잔고수량" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선물옵션청산주문위탁증거금가계산요청";
    }
    public override string TrCode
    {
        get => nameof(OPW20001);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "현재위탁증거금총액", "현재현금예탁필요액", "체결위탁증거금총액", "체결현금예탁필요액", "증감위탁증거금총액", "증감현금예탁필요액" };
    public override string[] Multiple => Array.Empty<string>();
}