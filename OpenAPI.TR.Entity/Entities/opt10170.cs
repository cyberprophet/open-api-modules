using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>당일매매일지요청</summary>
public class Opt10170 : TR
{
    /// <summary>당일매매일지단일</summary>
    [DataMember, JsonProperty("당일매매일지단일")]
    public SingleOpt10170? SingleResponse
    {
        get; set;
    }
    /// <summary>당일매매일지</summary>
    [DataMember, JsonProperty("당일매매일지")]
    public MultiOpt10170[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.기준일자
    /// 4.단주구분
    /// 5.현금신용구분
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "기준일자", "단주구분", "현금신용구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "당일매매일지요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10170);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "총매도금액", "총매수금액", "총수수료_세금", "총정산금액", "총손익금액", "총수익률" };
    public override string[] Multiple => new[] { "종목명", "매수평균가", "매수수량", "매도평균가", "매도수량", "수수료_제세금", "손익금액", "매도금액", "매수금액", "수익률", "종목코드" };
}