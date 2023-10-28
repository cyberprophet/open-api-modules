using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>위탁종합거래내역배열</summary>
public class MultiOpw00015
{
    /// <summary>거래일자</summary>
    [DataMember, JsonProperty("거래일자")]
    public string? 거래일자
    {
        get; set;
    }
    /// <summary>거래번호</summary>
    [DataMember, JsonProperty("거래번호")]
    public string? 거래번호
    {
        get; set;
    }
    /// <summary>적요명</summary>
    [DataMember, JsonProperty("적요명")]
    public string? 적요명
    {
        get; set;
    }
    /// <summary>신용거래구분명</summary>
    [DataMember, JsonProperty("신용거래구분명")]
    public string? 신용거래구분명
    {
        get; set;
    }
    /// <summary>정산금액</summary>
    [DataMember, JsonProperty("정산금액")]
    public string? 정산금액
    {
        get; set;
    }
    /// <summary>대출금상환</summary>
    [DataMember, JsonProperty("대출금상환")]
    public string? 대출금상환
    {
        get; set;
    }
    /// <summary>거래금액(외)</summary>
    [DataMember, JsonProperty("거래금액(외)")]
    public string? 거래금액외
    {
        get; set;
    }
    /// <summary>정산금액(외)</summary>
    [DataMember, JsonProperty("정산금액(외)")]
    public string? 정산금액외
    {
        get; set;
    }
    /// <summary>예수금잔고</summary>
    [DataMember, JsonProperty("예수금잔고")]
    public string? 예수금잔고
    {
        get; set;
    }
    /// <summary>통화코드</summary>
    [DataMember, JsonProperty("통화코드")]
    public string? 통화코드
    {
        get; set;
    }
    /// <summary>거래종류구분</summary>
    [DataMember, JsonProperty("거래종류구분")]
    public string? 거래종류구분
    {
        get; set;
    }
    /// <summary>거래종류명</summary>
    [DataMember, JsonProperty("거래종류명")]
    public string? 거래종류명
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>거래금액</summary>
    [DataMember, JsonProperty("거래금액")]
    public string? 거래금액
    {
        get; set;
    }
    /// <summary>거래및농특세</summary>
    [DataMember, JsonProperty("거래및농특세")]
    public string? 거래및농특세
    {
        get; set;
    }
    /// <summary>상환차금</summary>
    [DataMember, JsonProperty("상환차금")]
    public string? 상환차금
    {
        get; set;
    }
    /// <summary>거래세(외)</summary>
    [DataMember, JsonProperty("거래세(외)")]
    public string? 거래세외
    {
        get; set;
    }
    /// <summary>연체합</summary>
    [DataMember, JsonProperty("연체합")]
    public string? 연체합
    {
        get; set;
    }
    /// <summary>외화예수금잔고</summary>
    [DataMember, JsonProperty("외화예수금잔고")]
    public string? 외화예수금잔고
    {
        get; set;
    }
    /// <summary>매체구분명</summary>
    [DataMember, JsonProperty("매체구분명")]
    public string? 매체구분명
    {
        get; set;
    }
    /// <summary>입출구분</summary>
    [DataMember, JsonProperty("입출구분")]
    public string? 입출구분
    {
        get; set;
    }
    /// <summary>입출구분명</summary>
    [DataMember, JsonProperty("입출구분명")]
    public string? 입출구분명
    {
        get; set;
    }
    /// <summary>원거래번호</summary>
    [DataMember, JsonProperty("원거래번호")]
    public string? 원거래번호
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>거래수량/좌수</summary>
    [DataMember, JsonProperty("거래수량/좌수")]
    public string? 거래수량좌수
    {
        get; set;
    }
    /// <summary>수수료</summary>
    [DataMember, JsonProperty("수수료")]
    public string? 수수료
    {
        get; set;
    }
    /// <summary>이자/대주이용</summary>
    [DataMember, JsonProperty("이자/대주이용")]
    public string? 이자대주이용
    {
        get; set;
    }
    /// <summary>수수료(외)</summary>
    [DataMember, JsonProperty("수수료(외)")]
    public string? 수수료외
    {
        get; set;
    }
    /// <summary>연체합(외)</summary>
    [DataMember, JsonProperty("연체합(외)")]
    public string? 연체합외
    {
        get; set;
    }
    /// <summary>유가금잔</summary>
    [DataMember, JsonProperty("유가금잔")]
    public string? 유가금잔
    {
        get; set;
    }
    /// <summary>처리시간</summary>
    [DataMember, JsonProperty("처리시간")]
    public string? 처리시간
    {
        get; set;
    }
    /// <summary>ISIN코드</summary>
    [DataMember, JsonProperty("ISIN코드")]
    public string? ISIN코드
    {
        get; set;
    }
    /// <summary>거래소코드</summary>
    [DataMember, JsonProperty("거래소코드")]
    public string? 거래소코드
    {
        get; set;
    }
    /// <summary>거래소명</summary>
    [DataMember, JsonProperty("거래소명")]
    public string? 거래소명
    {
        get; set;
    }
    /// <summary>거래단가/환율</summary>
    [DataMember, JsonProperty("거래단가/환율")]
    public string? 거래단가환율
    {
        get;
        set;
    }
    /// <summary>소득/주민세</summary>
    [DataMember, JsonProperty("소득/주민세")]
    public string? 소득주민세
    {
        get;
        set;
    }
    /// <summary>대출일</summary>
    [DataMember, JsonProperty("대출일")]
    public string? 대출일
    {
        get; set;
    }
    /// <summary>미수(원/주)</summary>
    [DataMember, JsonProperty("미수(원/주)")]
    public string? 미수원주
    {
        get; set;
    }
    /// <summary>변제합</summary>
    [DataMember, JsonProperty("변제합")]
    public string? 변제합
    {
        get; set;
    }
    /// <summary>체결일</summary>
    [DataMember, JsonProperty("체결일")]
    public string? 체결일
    {
        get; set;
    }
    /// <summary>출납번호</summary>
    [DataMember, JsonProperty("출납번호")]
    public string? 출납번호
    {
        get; set;
    }
    /// <summary>처리자</summary>
    [DataMember, JsonProperty("처리자")]
    public string? 처리자
    {
        get; set;
    }
    /// <summary>처리점</summary>
    [DataMember, JsonProperty("처리점")]
    public string? 처리점
    {
        get; set;
    }
    /// <summary>매매형태</summary>
    [DataMember, JsonProperty("매매형태")]
    public string? 매매형태
    {
        get; set;
    }
    /// <summary>과세기준가</summary>
    [DataMember, JsonProperty("과세기준가")]
    public string? 과세기준가
    {
        get; set;
    }
    /// <summary>세금수수료합</summary>
    [DataMember, JsonProperty("세금수수료합")]
    public string? 세금수수료합
    {
        get; set;
    }
    /// <summary>외국납부세액(외)</summary>
    [DataMember, JsonProperty("외국납부세액(외)")]
    public string? 외국납부세액외
    {
        get; set;
    }
    /// <summary>미수(외)</summary>
    [DataMember, JsonProperty("미수(외)")]
    public string? 미수외
    {
        get; set;
    }
    /// <summary>변제합(외)</summary>
    [DataMember, JsonProperty("변제합(외)")]
    public string? 변제합외
    {
        get; set;
    }
    /// <summary>입금자</summary>
    [DataMember, JsonProperty("입금자")]
    public string? 입금자
    {
        get; set;
    }
    /// <summary>거래내역구분</summary>
    [DataMember, JsonProperty("거래내역구분")]
    public string? 거래내역구분
    {
        get; set;
    }
}