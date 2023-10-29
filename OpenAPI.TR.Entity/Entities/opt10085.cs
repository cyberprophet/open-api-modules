using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌수익률요청</summary>
public class Opt10085 : TR
{
    /// <summary>계좌수익률</summary>
    [DataMember, JsonProperty("계좌수익률")]
    public MultiOpt10085[]? MultiResponse
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
        get => "계좌수익률요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10085);
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
    public override string[] Multiple => new[] { "일자", "종목코드", "종목명", "현재가", "매입가", "매입금액", "보유수량", "당일매도손익", "당일매매수수료", "당일매매세금", "신용구분", "대출일", "결제잔고", "청산가능수량", "신용금액", "신용이자", "만기일" };
}