using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵잔고손익요청</summary>
public class OPT50031 : TR
{
    /// <summary>선옵잔고손익</summary>
    [DataMember, JsonProperty("선옵잔고손익")]
    public MultiOPT50031[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// </summary>
    public override string[] Id => new[] { "계좌번호" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선옵잔고손익요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50031);
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
    public override string[] Multiple => new[] { "종목코드", "잔고구분", "당일매도손익", "손익", "손익율", "매입단가", "보유수량", "주문가능수량", "현재가", "총매입가", "평가금액", "당일매매수수료", "종목명" };
}