using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>동일순매매순위</summary>
public class MultiOpt10062
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>순위</summary>
    [DataMember, JsonProperty("순위")]
    public string? 순위
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
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? 등락율
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? 누적거래량
    {
        get; set;
    }
    /// <summary>기관순매매수량</summary>
    [DataMember, JsonProperty("기관순매매수량")]
    public string? 기관순매매수량
    {
        get; set;
    }
    /// <summary>기관순매매금액</summary>
    [DataMember, JsonProperty("기관순매매금액")]
    public string? 기관순매매금액
    {
        get; set;
    }
    /// <summary>기관순매매평균가</summary>
    [DataMember, JsonProperty("기관순매매평균가")]
    public string? 기관순매매평균가
    {
        get; set;
    }
    /// <summary>외인순매매수량</summary>
    [DataMember, JsonProperty("외인순매매수량")]
    public string? 외인순매매수량
    {
        get; set;
    }
    /// <summary>외인순매매금액</summary>
    [DataMember, JsonProperty("외인순매매금액")]
    public string? 외인순매매금액
    {
        get; set;
    }
    /// <summary>외인순매매평균가</summary>
    [DataMember, JsonProperty("외인순매매평균가")]
    public string? 외인순매매평균가
    {
        get; set;
    }
    /// <summary>순매매수량</summary>
    [DataMember, JsonProperty("순매매수량")]
    public string? 순매매수량
    {
        get; set;
    }
    /// <summary>순매매금액</summary>
    [DataMember, JsonProperty("순매매금액")]
    public string? 순매매금액
    {
        get; set;
    }
}