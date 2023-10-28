using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>기관외국인연속매매현황</summary>
public class MultiOpt10131
{
    /// <summary>순위</summary>
    [DataMember, JsonProperty("순위")]
    public string? 순위
    {
        get; set;
    }
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
    /// <summary>기간중주가등락률</summary>
    [DataMember, JsonProperty("기간중주가등락률")]
    public string? 기간중주가등락률
    {
        get; set;
    }
    /// <summary>기관순매매금액</summary>
    [DataMember, JsonProperty("기관순매매금액")]
    public string? 기관순매매금액
    {
        get; set;
    }
    /// <summary>기관순매매량</summary>
    [DataMember, JsonProperty("기관순매매량")]
    public string? 기관순매매량
    {
        get; set;
    }
    /// <summary>기관계연속순매수일수</summary>
    [DataMember, JsonProperty("기관계연속순매수일수")]
    public string? 기관계연속순매수일수
    {
        get; set;
    }
    /// <summary>기관계연속순매수량</summary>
    [DataMember, JsonProperty("기관계연속순매수량")]
    public string? 기관계연속순매수량
    {
        get; set;
    }
    /// <summary>기관계연속순매수금액</summary>
    [DataMember, JsonProperty("기관계연속순매수금액")]
    public string? 기관계연속순매수금액
    {
        get; set;
    }
    /// <summary>외국인순매매량</summary>
    [DataMember, JsonProperty("외국인순매매량")]
    public string? 외국인순매매량
    {
        get; set;
    }
    /// <summary>외국인순매매액</summary>
    [DataMember, JsonProperty("외국인순매매액")]
    public string? 외국인순매매액
    {
        get; set;
    }
    /// <summary>외국인연속순매수일수</summary>
    [DataMember, JsonProperty("외국인연속순매수일수")]
    public string? 외국인연속순매수일수
    {
        get; set;
    }
    /// <summary>외국인연속순매수량</summary>
    [DataMember, JsonProperty("외국인연속순매수량")]
    public string? 외국인연속순매수량
    {
        get; set;
    }
    /// <summary>외국인연속순매수금액</summary>
    [DataMember, JsonProperty("외국인연속순매수금액")]
    public string? 외국인연속순매수금액
    {
        get; set;
    }
    /// <summary>순매매량</summary>
    [DataMember, JsonProperty("순매매량")]
    public string? 순매매량
    {
        get; set;
    }
    /// <summary>순매매액</summary>
    [DataMember, JsonProperty("순매매액")]
    public string? 순매매액
    {
        get; set;
    }
    /// <summary>합계연속순매수일수</summary>
    [DataMember, JsonProperty("합계연속순매수일수")]
    public string? 합계연속순매수일수
    {
        get; set;
    }
    /// <summary>합계연속순매매수량</summary>
    [DataMember, JsonProperty("합계연속순매매수량")]
    public string? 합계연속순매매수량
    {
        get; set;
    }
    /// <summary>합계연속순매수금액</summary>
    [DataMember, JsonProperty("합계연속순매수금액")]
    public string? 합계연속순매수금액
    {
        get; set;
    }
}