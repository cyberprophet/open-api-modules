using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵잔고요청</summary>
public class OPT50027 : TR
{
    /// <summary>선옵잔고</summary>
    [DataMember, JsonProperty("선옵잔고")]
    public MultiOPT50027[]? MultiResponse
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
        get => "선옵잔고요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50027);
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
    public override string[] Multiple => new[] { "계좌번호", "종목코드", "신용구분", "대출일", "종목명", "현재가", "등락율", "누적거래량", "보유수량", "매입단가", "총매입가", "주문가능수량", "당일매도수량", "당일매도금액", "당일매수수량", "당일매수금액", "당일매매수수료", "당일매매세금", "당일HTS매도수수료", "당일HTS매수수수료", "D+2매수정산금", "당일매도손익", "당일순매수량", "매매구분", "당일총매도손익", "예수금", "최우선매도호가", "최우선매수호가", "결제잔고", "결제금액", "전일매도수량", "전일매수수량", "전일매도금액", "전일매수금액", "전일순매수량", "손익율", "신용금액", "신용이자", "만기일", "기준가", "하한가", "상한가", "담보대출수량", "연누적거래대금" };
}