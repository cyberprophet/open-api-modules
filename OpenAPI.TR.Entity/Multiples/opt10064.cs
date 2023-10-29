using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>장중투자자별매매차트</summary>
public class MultiOpt10064
{
    /// <summary>시간</summary>
    [DataMember, JsonProperty("시간")]
    public string? Time
    {
        get; set;
    }
    /// <summary>외국인투자자</summary>
    [DataMember, JsonProperty("외국인투자자")]
    public string? AForeignInvestor
    {
        get; set;
    }
    /// <summary>기관계</summary>
    [DataMember, JsonProperty("기관계")]
    public string? TheEngineSystem
    {
        get; set;
    }
    /// <summary>투신</summary>
    [DataMember, JsonProperty("투신")]
    public string? JumpOutOfOnesWay
    {
        get; set;
    }
    /// <summary>보험</summary>
    [DataMember, JsonProperty("보험")]
    public string? Insurance
    {
        get; set;
    }
    /// <summary>은행</summary>
    [DataMember, JsonProperty("은행")]
    public string? Bank
    {
        get; set;
    }
    /// <summary>연기금등</summary>
    [DataMember, JsonProperty("연기금등")]
    public string? PensionFundEtc
    {
        get; set;
    }
    /// <summary>기타법인</summary>
    [DataMember, JsonProperty("기타법인")]
    public string? OtherCorporations
    {
        get; set;
    }
    /// <summary>국가</summary>
    [DataMember, JsonProperty("국가")]
    public string? Nation
    {
        get; set;
    }
}