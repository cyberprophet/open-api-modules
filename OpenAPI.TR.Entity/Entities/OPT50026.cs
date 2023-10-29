using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵주문체결요청</summary>
public class OPT50026 : TR
{
    /// <summary>선옵주문체결</summary>
    [DataMember, JsonProperty("선옵주문체결")]
    public MultiOPT50026[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.조회구분
    /// 3.매매구분
    /// 4.체결구분
    /// 5.계좌번호
    /// 6.주문번호
    /// </summary>
    public override string[] Id => new[] { "종목코드", "조회구분", "매매구분", "체결구분", "계좌번호", "주문번호" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선옵주문체결요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50026);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => Array.Empty<string>();
    public override string[] Multiple => new[] { "주문번호", "종목코드", "종목명", "주문구분", "주문가격", "주문수량", "체결가", "체결량", "미체결수량", "주문상태", "원주문번호", "매매구분", "주문체결시간" };
}