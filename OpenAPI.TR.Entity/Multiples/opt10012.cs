using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주문체결</summary>
public class MultiOpt10012
{
    /// <summary>주문수량</summary>
    [DataMember, JsonProperty("주문수량")]
    public string? 주문수량
    {
        get; set;
    }
    /// <summary>주문가격</summary>
    [DataMember, JsonProperty("주문가격")]
    public string? 주문가격
    {
        get; set;
    }
    /// <summary>미체결수량</summary>
    [DataMember, JsonProperty("미체결수량")]
    public string? 미체결수량
    {
        get; set;
    }
    /// <summary>체결누계금액</summary>
    [DataMember, JsonProperty("체결누계금액")]
    public string? 체결누계금액
    {
        get; set;
    }
    /// <summary>원주문번호</summary>
    [DataMember, JsonProperty("원주문번호")]
    public string? 원주문번호
    {
        get; set;
    }
    /// <summary>주문구분</summary>
    [DataMember, JsonProperty("주문구분")]
    public string? 주문구분
    {
        get; set;
    }
    /// <summary>매매구분</summary>
    [DataMember, JsonProperty("매매구분")]
    public string? 매매구분
    {
        get; set;
    }
    /// <summary>매도수구분</summary>
    [DataMember, JsonProperty("매도수구분")]
    public string? 매도수구분
    {
        get; set;
    }
    /// <summary>주문/체결시간</summary>
    [DataMember, JsonProperty("주문/체결시간")]
    public string? 주문체결시간
    {
        get; set;
    }
    /// <summary>체결가</summary>
    [DataMember, JsonProperty("체결가")]
    public string? 체결가
    {
        get; set;
    }
    /// <summary>체결량</summary>
    [DataMember, JsonProperty("체결량")]
    public string? 체결량
    {
        get; set;
    }
    /// <summary>주문상태</summary>
    [DataMember, JsonProperty("주문상태")]
    public string? 주문상태
    {
        get; set;
    }
    /// <summary>단위체결가</summary>
    [DataMember, JsonProperty("단위체결가")]
    public string? 단위체결가
    {
        get; set;
    }
    /// <summary>대출일</summary>
    [DataMember, JsonProperty("대출일")]
    public string? 대출일
    {
        get; set;
    }
    /// <summary>신용구분</summary>
    [DataMember, JsonProperty("신용구분")]
    public string? 신용구분
    {
        get; set;
    }
    /// <summary>만기일</summary>
    [DataMember, JsonProperty("만기일")]
    public string? 만기일
    {
        get; set;
    }
    /// <summary>보유수량</summary>
    [DataMember, JsonProperty("보유수량")]
    public string? 보유수량
    {
        get; set;
    }
    /// <summary>매입단가</summary>
    [DataMember, JsonProperty("매입단가")]
    public string? 매입단가
    {
        get; set;
    }
    /// <summary>총매입가</summary>
    [DataMember, JsonProperty("총매입가")]
    public string? 총매입가
    {
        get; set;
    }
    /// <summary>주문가능수량</summary>
    [DataMember, JsonProperty("주문가능수량")]
    public string? 주문가능수량
    {
        get; set;
    }
    /// <summary>당일매도수량</summary>
    [DataMember, JsonProperty("당일매도수량")]
    public string? 당일매도수량
    {
        get; set;
    }
    /// <summary>당일매도금액</summary>
    [DataMember, JsonProperty("당일매도금액")]
    public string? 당일매도금액
    {
        get; set;
    }
    /// <summary>당일매수수량</summary>
    [DataMember, JsonProperty("당일매수수량")]
    public string? 당일매수수량
    {
        get; set;
    }
    /// <summary>당일매수금액</summary>
    [DataMember, JsonProperty("당일매수금액")]
    public string? 당일매수금액
    {
        get; set;
    }
    /// <summary>당일매매수수료</summary>
    [DataMember, JsonProperty("당일매매수수료")]
    public string? 당일매매수수료
    {
        get; set;
    }
    /// <summary>당일매매세금</summary>
    [DataMember, JsonProperty("당일매매세금")]
    public string? 당일매매세금
    {
        get; set;
    }
    /// <summary>당일hts매도수수료</summary>
    [DataMember, JsonProperty("당일hts매도수수료")]
    public string? 당일hts매도수수료
    {
        get; set;
    }
    /// <summary>당일hts매수수수료</summary>
    [DataMember, JsonProperty("당일hts매수수수료")]
    public string? 당일hts매수수수료
    {
        get; set;
    }
    /// <summary>당일매도손익</summary>
    [DataMember, JsonProperty("당일매도손익")]
    public string? 당일매도손익
    {
        get; set;
    }
    /// <summary>당일순매수량</summary>
    [DataMember, JsonProperty("당일순매수량")]
    public string? 당일순매수량
    {
        get; set;
    }
    /// <summary>매도/매수구분</summary>
    [DataMember, JsonProperty("매도/매수구분")]
    public string? 매도매수구분
    {
        get; set;
    }
    /// <summary>당일총매도손일</summary>
    [DataMember, JsonProperty("당일총매도손일")]
    public string? 당일총매도손일
    {
        get; set;
    }
    /// <summary>예수금</summary>
    [DataMember, JsonProperty("예수금")]
    public string? 예수금
    {
        get; set;
    }
    /// <summary>사용가능현금</summary>
    [DataMember, JsonProperty("사용가능현금")]
    public string? 사용가능현금
    {
        get; set;
    }
    /// <summary>사용가능대용</summary>
    [DataMember, JsonProperty("사용가능대용")]
    public string? 사용가능대용
    {
        get; set;
    }
    /// <summary>전일재사용</summary>
    [DataMember, JsonProperty("전일재사용")]
    public string? 전일재사용
    {
        get; set;
    }
    /// <summary>당일재사용</summary>
    [DataMember, JsonProperty("당일재사용")]
    public string? 당일재사용
    {
        get; set;
    }
    /// <summary>담보현금</summary>
    [DataMember, JsonProperty("담보현금")]
    public string? 담보현금
    {
        get; set;
    }
    /// <summary>신용금액</summary>
    [DataMember, JsonProperty("신용금액")]
    public string? 신용금액
    {
        get; set;
    }
    /// <summary>신용이자</summary>
    [DataMember, JsonProperty("신용이자")]
    public string? 신용이자
    {
        get; set;
    }
    /// <summary>담보대출수량</summary>
    [DataMember, JsonProperty("담보대출수량")]
    public string? 담보대출수량
    {
        get; set;
    }
    /// <summary>현물주문체결이상유무</summary>
    [DataMember, JsonProperty("현물주문체결이상유무")]
    public string? 현물주문체결이상유무
    {
        get; set;
    }
    /// <summary>현물잔고이상유무</summary>
    [DataMember, JsonProperty("현물잔고이상유무")]
    public string? 현물잔고이상유무
    {
        get; set;
    }
    /// <summary>현물예수금이상유무</summary>
    [DataMember, JsonProperty("현물예수금이상유무")]
    public string? 현물예수금이상유무
    {
        get; set;
    }
    /// <summary>선물주문체결이상유무</summary>
    [DataMember, JsonProperty("선물주문체결이상유무")]
    public string? 선물주문체결이상유무
    {
        get; set;
    }
    /// <summary>선물잔고이상유무</summary>
    [DataMember, JsonProperty("선물잔고이상유무")]
    public string? 선물잔고이상유무
    {
        get; set;
    }
    /// <summary>D+1추정예수금</summary>
    [DataMember, JsonProperty("D+1추정예수금")]
    public string? D1추정예수금
    {
        get;
        set;
    }
    /// <summary>D+2추정예수금</summary>
    [DataMember, JsonProperty("D+2추정예수금")]
    public string? D2추정예수금
    {
        get;
        set;
    }
    /// <summary>D+1매수/매도정산금</summary>
    [DataMember, JsonProperty("D+1매수/매도정산금")]
    public string? D1매수매도정산금
    {
        get;
        set;
    }
    /// <summary>D+2매수/매도정산금</summary>
    [DataMember, JsonProperty("D+2매수/매도정산금")]
    public string? D2매수매도정산금
    {
        get;
        set;
    }
    /// <summary>D+1연체변제소요금</summary>
    [DataMember, JsonProperty("D+1연체변제소요금")]
    public string? D1연체변제소요금
    {
        get;
        set;
    }
    /// <summary>D+2연체변제소요금</summary>
    [DataMember, JsonProperty("D+2연체변제소요금")]
    public string? D2연체변제소요금
    {
        get;
        set;
    }
    /// <summary>D+1추정인출가능금</summary>
    [DataMember, JsonProperty("D+1추정인출가능금")]
    public string? D1추정인출가능금
    {
        get;
        set;
    }
    /// <summary>D+2추정인출가능금</summary>
    [DataMember, JsonProperty("D+2추정인출가능금")]
    public string? D2추정인출가능금
    {
        get;
        set;
    }
    /// <summary>현금증거금</summary>
    [DataMember, JsonProperty("현금증거금")]
    public string? 현금증거금
    {
        get; set;
    }
    /// <summary>대용잔고</summary>
    [DataMember, JsonProperty("대용잔고")]
    public string? 대용잔고
    {
        get; set;
    }
    /// <summary>대용증거금</summary>
    [DataMember, JsonProperty("대용증거금")]
    public string? 대용증거금
    {
        get; set;
    }
    /// <summary>수표금액</summary>
    [DataMember, JsonProperty("수표금액")]
    public string? 수표금액
    {
        get; set;
    }
    /// <summary>현금미수금</summary>
    [DataMember, JsonProperty("현금미수금")]
    public string? 현금미수금
    {
        get; set;
    }
    /// <summary>신용설정보증금</summary>
    [DataMember, JsonProperty("신용설정보증금")]
    public string? 신용설정보증금
    {
        get; set;
    }
    /// <summary>인출가능금액</summary>
    [DataMember, JsonProperty("인출가능금액")]
    public string? 인출가능금액
    {
        get; set;
    }
}