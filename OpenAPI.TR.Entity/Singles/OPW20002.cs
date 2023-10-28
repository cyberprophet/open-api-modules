using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵당일매매변동현황</summary>
public class SingleOPW20002
{
    /// <summary>선물수수료</summary>
    [DataMember, JsonProperty("선물수수료")]
    public string? 선물수수료
    {
        get; set;
    }
    /// <summary>옵션수수료</summary>
    [DataMember, JsonProperty("옵션수수료")]
    public string? 옵션수수료
    {
        get; set;
    }
    /// <summary>주식옵션수수료</summary>
    [DataMember, JsonProperty("주식옵션수수료")]
    public string? 주식옵션수수료
    {
        get; set;
    }
    /// <summary>선물매도수량</summary>
    [DataMember, JsonProperty("선물매도수량")]
    public string? 선물매도수량
    {
        get; set;
    }
    /// <summary>선물매도금액</summary>
    [DataMember, JsonProperty("선물매도금액")]
    public string? 선물매도금액
    {
        get; set;
    }
    /// <summary>선물매도평균가격</summary>
    [DataMember, JsonProperty("선물매도평균가격")]
    public string? 선물매도평균가격
    {
        get; set;
    }
    /// <summary>선물매수수량</summary>
    [DataMember, JsonProperty("선물매수수량")]
    public string? 선물매수수량
    {
        get; set;
    }
    /// <summary>선물매수금액</summary>
    [DataMember, JsonProperty("선물매수금액")]
    public string? 선물매수금액
    {
        get; set;
    }
    /// <summary>선물매수평균가격</summary>
    [DataMember, JsonProperty("선물매수평균가격")]
    public string? 선물매수평균가격
    {
        get; set;
    }
    /// <summary>선물전매수량</summary>
    [DataMember, JsonProperty("선물전매수량")]
    public string? 선물전매수량
    {
        get; set;
    }
    /// <summary>선물전매금액</summary>
    [DataMember, JsonProperty("선물전매금액")]
    public string? 선물전매금액
    {
        get; set;
    }
    /// <summary>선물환매수량</summary>
    [DataMember, JsonProperty("선물환매수량")]
    public string? 선물환매수량
    {
        get; set;
    }
    /// <summary>선물환매금액</summary>
    [DataMember, JsonProperty("선물환매금액")]
    public string? 선물환매금액
    {
        get; set;
    }
    /// <summary>콜매도수량</summary>
    [DataMember, JsonProperty("콜매도수량")]
    public string? 콜매도수량
    {
        get; set;
    }
    /// <summary>콜매도금액</summary>
    [DataMember, JsonProperty("콜매도금액")]
    public string? 콜매도금액
    {
        get; set;
    }
    /// <summary>콜매도평균가격</summary>
    [DataMember, JsonProperty("콜매도평균가격")]
    public string? 콜매도평균가격
    {
        get; set;
    }
    /// <summary>콜매수수량</summary>
    [DataMember, JsonProperty("콜매수수량")]
    public string? 콜매수수량
    {
        get; set;
    }
    /// <summary>콜매수금액</summary>
    [DataMember, JsonProperty("콜매수금액")]
    public string? 콜매수금액
    {
        get; set;
    }
    /// <summary>콜매수평균가격</summary>
    [DataMember, JsonProperty("콜매수평균가격")]
    public string? 콜매수평균가격
    {
        get; set;
    }
    /// <summary>콜전매수량</summary>
    [DataMember, JsonProperty("콜전매수량")]
    public string? 콜전매수량
    {
        get; set;
    }
    /// <summary>콜전매금액</summary>
    [DataMember, JsonProperty("콜전매금액")]
    public string? 콜전매금액
    {
        get; set;
    }
    /// <summary>콜환매수량</summary>
    [DataMember, JsonProperty("콜환매수량")]
    public string? 콜환매수량
    {
        get; set;
    }
    /// <summary>콜환매금액</summary>
    [DataMember, JsonProperty("콜환매금액")]
    public string? 콜환매금액
    {
        get; set;
    }
    /// <summary>풋매도수량</summary>
    [DataMember, JsonProperty("풋매도수량")]
    public string? 풋매도수량
    {
        get; set;
    }
    /// <summary>풋매도금액</summary>
    [DataMember, JsonProperty("풋매도금액")]
    public string? 풋매도금액
    {
        get; set;
    }
    /// <summary>풋매도평균가격</summary>
    [DataMember, JsonProperty("풋매도평균가격")]
    public string? 풋매도평균가격
    {
        get; set;
    }
    /// <summary>풋매수수량</summary>
    [DataMember, JsonProperty("풋매수수량")]
    public string? 풋매수수량
    {
        get; set;
    }
    /// <summary>풋매수금액</summary>
    [DataMember, JsonProperty("풋매수금액")]
    public string? 풋매수금액
    {
        get; set;
    }
    /// <summary>풋매수평균가격</summary>
    [DataMember, JsonProperty("풋매수평균가격")]
    public string? 풋매수평균가격
    {
        get; set;
    }
    /// <summary>풋전매수량</summary>
    [DataMember, JsonProperty("풋전매수량")]
    public string? 풋전매수량
    {
        get; set;
    }
    /// <summary>풋전매금액</summary>
    [DataMember, JsonProperty("풋전매금액")]
    public string? 풋전매금액
    {
        get; set;
    }
    /// <summary>풋환매수량</summary>
    [DataMember, JsonProperty("풋환매수량")]
    public string? 풋환매수량
    {
        get; set;
    }
    /// <summary>풋환매금액</summary>
    [DataMember, JsonProperty("풋환매금액")]
    public string? 풋환매금액
    {
        get; set;
    }
    /// <summary>선물최종매도수량</summary>
    [DataMember, JsonProperty("선물최종매도수량")]
    public string? 선물최종매도수량
    {
        get; set;
    }
    /// <summary>선물최종매도금액</summary>
    [DataMember, JsonProperty("선물최종매도금액")]
    public string? 선물최종매도금액
    {
        get; set;
    }
    /// <summary>선물최종매도평균가격</summary>
    [DataMember, JsonProperty("선물최종매도평균가격")]
    public string? 선물최종매도평균가격
    {
        get; set;
    }
    /// <summary>선물최종매수수량</summary>
    [DataMember, JsonProperty("선물최종매수수량")]
    public string? 선물최종매수수량
    {
        get; set;
    }
    /// <summary>선물최종매수금액</summary>
    [DataMember, JsonProperty("선물최종매수금액")]
    public string? 선물최종매수금액
    {
        get; set;
    }
    /// <summary>선물최종매수평균가격</summary>
    [DataMember, JsonProperty("선물최종매수평균가격")]
    public string? 선물최종매수평균가격
    {
        get; set;
    }
    /// <summary>콜권리행사수량</summary>
    [DataMember, JsonProperty("콜권리행사수량")]
    public string? 콜권리행사수량
    {
        get; set;
    }
    /// <summary>콜권리행사금액</summary>
    [DataMember, JsonProperty("콜권리행사금액")]
    public string? 콜권리행사금액
    {
        get; set;
    }
    /// <summary>콜권리행사가격</summary>
    [DataMember, JsonProperty("콜권리행사가격")]
    public string? 콜권리행사가격
    {
        get; set;
    }
    /// <summary>풋권리행사수량</summary>
    [DataMember, JsonProperty("풋권리행사수량")]
    public string? 풋권리행사수량
    {
        get; set;
    }
    /// <summary>풋권리행사금액</summary>
    [DataMember, JsonProperty("풋권리행사금액")]
    public string? 풋권리행사금액
    {
        get; set;
    }
    /// <summary>풋권리행사가격</summary>
    [DataMember, JsonProperty("풋권리행사가격")]
    public string? 풋권리행사가격
    {
        get; set;
    }
    /// <summary>콜권리배정수량</summary>
    [DataMember, JsonProperty("콜권리배정수량")]
    public string? 콜권리배정수량
    {
        get; set;
    }
    /// <summary>콜권리배정금액</summary>
    [DataMember, JsonProperty("콜권리배정금액")]
    public string? 콜권리배정금액
    {
        get; set;
    }
    /// <summary>콜권리배정가격</summary>
    [DataMember, JsonProperty("콜권리배정가격")]
    public string? 콜권리배정가격
    {
        get; set;
    }
    /// <summary>풋권리배정수량</summary>
    [DataMember, JsonProperty("풋권리배정수량")]
    public string? 풋권리배정수량
    {
        get; set;
    }
    /// <summary>풋권리배정금액</summary>
    [DataMember, JsonProperty("풋권리배정금액")]
    public string? 풋권리배정금액
    {
        get; set;
    }
    /// <summary>풋권리배정가격</summary>
    [DataMember, JsonProperty("풋권리배정가격")]
    public string? 풋권리배정가격
    {
        get; set;
    }
}