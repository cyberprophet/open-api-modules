using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌별익일결제예정내역요청</summary>
public class Opw00008 : TR
{
    /// <summary>계좌별익일결제예정내역</summary>
    [DataMember, JsonProperty("계좌별익일결제예정내역")]
    public SingleOpw00008? SingleResponse
    {
        get; set;
    }
    /// <summary>계좌별익일결제예정내역배열</summary>
    [DataMember, JsonProperty("계좌별익일결제예정내역배열")]
    public MultiOpw00008[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.비밀번호입력매체구분
    /// 4.시작결제번호
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "비밀번호입력매체구분", "시작결제번호" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "계좌별익일결제예정내역요청";
    }
    public override string TrCode
    {
        get => nameof(Opw00008);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "매매일자", "결제일자", "매도정산합", "매수정산합", "조회건수" };
    public override string[] Multiple => new[] { "일련번호", "종목번호", "대출일", "수량", "약정금액", "수수료", "소득세", "농특세", "종목명", "매도수구분", "단가", "정산금액", "거래세", "주민세", "신용구분" };
}