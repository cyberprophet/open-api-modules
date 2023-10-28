using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일별기관매매종목</summary>
public class MultiOPT10044
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
    /// <summary>순매수수량</summary>
    [DataMember, JsonProperty("순매수수량")]
    public string? 순매수수량
    {
        get; set;
    }
    /// <summary>순매수금액</summary>
    [DataMember, JsonProperty("순매수금액")]
    public string? 순매수금액
    {
        get; set;
    }
    /// <summary>추정평균가</summary>
    [DataMember, JsonProperty("추정평균가")]
    public string? 추정평균가
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>평균가대비</summary>
    [DataMember, JsonProperty("평균가대비")]
    public string? 평균가대비
    {
        get; set;
    }
    /// <summary>대비율</summary>
    [DataMember, JsonProperty("대비율")]
    public string? 대비율
    {
        get; set;
    }
}