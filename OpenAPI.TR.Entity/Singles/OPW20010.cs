using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵예탁금및증거금조회</summary>
public class SingleOPW20010
{
    /// <summary>예탁총액</summary>
    [DataMember, JsonProperty("예탁총액")]
    public string? 예탁총액
    {
        get; set;
    }
    /// <summary>예탁현금</summary>
    [DataMember, JsonProperty("예탁현금")]
    public string? 예탁현금
    {
        get; set;
    }
    /// <summary>에탁대용</summary>
    [DataMember, JsonProperty("에탁대용")]
    public string? 에탁대용
    {
        get; set;
    }
    /// <summary>증거금총액</summary>
    [DataMember, JsonProperty("증거금총액")]
    public string? 증거금총액
    {
        get; set;
    }
    /// <summary>증거금현금</summary>
    [DataMember, JsonProperty("증거금현금")]
    public string? 증거금현금
    {
        get; set;
    }
    /// <summary>증거금대용금</summary>
    [DataMember, JsonProperty("증거금대용금")]
    public string? 증거금대용금
    {
        get; set;
    }
    /// <summary>주문가능총액</summary>
    [DataMember, JsonProperty("주문가능총액")]
    public string? 주문가능총액
    {
        get; set;
    }
    /// <summary>주문가능현금</summary>
    [DataMember, JsonProperty("주문가능현금")]
    public string? 주문가능현금
    {
        get; set;
    }
    /// <summary>주문가능대용금</summary>
    [DataMember, JsonProperty("주문가능대용금")]
    public string? 주문가능대용금
    {
        get; set;
    }
    /// <summary>추가증거금총액</summary>
    [DataMember, JsonProperty("추가증거금총액")]
    public string? 추가증거금총액
    {
        get; set;
    }
    /// <summary>추가증거금현금</summary>
    [DataMember, JsonProperty("추가증거금현금")]
    public string? 추가증거금현금
    {
        get; set;
    }
    /// <summary>추가증거금대용금</summary>
    [DataMember, JsonProperty("추가증거금대용금")]
    public string? 추가증거금대용금
    {
        get; set;
    }
    /// <summary>인출가능총액</summary>
    [DataMember, JsonProperty("인출가능총액")]
    public string? 인출가능총액
    {
        get; set;
    }
    /// <summary>인출가능현금</summary>
    [DataMember, JsonProperty("인출가능현금")]
    public string? 인출가능현금
    {
        get; set;
    }
    /// <summary>인출가능대용금</summary>
    [DataMember, JsonProperty("인출가능대용금")]
    public string? 인출가능대용금
    {
        get; set;
    }
    /// <summary>순자산금액</summary>
    [DataMember, JsonProperty("순자산금액")]
    public string? 순자산금액
    {
        get; set;
    }
    /// <summary>익일예탁총액</summary>
    [DataMember, JsonProperty("익일예탁총액")]
    public string? 익일예탁총액
    {
        get; set;
    }
    /// <summary>개장예탁총액</summary>
    [DataMember, JsonProperty("개장예탁총액")]
    public string? 개장예탁총액
    {
        get; set;
    }
    /// <summary>선물정산차금</summary>
    [DataMember, JsonProperty("선물정산차금")]
    public string? 선물정산차금
    {
        get; set;
    }
    /// <summary>선물청산손익</summary>
    [DataMember, JsonProperty("선물청산손익")]
    public string? 선물청산손익
    {
        get; set;
    }
    /// <summary>선물평가손익</summary>
    [DataMember, JsonProperty("선물평가손익")]
    public string? 선물평가손익
    {
        get; set;
    }
    /// <summary>선물약정금액</summary>
    [DataMember, JsonProperty("선물약정금액")]
    public string? 선물약정금액
    {
        get; set;
    }
    /// <summary>옵션결제차금</summary>
    [DataMember, JsonProperty("옵션결제차금")]
    public string? 옵션결제차금
    {
        get; set;
    }
    /// <summary>옵션청산손익</summary>
    [DataMember, JsonProperty("옵션청산손익")]
    public string? 옵션청산손익
    {
        get; set;
    }
    /// <summary>옵션평가손익</summary>
    [DataMember, JsonProperty("옵션평가손익")]
    public string? 옵션평가손익
    {
        get; set;
    }
    /// <summary>옵션약정금액</summary>
    [DataMember, JsonProperty("옵션약정금액")]
    public string? 옵션약정금액
    {
        get; set;
    }
    /// <summary>전일장종료예탁총액</summary>
    [DataMember, JsonProperty("전일장종료예탁총액")]
    public string? 전일장종료예탁총액
    {
        get; set;
    }
    /// <summary>전일장종료예탁현금</summary>
    [DataMember, JsonProperty("전일장종료예탁현금")]
    public string? 전일장종료예탁현금
    {
        get; set;
    }
    /// <summary>전일장종료예탁대용금</summary>
    [DataMember, JsonProperty("전일장종료예탁대용금")]
    public string? 전일장종료예탁대용금
    {
        get; set;
    }
}