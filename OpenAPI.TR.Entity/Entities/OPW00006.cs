using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>관리자별주문체결내역요청</summary>
public class OPW00006 : TR
{
    /// <summary>출력건수</summary>
    [DataMember, JsonProperty("출력건수")]
    public SingleOPW00006? SingleResponse
    {
        get; set;
    }
    /// <summary>관리자별주문체결내역</summary>
    [DataMember, JsonProperty("관리자별주문체결내역")]
    public MultiOPW00006[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.일자
    /// 2.지점코드
    /// 3.시작주문번호
    /// </summary>
    public override string[] Id => new[] { "일자", "지점코드", "시작주문번호" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "관리자별주문체결내역요청";
    }
    public override string TrCode
    {
        get => nameof(OPW00006);
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
    public override string[] Multiple => new[] { "주문번호", "원주문번호", "모주문번호", "계좌번호", "계좌명", "종목코드", "정정구분", "매도수구분", "주문구분", "통신주문구분", "주문수량", "주문지수", "주문잔량", "체결수량", "체결지수", "접수여부", "체결번호" };
}