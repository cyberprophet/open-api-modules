using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>장중투자자별매매차트</summary>
public class MultiOpt10064
{
    /// <summary>시간</summary>
    [DataMember, JsonProperty("시간")]
    public string? 시간
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
    /// <summary>투신</summary>
    [DataMember, JsonProperty("투신")]
    public string? 투신
    {
        get; set;
    }
    /// <summary>보험</summary>
    [DataMember, JsonProperty("보험")]
    public string? 보험
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
    /// <summary>기타법인</summary>
    [DataMember, JsonProperty("기타법인")]
    public string? 기타법인
    {
        get; set;
    }
    /// <summary>국가</summary>
    [DataMember, JsonProperty("국가")]
    public string? 국가
    {
        get; set;
    }
}