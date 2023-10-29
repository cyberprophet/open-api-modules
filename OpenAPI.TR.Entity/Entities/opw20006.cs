using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵잔고상세현황요청</summary>
public class Opw20006 : TR
{
    /// <summary>선옵잔고상세현황합계</summary>
    [DataMember, JsonProperty("선옵잔고상세현황합계")]
    public SingleOpw20006? SingleResponse
    {
        get; set;
    }
    /// <summary>선옵잔고상세현황</summary>
    [DataMember, JsonProperty("선옵잔고상세현황")]
    public MultiOpw20006[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.조회일자
    /// 4.비밀번호입력매체구분
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "조회일자", "비밀번호입력매체구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선옵잔고상세현황요청";
    }
    public override string TrCode
    {
        get => nameof(Opw20006);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "선물매도수량", "선물매수수량", "콜매도수량", "콜매수수량", "풋매도수량", "풋매수수량", "선물매도금액", "선물매수금액", "콜매도금액", "콜매수금액", "풋매도금액", "풋매수금액", "약정합계", "손익합계", "조회건수" };
    public override string[] Multiple => new[] { "종목코드", "종목명", "매매일자", "매매구분", "잔고수량", "매입단가", "매매금액", "현재가", "평가손익", "손익율", "평가금액" };
}