using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종현재가_일별반복</summary>
public class MultiOpt20009
{
    /// <summary>일자n</summary>
    [DataMember, JsonProperty("일자n")]
    public string? 일자n
    {
        get; set;
    }
    /// <summary>현재가n</summary>
    [DataMember, JsonProperty("현재가n")]
    public string? 현재가n
    {
        get; set;
    }
    /// <summary>전일대비기호n</summary>
    [DataMember, JsonProperty("전일대비기호n")]
    public string? 전일대비기호n
    {
        get; set;
    }
    /// <summary>전일대비n</summary>
    [DataMember, JsonProperty("전일대비n")]
    public string? 전일대비n
    {
        get; set;
    }
    /// <summary>등락률n</summary>
    [DataMember, JsonProperty("등락률n")]
    public string? 등락률n
    {
        get; set;
    }
    /// <summary>누적거래량n</summary>
    [DataMember, JsonProperty("누적거래량n")]
    public string? 누적거래량n
    {
        get; set;
    }
}