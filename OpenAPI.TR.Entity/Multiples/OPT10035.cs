using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>외인연속순매매상위</summary>
public class MultiOPT10035
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>전일대비기호</summary>
    [DataMember, JsonProperty("전일대비기호")]
    public string? 전일대비기호
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? 전일대비
    {
        get; set;
    }
    /// <summary>D-1</summary>
    [DataMember, JsonProperty("D-1")]
    public string? D1
    {
        get; set;
    }
    /// <summary>D-2</summary>
    [DataMember, JsonProperty("D-2")]
    public string? D2
    {
        get; set;
    }
    /// <summary>D-3</summary>
    [DataMember, JsonProperty("D-3")]
    public string? D3
    {
        get;
        set;
    }
    /// <summary>합계</summary>
    [DataMember, JsonProperty("합계")]
    public string? 합계
    {
        get; set;
    }
    /// <summary>한도소진율</summary>
    [DataMember, JsonProperty("한도소진율")]
    public string? 한도소진율
    {
        get; set;
    }
    /// <summary>전일대비1</summary>
    [DataMember, JsonProperty("전일대비1")]
    public string? 전일대비1
    {
        get; set;
    }
    /// <summary>전일대비2</summary>
    [DataMember, JsonProperty("전일대비2")]
    public string? 전일대비2
    {
        get; set;
    }
    /// <summary>전일대비3</summary>
    [DataMember, JsonProperty("전일대비3")]
    public string? 전일대비3
    {
        get; set;
    }
}