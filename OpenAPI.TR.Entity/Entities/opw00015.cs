using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>위탁종합거래내역요청</summary>
public class Opw00015 : TR
{
    /// <summary>위탁종합거래내역</summary>
    [DataMember, JsonProperty("위탁종합거래내역")]
    public SingleOpw00015? SingleResponse
    {
        get; set;
    }
    /// <summary>위탁종합거래내역배열</summary>
    [DataMember, JsonProperty("위탁종합거래내역배열")]
    public MultiOpw00015[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.시작일자
    /// 4.종료일자
    /// 5.구분
    /// 6.종목코드
    /// 7.통화코드
    /// 8.상품구분
    /// 9.비밀번호입력매체구분
    /// 10.고객정보제한여부
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "시작일자", "종료일자", "구분", "종목코드", "통화코드", "상품구분", "비밀번호입력매체구분", "고객정보제한여부" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "위탁종합거래내역요청";
    }
    public override string TrCode
    {
        get => nameof(Opw00015);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "계좌번호", "출력건수" };
    public override string[] Multiple => new[] { "거래일자", "거래번호", "적요명", "신용거래구분명", "정산금액", "대출금상환", "거래금액(외)", "정산금액(외)", "예수금잔고", "통화코드", "거래종류구분", "거래종류명", "종목명", "거래금액", "거래및농특세", "상환차금", "거래세(외)", "연체합", "외화예수금잔고", "매체구분명", "입출구분", "입출구분명", "원거래번호", "종목코드", "거래수량/좌수", "수수료", "이자/대주이용", "수수료(외)", "연체합(외)", "유가금잔", "처리시간", "ISIN코드", "거래소코드", "거래소명", "거래단가/환율", "소득/주민세", "대출일", "미수(원/주)", "변제합", "체결일", "출납번호", "처리자", "처리점", "매매형태", "과세기준가", "세금수수료합", "외국납부세액(외)", "미수(외)", "변제합(외)", "입금자", "거래내역구분" };
}