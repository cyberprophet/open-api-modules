using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>투자자별만기손익차트</summary>
public class MultiOpt50038
{
    /// <summary>평가손익</summary>
    [DataMember, JsonProperty("평가손익")]
    public string? 평가손익
    {
        get; set;
    }
    /// <summary>매입단가</summary>
    [DataMember, JsonProperty("매입단가")]
    public string? 매입단가
    {
        get; set;
    }
    /// <summary>투자자별순매수수량</summary>
    [DataMember, JsonProperty("투자자별순매수수량")]
    public string? 투자자별순매수수량
    {
        get; set;
    }
    /// <summary>미결제약정</summary>
    [DataMember, JsonProperty("미결제약정")]
    public string? 미결제약정
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
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>행사가</summary>
    [DataMember, JsonProperty("행사가")]
    public string? 행사가
    {
        get; set;
    }
    /// <summary>지수환산</summary>
    [DataMember, JsonProperty("지수환산")]
    public string? 지수환산
    {
        get; set;
    }
    /// <summary>ATM구분</summary>
    [DataMember, JsonProperty("ATM구분")]
    public string? ATM구분
    {
        get; set;
    }
    /// <summary>대칭구분</summary>
    [DataMember, JsonProperty("대칭구분")]
    public string? 대칭구분
    {
        get; set;
    }
    /// <summary>풋_종목코드</summary>
    [DataMember, JsonProperty("풋_종목코드")]
    public string? 풋_종목코드
    {
        get; set;
    }
    /// <summary>풋_현재가</summary>
    [DataMember, JsonProperty("풋_현재가")]
    public string? 풋_현재가
    {
        get; set;
    }
    /// <summary>풋_전일대비</summary>
    [DataMember, JsonProperty("풋_전일대비")]
    public string? 풋_전일대비
    {
        get; set;
    }
    /// <summary>풋_대비기호</summary>
    [DataMember, JsonProperty("풋_대비기호")]
    public string? 풋_대비기호
    {
        get; set;
    }
    /// <summary>풋_미결제약정</summary>
    [DataMember, JsonProperty("풋_미결제약정")]
    public string? 풋_미결제약정
    {
        get; set;
    }
    /// <summary>풋_투자자별순매수수량</summary>
    [DataMember, JsonProperty("풋_투자자별순매수수량")]
    public string? 풋_투자자별순매수수량
    {
        get; set;
    }
    /// <summary>풋_매입단가</summary>
    [DataMember, JsonProperty("풋_매입단가")]
    public string? 풋_매입단가
    {
        get; set;
    }
    /// <summary>풋_평가손익</summary>
    [DataMember, JsonProperty("풋_평가손익")]
    public string? 풋_평가손익
    {
        get; set;
    }
}