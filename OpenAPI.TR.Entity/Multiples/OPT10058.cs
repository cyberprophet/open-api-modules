using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>투자자별일별매매종목</summary>
public class MultiOPT10058
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
    /// <summary>순매도수량</summary>
    [DataMember, JsonProperty("순매도수량")]
    public string? 순매도수량
    {
        get; set;
    }
    /// <summary>순매도금액</summary>
    [DataMember, JsonProperty("순매도금액")]
    public string? 순매도금액
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
    /// <summary>대비기호</summary>
    [DataMember, JsonProperty("대비기호")]
    public string? 대비기호
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? 전일대비
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
    /// <summary>기간거래량</summary>
    [DataMember, JsonProperty("기간거래량")]
    public string? 기간거래량
    {
        get; set;
    }
}