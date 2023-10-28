using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>프로그램매매누적추이</summary>
public class MultiOPT90007
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? 일자
    {
        get; set;
    }
    /// <summary>KOSPI200</summary>
    [DataMember, JsonProperty("KOSPI200")]
    public string? KOSPI200
    {
        get; set;
    }
    /// <summary>BASIS</summary>
    [DataMember, JsonProperty("BASIS")]
    public string? BASIS
    {
        get; set;
    }
    /// <summary>차익거래당일</summary>
    [DataMember, JsonProperty("차익거래당일")]
    public string? 차익거래당일
    {
        get; set;
    }
    /// <summary>차익거래누적</summary>
    [DataMember, JsonProperty("차익거래누적")]
    public string? 차익거래누적
    {
        get; set;
    }
    /// <summary>비차익거래당일</summary>
    [DataMember, JsonProperty("비차익거래당일")]
    public string? 비차익거래당일
    {
        get; set;
    }
    /// <summary>비차익거래누적</summary>
    [DataMember, JsonProperty("비차익거래누적")]
    public string? 비차익거래누적
    {
        get; set;
    }
    /// <summary>전체당일</summary>
    [DataMember, JsonProperty("전체당일")]
    public string? 전체당일
    {
        get; set;
    }
    /// <summary>전체누적</summary>
    [DataMember, JsonProperty("전체누적")]
    public string? 전체누적
    {
        get; set;
    }
}