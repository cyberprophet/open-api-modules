using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵실시간증거금산출요청</summary>
public class Opw20014 : TR
{
    /// <summary>선옵실시간증거금산출</summary>
    [DataMember, JsonProperty("선옵실시간증거금산출")]
    public SingleOpw20014? SingleResponse
    {
        get; set;
    }
    /// <summary>선옵내재변동성</summary>
    [DataMember, JsonProperty("선옵내재변동성")]
    public MultiOpw20014[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.KOSPI200지수
    /// 4.비밀번호입력매체구분
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "KOSPI200지수", "비밀번호입력매체구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선옵실시간증거금산출요청";
    }
    public override string TrCode
    {
        get => nameof(Opw20014);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "계좌명", "예탁총액", "예탁현금", "예탁대용금", "위탁증거금", "현금증거금", "추가증거금총액", "추가증거금현금", "추정예탁총액", "추정예탁현금", "추정위탁증거금총액", "추정위탁증거금현금", "추정유지증거금총액", "추정유지증거금현금", "추정추가증거금총액", "추정추가증거금현금", "선물당일차금", "옵션결제대금", "인수도대금", "수수료", "선물갱신차금", "선물최종차금", "옵션행사배정대금", "유지증거금기준부족액", "위탁증거금기준부족액", "사후증거금계좌구분", "결제가격수신여부", "장종료예탁총액", "장종료예탁현금", "장종료예탁대용금", "조회건수" };
    public override string[] Multiple => new[] { "종목코드", "매도매수구분", "미결제수량", "현재가", "내재변동성", "이론지수", "잔존일수" };
}