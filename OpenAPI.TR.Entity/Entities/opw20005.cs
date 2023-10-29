using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵주문체결내역상세평균가요청</summary>
public class Opw20005 : TR
{
    /// <summary>출력건수</summary>
    [DataMember, JsonProperty("출력건수")]
    public SingleOpw20005? SingleResponse
    {
        get; set;
    }
    /// <summary>선옵주문체결내역상세평균가</summary>
    [DataMember, JsonProperty("선옵주문체결내역상세평균가")]
    public MultiOpw20005[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.조회일
    /// 4.종목구분
    /// 5.조회구분
    /// 6.정렬구분
    /// 7.정규시간외구분
    /// 8.비밀번호입력매체구분
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "조회일", "종목구분", "조회구분", "정렬구분", "정규시간외구분", "비밀번호입력매체구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선옵주문체결내역상세평균가요청";
    }
    public override string TrCode
    {
        get => nameof(Opw20005);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "출력건수" };
    public override string[] Multiple => new[] { "주문번호", "매매구분", "종목코드", "주문수량", "체결수량", "미체결수량", "접수번호", "접수구분", "조작자사번", "원주문번호", "주문유형", "종목명", "주문가격", "체결가", "체결번호", "약정시간", "접수시간", "매체" };
}