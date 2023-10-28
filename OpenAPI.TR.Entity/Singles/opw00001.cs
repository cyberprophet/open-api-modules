using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>예수금상세현황</summary>
public class SingleOpw00001
{
    /// <summary>예수금</summary>
    [DataMember, JsonProperty("예수금")]
    public string? 예수금
    {
        get; set;
    }
    /// <summary>주식증거금현금</summary>
    [DataMember, JsonProperty("주식증거금현금")]
    public string? 주식증거금현금
    {
        get; set;
    }
    /// <summary>수익증권증거금현금</summary>
    [DataMember, JsonProperty("수익증권증거금현금")]
    public string? 수익증권증거금현금
    {
        get; set;
    }
    /// <summary>익일수익증권매도정산대금</summary>
    [DataMember, JsonProperty("익일수익증권매도정산대금")]
    public string? 익일수익증권매도정산대금
    {
        get; set;
    }
    /// <summary>해외주식원화대용설정금</summary>
    [DataMember, JsonProperty("해외주식원화대용설정금")]
    public string? 해외주식원화대용설정금
    {
        get; set;
    }
    /// <summary>신용보증금현금</summary>
    [DataMember, JsonProperty("신용보증금현금")]
    public string? 신용보증금현금
    {
        get; set;
    }
    /// <summary>신용담보금현금</summary>
    [DataMember, JsonProperty("신용담보금현금")]
    public string? 신용담보금현금
    {
        get; set;
    }
    /// <summary>추가담보금현금</summary>
    [DataMember, JsonProperty("추가담보금현금")]
    public string? 추가담보금현금
    {
        get; set;
    }
    /// <summary>기타증거금</summary>
    [DataMember, JsonProperty("기타증거금")]
    public string? 기타증거금
    {
        get; set;
    }
    /// <summary>미수확보금</summary>
    [DataMember, JsonProperty("미수확보금")]
    public string? 미수확보금
    {
        get; set;
    }
    /// <summary>공매도대금</summary>
    [DataMember, JsonProperty("공매도대금")]
    public string? 공매도대금
    {
        get; set;
    }
    /// <summary>신용설정평가금</summary>
    [DataMember, JsonProperty("신용설정평가금")]
    public string? 신용설정평가금
    {
        get; set;
    }
    /// <summary>수표입금액</summary>
    [DataMember, JsonProperty("수표입금액")]
    public string? 수표입금액
    {
        get; set;
    }
    /// <summary>기타수표입금액</summary>
    [DataMember, JsonProperty("기타수표입금액")]
    public string? 기타수표입금액
    {
        get; set;
    }
    /// <summary>신용담보재사용</summary>
    [DataMember, JsonProperty("신용담보재사용")]
    public string? 신용담보재사용
    {
        get; set;
    }
    /// <summary>코넥스기본예탁금</summary>
    [DataMember, JsonProperty("코넥스기본예탁금")]
    public string? 코넥스기본예탁금
    {
        get; set;
    }
    /// <summary>ELW예탁평가금</summary>
    [DataMember, JsonProperty("ELW예탁평가금")]
    public string? ELW예탁평가금
    {
        get; set;
    }
    /// <summary>신용대주권리예정금액</summary>
    [DataMember, JsonProperty("신용대주권리예정금액")]
    public string? 신용대주권리예정금액
    {
        get; set;
    }
    /// <summary>생계형가입금액</summary>
    [DataMember, JsonProperty("생계형가입금액")]
    public string? 생계형가입금액
    {
        get; set;
    }
    /// <summary>생계형입금가능금액</summary>
    [DataMember, JsonProperty("생계형입금가능금액")]
    public string? 생계형입금가능금액
    {
        get; set;
    }
    /// <summary>대용금평가금액(합계)</summary>
    [DataMember, JsonProperty("대용금평가금액(합계)")]
    public string? 대용금평가금액합계
    {
        get; set;
    }
    /// <summary>잔고대용평가금액</summary>
    [DataMember, JsonProperty("잔고대용평가금액")]
    public string? 잔고대용평가금액
    {
        get; set;
    }
    /// <summary>위탁대용잔고평가금액</summary>
    [DataMember, JsonProperty("위탁대용잔고평가금액")]
    public string? 위탁대용잔고평가금액
    {
        get; set;
    }
    /// <summary>수익증권대용평가금액</summary>
    [DataMember, JsonProperty("수익증권대용평가금액")]
    public string? 수익증권대용평가금액
    {
        get; set;
    }
    /// <summary>위탁증거금대용</summary>
    [DataMember, JsonProperty("위탁증거금대용")]
    public string? 위탁증거금대용
    {
        get; set;
    }
    /// <summary>신용보증금대용</summary>
    [DataMember, JsonProperty("신용보증금대용")]
    public string? 신용보증금대용
    {
        get; set;
    }
    /// <summary>신용담보금대용</summary>
    [DataMember, JsonProperty("신용담보금대용")]
    public string? 신용담보금대용
    {
        get; set;
    }
    /// <summary>추가담보금대용</summary>
    [DataMember, JsonProperty("추가담보금대용")]
    public string? 추가담보금대용
    {
        get; set;
    }
    /// <summary>권리대용금</summary>
    [DataMember, JsonProperty("권리대용금")]
    public string? 권리대용금
    {
        get; set;
    }
    /// <summary>출금가능금액</summary>
    [DataMember, JsonProperty("출금가능금액")]
    public string? 출금가능금액
    {
        get; set;
    }
    /// <summary>랩출금가능금액</summary>
    [DataMember, JsonProperty("랩출금가능금액")]
    public string? 랩출금가능금액
    {
        get; set;
    }
    /// <summary>주문가능금액</summary>
    [DataMember, JsonProperty("주문가능금액")]
    public string? 주문가능금액
    {
        get; set;
    }
    /// <summary>수익증권매수가능금액</summary>
    [DataMember, JsonProperty("수익증권매수가능금액")]
    public string? 수익증권매수가능금액
    {
        get; set;
    }
    /// <summary>20%종목주문가능금액</summary>
    [DataMember, JsonProperty("20%종목주문가능금액")]
    public string? _20종목주문가능금액
    {
        get; set;
    }
    /// <summary>30%종목주문가능금액</summary>
    [DataMember, JsonProperty("30%종목주문가능금액")]
    public string? _30종목주문가능금액
    {
        get; set;
    }
    /// <summary>40%종목주문가능금액</summary>
    [DataMember, JsonProperty("40%종목주문가능금액")]
    public string? _40종목주문가능금액
    {
        get; set;
    }
    /// <summary>100%종목주문가능금액</summary>
    [DataMember, JsonProperty("100%종목주문가능금액")]
    public string? _100종목주문가능금액
    {
        get; set;
    }
    /// <summary>현금미수금</summary>
    [DataMember, JsonProperty("현금미수금")]
    public string? 현금미수금
    {
        get; set;
    }
    /// <summary>현금미수연체료</summary>
    [DataMember, JsonProperty("현금미수연체료")]
    public string? 현금미수연체료
    {
        get; set;
    }
    /// <summary>현금미수금합계</summary>
    [DataMember, JsonProperty("현금미수금합계")]
    public string? 현금미수금합계
    {
        get; set;
    }
    /// <summary>신용이자미납</summary>
    [DataMember, JsonProperty("신용이자미납")]
    public string? 신용이자미납
    {
        get; set;
    }
    /// <summary>신용이자미납연체료</summary>
    [DataMember, JsonProperty("신용이자미납연체료")]
    public string? 신용이자미납연체료
    {
        get; set;
    }
    /// <summary>신용이자미납합계</summary>
    [DataMember, JsonProperty("신용이자미납합계")]
    public string? 신용이자미납합계
    {
        get; set;
    }
    /// <summary>기타대여금</summary>
    [DataMember, JsonProperty("기타대여금")]
    public string? 기타대여금
    {
        get; set;
    }
    /// <summary>기타대여금연체료</summary>
    [DataMember, JsonProperty("기타대여금연체료")]
    public string? 기타대여금연체료
    {
        get; set;
    }
    /// <summary>기타대여금합계</summary>
    [DataMember, JsonProperty("기타대여금합계")]
    public string? 기타대여금합계
    {
        get; set;
    }
    /// <summary>미상환융자금</summary>
    [DataMember, JsonProperty("미상환융자금")]
    public string? 미상환융자금
    {
        get; set;
    }
    /// <summary>융자금합계</summary>
    [DataMember, JsonProperty("융자금합계")]
    public string? 융자금합계
    {
        get; set;
    }
    /// <summary>대주금합계</summary>
    [DataMember, JsonProperty("대주금합계")]
    public string? 대주금합계
    {
        get; set;
    }
    /// <summary>신용담보비율</summary>
    [DataMember, JsonProperty("신용담보비율")]
    public string? 신용담보비율
    {
        get; set;
    }
    /// <summary>중도이용료</summary>
    [DataMember, JsonProperty("중도이용료")]
    public string? 중도이용료
    {
        get; set;
    }
    /// <summary>최소주문가능금액</summary>
    [DataMember, JsonProperty("최소주문가능금액")]
    public string? 최소주문가능금액
    {
        get; set;
    }
    /// <summary>대출총평가금액</summary>
    [DataMember, JsonProperty("대출총평가금액")]
    public string? 대출총평가금액
    {
        get; set;
    }
    /// <summary>예탁담보대출잔고</summary>
    [DataMember, JsonProperty("예탁담보대출잔고")]
    public string? 예탁담보대출잔고
    {
        get; set;
    }
    /// <summary>매도담보대출잔고</summary>
    [DataMember, JsonProperty("매도담보대출잔고")]
    public string? 매도담보대출잔고
    {
        get; set;
    }
    /// <summary>d+1추정예수금</summary>
    [DataMember, JsonProperty("d+1추정예수금")]
    public string? D1추정예수금
    {
        get;
        set;
    }
    /// <summary>d+1매도매수정산금</summary>
    [DataMember, JsonProperty("d+1매도매수정산금")]
    public string? D1매도매수정산금
    {
        get;
        set;
    }
    /// <summary>d+1매수정산금</summary>
    [DataMember, JsonProperty("d+1매수정산금")]
    public string? D1매수정산금
    {
        get;
        set;
    }
    /// <summary>d+1미수변제소요금</summary>
    [DataMember, JsonProperty("d+1미수변제소요금")]
    public string? D1미수변제소요금
    {
        get;
        set;
    }
    /// <summary>d+1매도정산금</summary>
    [DataMember, JsonProperty("d+1매도정산금")]
    public string? D1매도정산금
    {
        get;
        set;
    }
    /// <summary>d+1출금가능금액</summary>
    [DataMember, JsonProperty("d+1출금가능금액")]
    public string? D1출금가능금액
    {
        get;
        set;
    }
    /// <summary>d+2추정예수금</summary>
    [DataMember, JsonProperty("d+2추정예수금")]
    public string? D2추정예수금
    {
        get;
        set;
    }
    /// <summary>d+2매도매수정산금</summary>
    [DataMember, JsonProperty("d+2매도매수정산금")]
    public string? D2매도매수정산금
    {
        get;
        set;
    }
    /// <summary>d+2매수정산금</summary>
    [DataMember, JsonProperty("d+2매수정산금")]
    public string? D2매수정산금
    {
        get;
        set;
    }
    /// <summary>d+2미수변제소요금</summary>
    [DataMember, JsonProperty("d+2미수변제소요금")]
    public string? D2미수변제소요금
    {
        get;
        set;
    }
    /// <summary>d+2매도정산금</summary>
    [DataMember, JsonProperty("d+2매도정산금")]
    public string? D2매도정산금
    {
        get;
        set;
    }
    /// <summary>d+2출금가능금액</summary>
    [DataMember, JsonProperty("d+2출금가능금액")]
    public string? D2출금가능금액
    {
        get;
        set;
    }
    /// <summary>출력건수</summary>
    [DataMember, JsonProperty("출력건수")]
    public string? 출력건수
    {
        get; set;
    }
}