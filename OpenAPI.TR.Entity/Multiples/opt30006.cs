using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW종목상세2</summary>
public class MultiOpt30006
{
    /// <summary>이론가</summary>
    [DataMember, JsonProperty("이론가")]
    public string? ATheorist
    {
        get; set;
    }
    /// <summary>괴리율</summary>
    [DataMember, JsonProperty("괴리율")]
    public string? DisparateRatio
    {
        get; set;
    }
    /// <summary>내재변동성</summary>
    [DataMember, JsonProperty("내재변동성")]
    public string? IntrinsicVolatility
    {
        get; set;
    }
    /// <summary>손익분기율</summary>
    [DataMember, JsonProperty("손익분기율")]
    public string? BreakEvenRate
    {
        get; set;
    }
    /// <summary>행사가격</summary>
    [DataMember, JsonProperty("행사가격")]
    public string? StrikePrice
    {
        get; set;
    }
    /// <summary>전환비율</summary>
    [DataMember, JsonProperty("전환비율")]
    public string? ConversionRatio
    {
        get; set;
    }
    /// <summary>보상율</summary>
    [DataMember, JsonProperty("보상율")]
    public string? CompensationRate
    {
        get; set;
    }
    /// <summary>가격상승참여율</summary>
    [DataMember, JsonProperty("가격상승참여율")]
    public string? PriceIncreaseParticipationRate
    {
        get; set;
    }
    /// <summary>권리유형</summary>
    [DataMember, JsonProperty("권리유형")]
    public string? TypeOfRights
    {
        get; set;
    }
    /// <summary>잔존일수</summary>
    [DataMember, JsonProperty("잔존일수")]
    public string? RemainingDays
    {
        get; set;
    }
    /// <summary>주식수</summary>
    [DataMember, JsonProperty("주식수")]
    public string? NumberOfShares
    {
        get; set;
    }
    /// <summary>LP보유비율</summary>
    [DataMember, JsonProperty("LP보유비율")]
    public string? LPHoldingRatio
    {
        get; set;
    }
    /// <summary>LP보유수량</summary>
    [DataMember, JsonProperty("LP보유수량")]
    public string? LPHoldingQuantity
    {
        get; set;
    }
    /// <summary>스프레드</summary>
    [DataMember, JsonProperty("스프레드")]
    public string? Spread
    {
        get; set;
    }
    /// <summary>패리티</summary>
    [DataMember, JsonProperty("패리티")]
    public string? Parity
    {
        get; set;
    }
    /// <summary>기어링비율</summary>
    [DataMember, JsonProperty("기어링비율")]
    public string? GearingRatio
    {
        get; set;
    }
    /// <summary>상장일</summary>
    [DataMember, JsonProperty("상장일")]
    public string? ListingDate
    {
        get; set;
    }
    /// <summary>최종거래일</summary>
    [DataMember, JsonProperty("최종거래일")]
    public string? FinalTransactionDate
    {
        get; set;
    }
    /// <summary>신주인수권행사종료일</summary>
    [DataMember, JsonProperty("신주인수권행사종료일")]
    public string? EndDateOfExerciseOfPreemptiveRight
    {
        get; set;
    }
    /// <summary>신주인수권행사게시일</summary>
    [DataMember, JsonProperty("신주인수권행사게시일")]
    public string? DateOfPostingOfExerciseOfNewStockUnderwritingRights
    {
        get; set;
    }
    /// <summary>LP최종공급일</summary>
    [DataMember, JsonProperty("LP최종공급일")]
    public string? LPFinalSupplyDate
    {
        get; set;
    }
    /// <summary>지급일</summary>
    [DataMember, JsonProperty("지급일")]
    public string? PaymentDate
    {
        get; set;
    }
    /// <summary>투자지표산출여부</summary>
    [DataMember, JsonProperty("투자지표산출여부")]
    public string? InvestmentIndexCalculationStatus
    {
        get; set;
    }
    /// <summary>지급대리인</summary>
    [DataMember, JsonProperty("지급대리인")]
    public string? PaymentAgent
    {
        get; set;
    }
    /// <summary>결제방법</summary>
    [DataMember, JsonProperty("결제방법")]
    public string? PaymentMethod
    {
        get; set;
    }
    /// <summary>권리행사방식</summary>
    [DataMember, JsonProperty("권리행사방식")]
    public string? MethodOfExerciseOfRights
    {
        get; set;
    }
    /// <summary>한글발행기관명</summary>
    [DataMember, JsonProperty("한글발행기관명")]
    public string? NameOfIssuingInstitutionInKorean
    {
        get; set;
    }
    /// <summary>확정지급금액</summary>
    [DataMember, JsonProperty("확정지급금액")]
    public string? FixedPaymentAmount
    {
        get; set;
    }
    /// <summary>KO베리어</summary>
    [DataMember, JsonProperty("KO베리어")]
    public string? KOBARIER
    {
        get; set;
    }
    /// <summary>XRay순간체결량증거금100%구분</summary>
    [DataMember, JsonProperty("XRay순간체결량증거금100%구분")]
    public string? ClassificationOfXRayInstantaneousContractAmountMargin
    {
        get; set;
    }
}