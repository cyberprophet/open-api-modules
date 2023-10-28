using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW괴리율</summary>
public class MultiOPT30004
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>발행사명</summary>
    [DataMember, JsonProperty("발행사명")]
    public string? 발행사명
    {
        get; set;
    }
    /// <summary>회차</summary>
    [DataMember, JsonProperty("회차")]
    public string? 회차
    {
        get; set;
    }
    /// <summary>기초자산명</summary>
    [DataMember, JsonProperty("기초자산명")]
    public string? 기초자산명
    {
        get; set;
    }
    /// <summary>권리구분</summary>
    [DataMember, JsonProperty("권리구분")]
    public string? 권리구분
    {
        get; set;
    }
    /// <summary>괴리율</summary>
    [DataMember, JsonProperty("괴리율")]
    public string? 괴리율
    {
        get; set;
    }
    /// <summary>베이시스</summary>
    [DataMember, JsonProperty("베이시스")]
    public string? 베이시스
    {
        get; set;
    }
    /// <summary>잔존일수</summary>
    [DataMember, JsonProperty("잔존일수")]
    public string? 잔존일수
    {
        get; set;
    }
    /// <summary>이론가</summary>
    [DataMember, JsonProperty("이론가")]
    public string? 이론가
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>대비구분</summary>
    [DataMember, JsonProperty("대비구분")]
    public string? 대비구분
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
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? 거래량
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
}