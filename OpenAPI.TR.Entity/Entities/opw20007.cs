using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵잔고현황정산가기준요청</summary>
public class Opw20007 : TR
{
    /// <summary>선옵잔고현황정산가기준합계</summary>
    [DataMember, JsonProperty("선옵잔고현황정산가기준합계")]
    public SingleOpw20007? SingleResponse
    {
        get; set;
    }
    /// <summary>선옵잔고현황정산가기준</summary>
    [DataMember, JsonProperty("선옵잔고현황정산가기준")]
    public MultiOpw20007[]? MultiResponse
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
        get => "선옵잔고현황정산가기준요청";
    }
    public override string TrCode
    {
        get => nameof(Opw20007);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "약정금액합계", "평가손익합계", "출력건수" };
    public override string[] Multiple => new[] { "종목코드", "종목명", "매도매수구분", "수량", "매입단가", "현재가", "평가손익", "청산가능수량", "약정금액", "평가금액" };
}