using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>투자자별포지션종합</summary>
public class MultiOpt50039
{
    /// <summary>기간중주가등락</summary>
    [DataMember, JsonProperty("기간중주가등락")]
    public string? 기간중주가등락
    {
        get; set;
    }
    /// <summary>기타법인</summary>
    [DataMember, JsonProperty("기타법인")]
    public string? 기타법인
    {
        get; set;
    }
    /// <summary>연기금등</summary>
    [DataMember, JsonProperty("연기금등")]
    public string? 연기금등
    {
        get; set;
    }
    /// <summary>기타금융</summary>
    [DataMember, JsonProperty("기타금융")]
    public string? 기타금융
    {
        get; set;
    }
    /// <summary>은행</summary>
    [DataMember, JsonProperty("은행")]
    public string? 은행
    {
        get; set;
    }
    /// <summary>투신</summary>
    [DataMember, JsonProperty("투신")]
    public string? 투신
    {
        get; set;
    }
    /// <summary>보험</summary>
    [DataMember, JsonProperty("보험")]
    public string? 보험
    {
        get; set;
    }
    /// <summary>금융투자</summary>
    [DataMember, JsonProperty("금융투자")]
    public string? 금융투자
    {
        get; set;
    }
    /// <summary>외국인</summary>
    [DataMember, JsonProperty("외국인")]
    public string? 외국인
    {
        get; set;
    }
    /// <summary>개인</summary>
    [DataMember, JsonProperty("개인")]
    public string? 개인
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? 누적거래량
    {
        get; set;
    }
    /// <summary>미결제약정전일대비</summary>
    [DataMember, JsonProperty("미결제약정전일대비")]
    public string? 미결제약정전일대비
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
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? 등락율
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
    /// <summary>풋_등락율</summary>
    [DataMember, JsonProperty("풋_등락율")]
    public string? 풋_등락율
    {
        get; set;
    }
    /// <summary>풋_대비기호</summary>
    [DataMember, JsonProperty("풋_대비기호")]
    public string? 풋_대비기호
    {
        get; set;
    }
    /// <summary>풋_전일대비</summary>
    [DataMember, JsonProperty("풋_전일대비")]
    public string? 풋_전일대비
    {
        get; set;
    }
    /// <summary>풋_미결제약정</summary>
    [DataMember, JsonProperty("풋_미결제약정")]
    public string? 풋_미결제약정
    {
        get; set;
    }
    /// <summary>풋_미결제약정전일대비</summary>
    [DataMember, JsonProperty("풋_미결제약정전일대비")]
    public string? 풋_미결제약정전일대비
    {
        get; set;
    }
    /// <summary>풋_누적거래량</summary>
    [DataMember, JsonProperty("풋_누적거래량")]
    public string? 풋_누적거래량
    {
        get; set;
    }
    /// <summary>풋_ATM구분</summary>
    [DataMember, JsonProperty("풋_ATM구분")]
    public string? 풋_ATM구분
    {
        get; set;
    }
    /// <summary>풋_개인</summary>
    [DataMember, JsonProperty("풋_개인")]
    public string? 풋_개인
    {
        get; set;
    }
    /// <summary>풋_외국인</summary>
    [DataMember, JsonProperty("풋_외국인")]
    public string? 풋_외국인
    {
        get; set;
    }
    /// <summary>풋_금융투자</summary>
    [DataMember, JsonProperty("풋_금융투자")]
    public string? 풋_금융투자
    {
        get; set;
    }
    /// <summary>풋_보험</summary>
    [DataMember, JsonProperty("풋_보험")]
    public string? 풋_보험
    {
        get; set;
    }
    /// <summary>풋_투신</summary>
    [DataMember, JsonProperty("풋_투신")]
    public string? 풋_투신
    {
        get; set;
    }
    /// <summary>풋_은행</summary>
    [DataMember, JsonProperty("풋_은행")]
    public string? 풋_은행
    {
        get; set;
    }
    /// <summary>풋_기타금융</summary>
    [DataMember, JsonProperty("풋_기타금융")]
    public string? 풋_기타금융
    {
        get; set;
    }
    /// <summary>풋_연기금등</summary>
    [DataMember, JsonProperty("풋_연기금등")]
    public string? 풋_연기금등
    {
        get; set;
    }
    /// <summary>풋_기타법인</summary>
    [DataMember, JsonProperty("풋_기타법인")]
    public string? 풋_기타법인
    {
        get; set;
    }
    /// <summary>풋_기간중주가등락</summary>
    [DataMember, JsonProperty("풋_기간중주가등락")]
    public string? 풋_기간중주가등락
    {
        get; set;
    }
}