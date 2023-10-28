using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>외국인기관매매상위</summary>
public class MultiOpt90009
{
    /// <summary>외인순매도종목코드</summary>
    [DataMember, JsonProperty("외인순매도종목코드")]
    public string? 외인순매도종목코드
    {
        get; set;
    }
    /// <summary>외인순매도종목명</summary>
    [DataMember, JsonProperty("외인순매도종목명")]
    public string? 외인순매도종목명
    {
        get; set;
    }
    /// <summary>외인순매도금액</summary>
    [DataMember, JsonProperty("외인순매도금액")]
    public string? 외인순매도금액
    {
        get; set;
    }
    /// <summary>외인순매도수량</summary>
    [DataMember, JsonProperty("외인순매도수량")]
    public string? 외인순매도수량
    {
        get; set;
    }
    /// <summary>대칭구분</summary>
    [DataMember, JsonProperty("대칭구분")]
    public string? 대칭구분
    {
        get; set;
    }
    /// <summary>외인순매수종목코드</summary>
    [DataMember, JsonProperty("외인순매수종목코드")]
    public string? 외인순매수종목코드
    {
        get; set;
    }
    /// <summary>외인순매수종목명</summary>
    [DataMember, JsonProperty("외인순매수종목명")]
    public string? 외인순매수종목명
    {
        get; set;
    }
    /// <summary>외인순매수금액</summary>
    [DataMember, JsonProperty("외인순매수금액")]
    public string? 외인순매수금액
    {
        get; set;
    }
    /// <summary>외인순매수수량</summary>
    [DataMember, JsonProperty("외인순매수수량")]
    public string? 외인순매수수량
    {
        get; set;
    }
    /// <summary>기관순매도종목코드</summary>
    [DataMember, JsonProperty("기관순매도종목코드")]
    public string? 기관순매도종목코드
    {
        get; set;
    }
    /// <summary>기관순매도종목명</summary>
    [DataMember, JsonProperty("기관순매도종목명")]
    public string? 기관순매도종목명
    {
        get; set;
    }
    /// <summary>기관순매도금액</summary>
    [DataMember, JsonProperty("기관순매도금액")]
    public string? 기관순매도금액
    {
        get; set;
    }
    /// <summary>기관순매도수량</summary>
    [DataMember, JsonProperty("기관순매도수량")]
    public string? 기관순매도수량
    {
        get; set;
    }
    /// <summary>기관순매수종목코드</summary>
    [DataMember, JsonProperty("기관순매수종목코드")]
    public string? 기관순매수종목코드
    {
        get; set;
    }
    /// <summary>기관순매수종목명</summary>
    [DataMember, JsonProperty("기관순매수종목명")]
    public string? 기관순매수종목명
    {
        get; set;
    }
    /// <summary>기관순매수금액</summary>
    [DataMember, JsonProperty("기관순매수금액")]
    public string? 기관순매수금액
    {
        get; set;
    }
    /// <summary>기관순매수수량</summary>
    [DataMember, JsonProperty("기관순매수수량")]
    public string? 기관순매수수량
    {
        get; set;
    }
}