using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>ELW조건검색</summary>
public class MultiOpt30005
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>발행사명</summary>
    [DataMember, JsonProperty("발행사명")]
    public string? IssuerName
    {
        get; set;
    }
    /// <summary>회차</summary>
    [DataMember, JsonProperty("회차")]
    public string? Round
    {
        get; set;
    }
    /// <summary>기초자산명</summary>
    [DataMember, JsonProperty("기초자산명")]
    public string? UnderlyingAssetName
    {
        get; set;
    }
    /// <summary>권리구분</summary>
    [DataMember, JsonProperty("권리구분")]
    public string? ClassificationOfRights
    {
        get; set;
    }
    /// <summary>만기일</summary>
    [DataMember, JsonProperty("만기일")]
    public string? ExpirationDate
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>대비구분</summary>
    [DataMember, JsonProperty("대비구분")]
    public string? MajorComposition
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
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? VolumeOfTransaction
    {
        get; set;
    }
    /// <summary>거래량대비</summary>
    [DataMember, JsonProperty("거래량대비")]
    public string? TransactionVolumeVersus
    {
        get; set;
    }
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금")]
    public string? TransactionPrice
    {
        get; set;
    }
    /// <summary>전일거래량</summary>
    [DataMember, JsonProperty("전일거래량")]
    public string? FullTimeTradingVolume
    {
        get; set;
    }
    /// <summary>매도호가</summary>
    [DataMember, JsonProperty("매도호가")]
    public string? SellingPrice
    {
        get; set;
    }
    /// <summary>매수호가</summary>
    [DataMember, JsonProperty("매수호가")]
    public string? BuyInPrice
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
    /// <summary>손익분기율</summary>
    [DataMember, JsonProperty("손익분기율")]
    public string? BreakEvenRate
    {
        get; set;
    }
    /// <summary>자본지지점</summary>
    [DataMember, JsonProperty("자본지지점")]
    public string? CapitalSupportPoint
    {
        get; set;
    }
    /// <summary>이론가</summary>
    [DataMember, JsonProperty("이론가")]
    public string? Theorist
    {
        get; set;
    }
    /// <summary>내재변동성</summary>
    [DataMember, JsonProperty("내재변동성")]
    public string? IntrinsicVolatility
    {
        get; set;
    }
    /// <summary>델타</summary>
    [DataMember, JsonProperty("델타")]
    public string? Delta
    {
        get; set;
    }
    /// <summary>레버리지</summary>
    [DataMember, JsonProperty("레버리지")]
    public string? Leverage
    {
        get; set;
    }
    /// <summary>행사가격</summary>
    [DataMember, JsonProperty("행사가격")]
    public string? AStrikePrice
    {
        get; set;
    }
    /// <summary>전환비율</summary>
    [DataMember, JsonProperty("전환비율")]
    public string? ConversionRatio
    {
        get; set;
    }
    /// <summary>LP보유비율</summary>
    [DataMember, JsonProperty("LP보유비율")]
    public string? LPHoldingRatio
    {
        get; set;
    }
    /// <summary>손익분기점</summary>
    [DataMember, JsonProperty("손익분기점")]
    public string? BreakEvenPoint
    {
        get; set;
    }
    /// <summary>최종거래일</summary>
    [DataMember, JsonProperty("최종거래일")]
    public string? FinalTransactionDate
    {
        get; set;
    }
    /// <summary>상장일</summary>
    [DataMember, JsonProperty("상장일")]
    public string? ListingDate
    {
        get; set;
    }
    /// <summary>LP초종공급일</summary>
    [DataMember, JsonProperty("LP초종공급일")]
    public string? LPInitialPublicServiceDate
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>잔존일수</summary>
    [DataMember, JsonProperty("잔존일수")]
    public string? RemainingDays
    {
        get; set;
    }
    /// <summary>괴리율</summary>
    [DataMember, JsonProperty("괴리율")]
    public string? DisparateRatio
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
    /// <summary>Xray순간체결량정리매매구분</summary>
    [DataMember, JsonProperty("Xray순간체결량정리매매구분")]
    public string? XRayInstantaneousTighteningVolumeArrangementTradingClassification
    {
        get; set;
    }
    /// <summary>Xray순간체결량증거금100구분</summary>
    [DataMember, JsonProperty("Xray순간체결량증거금100구분")]
    public string? XRayInstantaneousContractAmountMarginClassificationOf100
    {
        get; set;
    }
}