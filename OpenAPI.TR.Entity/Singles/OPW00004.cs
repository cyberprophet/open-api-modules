using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌평가현황</summary>
public class SingleOPW00004
{
    /// <summary>계좌명</summary>
    [DataMember, JsonProperty("계좌명")]
    public string? 계좌명
    {
        get; set;
    }
    /// <summary>지점명</summary>
    [DataMember, JsonProperty("지점명")]
    public string? 지점명
    {
        get; set;
    }
    /// <summary>예수금</summary>
    [DataMember, JsonProperty("예수금")]
    public string? 예수금
    {
        get; set;
    }
    /// <summary>D+2추정예수금</summary>
    [DataMember, JsonProperty("D+2추정예수금")]
    public string? D2추정예수금
    {
        get; set;
    }
    /// <summary>유가잔고평가액</summary>
    [DataMember, JsonProperty("유가잔고평가액")]
    public string? 유가잔고평가액
    {
        get; set;
    }
    /// <summary>예탁자산평가액</summary>
    [DataMember, JsonProperty("예탁자산평가액")]
    public string? 예탁자산평가액
    {
        get; set;
    }
    /// <summary>총매입금액</summary>
    [DataMember, JsonProperty("총매입금액")]
    public string? 총매입금액
    {
        get; set;
    }
    /// <summary>추정예탁자산</summary>
    [DataMember, JsonProperty("추정예탁자산")]
    public string? 추정예탁자산
    {
        get; set;
    }
    /// <summary>매도담보대출금</summary>
    [DataMember, JsonProperty("매도담보대출금")]
    public string? 매도담보대출금
    {
        get; set;
    }
    /// <summary>당일투자원금</summary>
    [DataMember, JsonProperty("당일투자원금")]
    public string? 당일투자원금
    {
        get; set;
    }
    /// <summary>당월투자원금</summary>
    [DataMember, JsonProperty("당월투자원금")]
    public string? 당월투자원금
    {
        get; set;
    }
    /// <summary>누적투자원금</summary>
    [DataMember, JsonProperty("누적투자원금")]
    public string? 누적투자원금
    {
        get; set;
    }
    /// <summary>당일투자손익</summary>
    [DataMember, JsonProperty("당일투자손익")]
    public string? 당일투자손익
    {
        get; set;
    }
    /// <summary>당월투자손익</summary>
    [DataMember, JsonProperty("당월투자손익")]
    public string? 당월투자손익
    {
        get; set;
    }
    /// <summary>누적투자손익</summary>
    [DataMember, JsonProperty("누적투자손익")]
    public string? 누적투자손익
    {
        get; set;
    }
    /// <summary>당일손익율</summary>
    [DataMember, JsonProperty("당일손익율")]
    public string? 당일손익율
    {
        get; set;
    }
    /// <summary>당월손익율</summary>
    [DataMember, JsonProperty("당월손익율")]
    public string? 당월손익율
    {
        get; set;
    }
    /// <summary>누적손익율</summary>
    [DataMember, JsonProperty("누적손익율")]
    public string? 누적손익율
    {
        get; set;
    }
    /// <summary>출력건수</summary>
    [DataMember, JsonProperty("출력건수")]
    public string? 출력건수
    {
        get; set;
    }
}