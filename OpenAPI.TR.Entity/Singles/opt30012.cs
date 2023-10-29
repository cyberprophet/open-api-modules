using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW종목상세정보</summary>
public class SingleOpt30012
{
    /// <summary>자산코드</summary>
    [DataMember, JsonProperty("자산코드")]
    public string? AssetCode
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>전일대비기호</summary>
    [DataMember, JsonProperty("전일대비기호")]
    public string? SignsComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? FluctuationRate
    {
        get; set;
    }
    /// <summary>LP회원사명</summary>
    [DataMember, JsonProperty("LP회원사명")]
    public string? LPMemberCompanyName
    {
        get; set;
    }
    /// <summary>LP회원사명1</summary>
    [DataMember, JsonProperty("LP회원사명1")]
    public string? LPMemberCompanyName1
    {
        get; set;
    }
    /// <summary>LP회원사명2</summary>
    [DataMember, JsonProperty("LP회원사명2")]
    public string? LPMemberCompanyName2
    {
        get; set;
    }
    /// <summary>ELW권리내용</summary>
    [DataMember, JsonProperty("ELW권리내용")]
    public string? ELWRightsContent
    {
        get; set;
    }
    /// <summary>ELW만기평가가격</summary>
    [DataMember, JsonProperty("ELW만기평가가격")]
    public string? ELWExpirationPrice
    {
        get; set;
    }
    /// <summary>ELW이론가</summary>
    [DataMember, JsonProperty("ELW이론가")]
    public string? ELWTheorist
    {
        get; set;
    }
    /// <summary>괴리율</summary>
    [DataMember, JsonProperty("괴리율")]
    public string? DisparateRatio
    {
        get; set;
    }
    /// <summary>ELW내재변동성</summary>
    [DataMember, JsonProperty("ELW내재변동성")]
    public string? ELWEmbeddedVolatility
    {
        get; set;
    }
    /// <summary>예상권리가</summary>
    [DataMember, JsonProperty("예상권리가")]
    public string? EstimatedRightPriceOf
    {
        get; set;
    }
    /// <summary>ELW손익분기율</summary>
    [DataMember, JsonProperty("ELW손익분기율")]
    public string? ELWBreakEvenRate
    {
        get; set;
    }
    /// <summary>ELW행사가</summary>
    [DataMember, JsonProperty("ELW행사가")]
    public string? ELWEventIs
    {
        get; set;
    }
    /// <summary>ELW전환비율</summary>
    [DataMember, JsonProperty("ELW전환비율")]
    public string? ELWConversionRatio
    {
        get; set;
    }
    /// <summary>ELW보상율</summary>
    [DataMember, JsonProperty("ELW보상율")]
    public string? ELWCompensationRate
    {
        get; set;
    }
    /// <summary>ELW가격상승참여율</summary>
    [DataMember, JsonProperty("ELW가격상승참여율")]
    public string? ELWPriceIncreaseParticipationRate
    {
        get; set;
    }
    /// <summary>ELW권리유형</summary>
    [DataMember, JsonProperty("ELW권리유형")]
    public string? ELWRightsType
    {
        get; set;
    }
    /// <summary>ELW잔존일수</summary>
    [DataMember, JsonProperty("ELW잔존일수")]
    public string? ELWRemainingDays
    {
        get; set;
    }
    /// <summary>주식수</summary>
    [DataMember, JsonProperty("주식수")]
    public string? NumberOfShares
    {
        get; set;
    }
    /// <summary>ELW LP주문가능</summary>
    [DataMember, JsonProperty("ELW LP주문가능")]
    public string? ELWLPCanBeOrdered
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
    /// <summary>ELW스프레드</summary>
    [DataMember, JsonProperty("ELW스프레드")]
    public string? ELWSpread
    {
        get; set;
    }
    /// <summary>ELW패리티</summary>
    [DataMember, JsonProperty("ELW패리티")]
    public string? ELWParity
    {
        get; set;
    }
    /// <summary>ELW기어링</summary>
    [DataMember, JsonProperty("ELW기어링")]
    public string? ELWGearing
    {
        get; set;
    }
    /// <summary>ELW상장일</summary>
    [DataMember, JsonProperty("ELW상장일")]
    public string? ELWListingDate
    {
        get; set;
    }
    /// <summary>ELW최종거래일</summary>
    [DataMember, JsonProperty("ELW최종거래일")]
    public string? ELWFinalTransactionDate
    {
        get; set;
    }
    /// <summary>만기일</summary>
    [DataMember, JsonProperty("만기일")]
    public string? ExpirationDate
    {
        get; set;
    }
    /// <summary>행사일</summary>
    [DataMember, JsonProperty("행사일")]
    public string? EventDay
    {
        get; set;
    }
    /// <summary>LP공급종료일</summary>
    [DataMember, JsonProperty("LP공급종료일")]
    public string? LPSupplyEndDate
    {
        get; set;
    }
    /// <summary>ELW지급일</summary>
    [DataMember, JsonProperty("ELW지급일")]
    public string? ELWPaymentDate
    {
        get; set;
    }
    /// <summary>ELW투자지표산출</summary>
    [DataMember, JsonProperty("ELW투자지표산출")]
    public string? CalculationOfELWInvestmentIndicators
    {
        get; set;
    }
    /// <summary>ELW지급대리인</summary>
    [DataMember, JsonProperty("ELW지급대리인")]
    public string? ELWPaymentAgent
    {
        get; set;
    }
    /// <summary>ELW결재방법</summary>
    [DataMember, JsonProperty("ELW결재방법")]
    public string? ELWBindingMethod
    {
        get; set;
    }
    /// <summary>ELW권리행사방식</summary>
    [DataMember, JsonProperty("ELW권리행사방식")]
    public string? ELWMethodOfExerciseOfRights
    {
        get; set;
    }
    /// <summary>ELW발행기관</summary>
    [DataMember, JsonProperty("ELW발행기관")]
    public string? ELWIssuingAuthority
    {
        get; set;
    }
    /// <summary>확정지급액</summary>
    [DataMember, JsonProperty("확정지급액")]
    public string? FixedPaymentAmount
    {
        get; set;
    }
    /// <summary>KO베리어</summary>
    [DataMember, JsonProperty("KO베리어")]
    public string? KOBarier
    {
        get; set;
    }
    /// <summary>IV</summary>
    [DataMember, JsonProperty(nameof(IV))]
    public string? IV
    {
        get; set;
    }
    /// <summary>종기종료ELW발생</summary>
    [DataMember, JsonProperty("종기종료ELW발생")]
    public string? EndOfTerminationELWOccurrence
    {
        get; set;
    }
    /// <summary>기초자산1</summary>
    [DataMember, JsonProperty("기초자산1")]
    public string? UnderlyingAsset1
    {
        get; set;
    }
    /// <summary>기초자산구성비율1</summary>
    [DataMember, JsonProperty("기초자산구성비율1")]
    public string? UnderlyingAssetCompositionRatio1
    {
        get; set;
    }
    /// <summary>기초자산2</summary>
    [DataMember, JsonProperty("기초자산2")]
    public string? UnderlyingAsset2
    {
        get; set;
    }
    /// <summary>기초자산구성비율2</summary>
    [DataMember, JsonProperty("기초자산구성비율2")]
    public string? UnderlyingAssetCompositionRatio2
    {
        get; set;
    }
    /// <summary>기초자산3</summary>
    [DataMember, JsonProperty("기초자산3")]
    public string? UnderlyingAsset3
    {
        get; set;
    }
    /// <summary>기초자산구성비율3</summary>
    [DataMember, JsonProperty("기초자산구성비율3")]
    public string? UnderlyingAssetCompositionRatio3
    {
        get; set;
    }
    /// <summary>기초자산4</summary>
    [DataMember, JsonProperty("기초자산4")]
    public string? UnderlyingAsset4
    {
        get; set;
    }
    /// <summary>기초자산구성비율4</summary>
    [DataMember, JsonProperty("기초자산구성비율4")]
    public string? UnderlyingAssetCompositionRatio4
    {
        get; set;
    }
    /// <summary>기초자산5</summary>
    [DataMember, JsonProperty("기초자산5")]
    public string? UnderlyingAsset5
    {
        get; set;
    }
    /// <summary>기초자산구성비율5</summary>
    [DataMember, JsonProperty("기초자산구성비율5")]
    public string? UnderlyingAssetCompositionRatio5
    {
        get; set;
    }
    /// <summary>평가시작일자</summary>
    [DataMember, JsonProperty("평가시작일자")]
    public string? EvaluationStartDate
    {
        get; set;
    }
    /// <summary>평가종료일자</summary>
    [DataMember, JsonProperty("평가종료일자")]
    public string? EvaluationEndDate
    {
        get; set;
    }
    /// <summary>평가시작시간</summary>
    [DataMember, JsonProperty("평가시작시간")]
    public string? EvaluationStartTime
    {
        get; set;
    }
    /// <summary>평가종료시간</summary>
    [DataMember, JsonProperty("평가종료시간")]
    public string? EvaluationEndTime
    {
        get; set;
    }
    /// <summary>평가가격</summary>
    [DataMember, JsonProperty("평가가격")]
    public string? ValuationPrice
    {
        get; set;
    }
    /// <summary>평가완료여부</summary>
    [DataMember, JsonProperty("평가완료여부")]
    public string? EvaluationCompletedStatus
    {
        get; set;
    }
    /// <summary>전체최고가</summary>
    [DataMember, JsonProperty("전체최고가")]
    public string? HighestOverallPrice
    {
        get; set;
    }
    /// <summary>전체최저가</summary>
    [DataMember, JsonProperty("전체최저가")]
    public string? LowestOverallPrice
    {
        get; set;
    }
    /// <summary>직후최고가</summary>
    [DataMember, JsonProperty("직후최고가")]
    public string? HighestPriceRightAfter
    {
        get; set;
    }
    /// <summary>직후최저가</summary>
    [DataMember, JsonProperty("직후최저가")]
    public string? LowestPriceImmediatelyAfter
    {
        get; set;
    }
    /// <summary>후반장최고가</summary>
    [DataMember, JsonProperty("후반장최고가")]
    public string? HighestPriceInTheSecondHalf
    {
        get; set;
    }
    /// <summary>후반장최저가</summary>
    [DataMember, JsonProperty("후반장최저가")]
    public string? LowestPriceInTheSecondHalfOfTheYear
    {
        get; set;
    }
}