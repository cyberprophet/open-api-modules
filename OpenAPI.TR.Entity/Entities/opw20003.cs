using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵기간손익조회요청</summary>
public class Opw20003 : TR
{
    /// <summary>선옵기간손익조회</summary>
    [DataMember, JsonProperty("선옵기간손익조회")]
    public SingleOpw20003? SingleResponse
    {
        get; set;
    }
    /// <summary>선옵종목별기간손익조회</summary>
    [DataMember, JsonProperty("선옵종목별기간손익조회")]
    public MultiOpw20003[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.시장구분
    /// 3.비밀번호
    /// 4.시작일자
    /// 5.종료일자
    /// 6.비밀번호입력매체구분
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "시장구분", "비밀번호", "시작일자", "종료일자", "비밀번호입력매체구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선옵기간손익조회요청";
    }
    public override string TrCode
    {
        get => nameof(Opw20003);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "선물약정금액", "옵션약정금액", "선물정산손익", "옵션매매손익", "총손익", "평균예탁금액", "예탁총액", "수수료", "수익율", "조회건수" };
    public override string[] Multiple => new[] { "종목코드", "매도수구분", "잔고수량", "평균가격", "전일종가", "평가손익", "종목명" };
}