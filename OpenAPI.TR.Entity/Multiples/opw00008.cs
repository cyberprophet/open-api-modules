using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌별익일결제예정내역배열</summary>
public class MultiOpw00008
{
    /// <summary>일련번호</summary>
    [DataMember, JsonProperty("일련번호")]
    public string? 일련번호
    {
        get; set;
    }
    /// <summary>종목번호</summary>
    [DataMember, JsonProperty("종목번호")]
    public string? 종목번호
    {
        get; set;
    }
    /// <summary>대출일</summary>
    [DataMember, JsonProperty("대출일")]
    public string? 대출일
    {
        get; set;
    }
    /// <summary>수량</summary>
    [DataMember, JsonProperty("수량")]
    public string? 수량
    {
        get; set;
    }
    /// <summary>약정금액</summary>
    [DataMember, JsonProperty("약정금액")]
    public string? 약정금액
    {
        get; set;
    }
    /// <summary>수수료</summary>
    [DataMember, JsonProperty("수수료")]
    public string? 수수료
    {
        get; set;
    }
    /// <summary>소득세</summary>
    [DataMember, JsonProperty("소득세")]
    public string? 소득세
    {
        get; set;
    }
    /// <summary>농특세</summary>
    [DataMember, JsonProperty("농특세")]
    public string? 농특세
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>매도수구분</summary>
    [DataMember, JsonProperty("매도수구분")]
    public string? 매도수구분
    {
        get; set;
    }
    /// <summary>단가</summary>
    [DataMember, JsonProperty("단가")]
    public string? 단가
    {
        get; set;
    }
    /// <summary>정산금액</summary>
    [DataMember, JsonProperty("정산금액")]
    public string? 정산금액
    {
        get; set;
    }
    /// <summary>거래세</summary>
    [DataMember, JsonProperty("거래세")]
    public string? 거래세
    {
        get; set;
    }
    /// <summary>주민세</summary>
    [DataMember, JsonProperty("주민세")]
    public string? 주민세
    {
        get; set;
    }
    /// <summary>신용구분</summary>
    [DataMember, JsonProperty("신용구분")]
    public string? 신용구분
    {
        get; set;
    }
}