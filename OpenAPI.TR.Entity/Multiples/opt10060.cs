using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별투자자기관별차트</summary>
public class MultiOpt10060
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? 일자
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? 전일대비
    {
        get; set;
    }
    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금")]
    public string? 누적거래대금
    {
        get; set;
    }
    /// <summary>개인투자자</summary>
    [DataMember, JsonProperty("개인투자자")]
    public string? 개인투자자
    {
        get; set;
    }
    /// <summary>외국인투자자</summary>
    [DataMember, JsonProperty("외국인투자자")]
    public string? 외국인투자자
    {
        get; set;
    }
    /// <summary>기관계</summary>
    [DataMember, JsonProperty("기관계")]
    public string? 기관계
    {
        get; set;
    }
    /// <summary>금융투자</summary>
    [DataMember, JsonProperty("금융투자")]
    public string? 금융투자
    {
        get; set;
    }
    /// <summary>보험</summary>
    [DataMember, JsonProperty("보험")]
    public string? 보험
    {
        get; set;
    }
    /// <summary>투신</summary>
    [DataMember, JsonProperty("투신")]
    public string? 투신
    {
        get; set;
    }
    /// <summary>기타금융</summary>
    [DataMember, JsonProperty("기타금융")]
    public string? 기타금융
    {
        get; set;
    }
    /// <summary>은행</summary>
    [DataMember, JsonProperty("은행")]
    public string? 은행
    {
        get; set;
    }
    /// <summary>연기금등</summary>
    [DataMember, JsonProperty("연기금등")]
    public string? 연기금등
    {
        get; set;
    }
    /// <summary>사모펀드</summary>
    [DataMember, JsonProperty("사모펀드")]
    public string? 사모펀드
    {
        get; set;
    }
    /// <summary>국가</summary>
    [DataMember, JsonProperty("국가")]
    public string? 국가
    {
        get; set;
    }
    /// <summary>기타법인</summary>
    [DataMember, JsonProperty("기타법인")]
    public string? 기타법인
    {
        get; set;
    }
    /// <summary>내외국인</summary>
    [DataMember, JsonProperty("내외국인")]
    public string? 내외국인
    {
        get; set;
    }
}