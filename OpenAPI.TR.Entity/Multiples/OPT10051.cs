using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종별순매수</summary>
public class MultiOPT10051
{
    /// <summary>업종코드</summary>
    [DataMember, JsonProperty("업종코드")]
    public string? 업종코드
    {
        get; set;
    }
    /// <summary>업종명</summary>
    [DataMember, JsonProperty("업종명")]
    public string? 업종명
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>대비부호</summary>
    [DataMember, JsonProperty("대비부호")]
    public string? 대비부호
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? 전일대비
    {
        get; set;
    }
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? 등락율
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? 거래량
    {
        get; set;
    }
    /// <summary>증권순매수</summary>
    [DataMember, JsonProperty("증권순매수")]
    public string? 증권순매수
    {
        get; set;
    }
    /// <summary>보험순매수</summary>
    [DataMember, JsonProperty("보험순매수")]
    public string? 보험순매수
    {
        get; set;
    }
    /// <summary>투신순매수</summary>
    [DataMember, JsonProperty("투신순매수")]
    public string? 투신순매수
    {
        get; set;
    }
    /// <summary>은행순매수</summary>
    [DataMember, JsonProperty("은행순매수")]
    public string? 은행순매수
    {
        get; set;
    }
    /// <summary>종신금순매수</summary>
    [DataMember, JsonProperty("종신금순매수")]
    public string? 종신금순매수
    {
        get; set;
    }
    /// <summary>기금순매수</summary>
    [DataMember, JsonProperty("기금순매수")]
    public string? 기금순매수
    {
        get; set;
    }
    /// <summary>기타법인순매수</summary>
    [DataMember, JsonProperty("기타법인순매수")]
    public string? 기타법인순매수
    {
        get; set;
    }
    /// <summary>개인순매수</summary>
    [DataMember, JsonProperty("개인순매수")]
    public string? 개인순매수
    {
        get; set;
    }
    /// <summary>외국인순매수</summary>
    [DataMember, JsonProperty("외국인순매수")]
    public string? 외국인순매수
    {
        get; set;
    }
    /// <summary>내국인대우외국인순매수</summary>
    [DataMember, JsonProperty("내국인대우외국인순매수")]
    public string? 내국인대우외국인순매수
    {
        get; set;
    }
    /// <summary>국가순매수</summary>
    [DataMember, JsonProperty("국가순매수")]
    public string? 국가순매수
    {
        get; set;
    }
    /// <summary>사모펀드순매수</summary>
    [DataMember, JsonProperty("사모펀드순매수")]
    public string? 사모펀드순매수
    {
        get; set;
    }
    /// <summary>기관계순매수</summary>
    [DataMember, JsonProperty("기관계순매수")]
    public string? 기관계순매수
    {
        get; set;
    }
}