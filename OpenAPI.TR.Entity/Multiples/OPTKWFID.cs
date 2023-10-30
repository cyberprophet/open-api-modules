using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>관심종목정보</summary>
public class MultiOPTKWFID
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드"), Key, StringLength(6)]
    public virtual string? Code
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명"), StringLength(0x40)]
    public virtual string? Name
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가"), StringLength(0x10)]
    public virtual string? Current
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가"), StringLength(0x10)]
    public virtual string? Price
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비"), StringLength(0x10)]
    public virtual string? CompareToPreviousDay
    {
        get; set;
    }
    /// <summary>전일대비기호</summary>
    [DataMember, JsonProperty("전일대비기호"), StringLength(0x10)]
    public virtual string? CompareToPreviousSign
    {
        get; set;
    }
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율"), StringLength(0x10)]
    public virtual string? Rate
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량"), StringLength(0x10)]
    public virtual string? Volume
    {
        get; set;
    }
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금"), StringLength(0x10)]
    public virtual string? TransactionAmount
    {
        get; set;
    }
    /// <summary>체결량</summary>
    [DataMember, JsonProperty("체결량"), StringLength(0x10)]
    public virtual string? ContractAmount
    {
        get; set;
    }
    /// <summary>체결강도</summary>
    [DataMember, JsonProperty("체결강도"), StringLength(0x10)]
    public virtual string? FasteningStrength
    {
        get; set;
    }
    /// <summary>전일거래량대비</summary>
    [DataMember, JsonProperty("전일거래량대비"), StringLength(0x10)]
    public virtual string? CompareToPreviousVolume
    {
        get; set;
    }
    /// <summary>매도호가</summary>
    [DataMember, JsonProperty("매도호가"), StringLength(0x10)]
    public virtual string? Offer
    {
        get; set;
    }
    /// <summary>매수호가</summary>
    [DataMember, JsonProperty("매수호가"), StringLength(0x10)]
    public virtual string? Bid
    {
        get; set;
    }
    /// <summary>매도1차호가</summary>
    [DataMember, JsonProperty("매도1차호가"), StringLength(0x10)]
    public virtual string? OfferAlpha
    {
        get; set;
    }
    /// <summary>매도2차호가</summary>
    [DataMember, JsonProperty("매도2차호가"), StringLength(0x10)]
    public virtual string? OfferBeta
    {
        get; set;
    }
    /// <summary>매도3차호가</summary>
    [DataMember, JsonProperty("매도3차호가"), StringLength(0x10)]
    public virtual string? OfferGamma
    {
        get; set;
    }
    /// <summary>매도4차호가</summary>
    [DataMember, JsonProperty("매도4차호가"), StringLength(0x10)]
    public virtual string? OfferDelta
    {
        get; set;
    }
    /// <summary>매도5차호가</summary>
    [DataMember, JsonProperty("매도5차호가"), StringLength(0x10)]
    public virtual string? OfferEpsilon
    {
        get; set;
    }
    /// <summary>매수1차호가</summary>
    [DataMember, JsonProperty("매수1차호가"), StringLength(0x10)]
    public virtual string? BidAlpha
    {
        get; set;
    }
    /// <summary>매수2차호가</summary>
    [DataMember, JsonProperty("매수2차호가"), StringLength(0x10)]
    public virtual string? BidBeta
    {
        get; set;
    }
    /// <summary>매수3차호가</summary>
    [DataMember, JsonProperty("매수3차호가"), StringLength(0x10)]
    public virtual string? BidGamma
    {
        get; set;
    }
    /// <summary>매수4차호가</summary>
    [DataMember, JsonProperty("매수4차호가"), StringLength(0x10)]
    public virtual string? BidDelta
    {
        get; set;
    }
    /// <summary>매수5차호가</summary>
    [DataMember, JsonProperty("매수5차호가"), StringLength(0x10)]
    public virtual string? BidEpsilon
    {
        get; set;
    }
    /// <summary>상한가</summary>
    [DataMember, JsonProperty("상한가"), StringLength(0x10)]
    public virtual string? UpperLimit
    {
        get; set;
    }
    /// <summary>하한가</summary>
    [DataMember, JsonProperty("하한가"), StringLength(0x10)]
    public virtual string? LowerLimit
    {
        get; set;
    }
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가"), StringLength(0x10)]
    public virtual string? StartingPrice
    {
        get; set;
    }
    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가"), StringLength(0x10)]
    public virtual string? HighPrice
    {
        get; set;
    }
    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가"), StringLength(0x10)]
    public virtual string? LowPrice
    {
        get; set;
    }
    /// <summary>종가</summary>
    [DataMember, JsonProperty("종가"), StringLength(0x10)]
    public virtual string? ClosingPrice
    {
        get; set;
    }
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간"), StringLength(0x10)]
    public virtual string? FasteningTime
    {
        get; set;
    }
    /// <summary>예상체결가</summary>
    [DataMember, JsonProperty("예상체결가"), StringLength(0x10)]
    public virtual string? ExpectedPrice
    {
        get; set;
    }
    /// <summary>예상체결량</summary>
    [DataMember, JsonProperty("예상체결량"), StringLength(0x10)]
    public virtual string? EstimatedContractVolume
    {
        get; set;
    }
    /// <summary>자본금</summary>
    [DataMember, JsonProperty("자본금"), StringLength(0x10)]
    public virtual string? Capital
    {
        get; set;
    }
    /// <summary>액면가</summary>
    [DataMember, JsonProperty("액면가"), StringLength(0x10)]
    public virtual string? FaceValue
    {
        get; set;
    }
    /// <summary>시가총액</summary>
    [DataMember, JsonProperty("시가총액"), StringLength(0x10)]
    public virtual string? MarketCap
    {
        get; set;
    }
    /// <summary>주식수</summary>
    [DataMember, JsonProperty("주식수"), StringLength(0x10)]
    public virtual string? NumberOfListedStocks
    {
        get; set;
    }
    /// <summary>호가시간</summary>
    [DataMember, JsonProperty("호가시간"), StringLength(0x10)]
    public virtual string? QuoteTime
    {
        get; set;
    }
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자"), StringLength(0x10)]
    public virtual string? Date
    {
        get; set;
    }
    /// <summary>우선매도잔량</summary>
    [DataMember, JsonProperty("우선매도잔량"), StringLength(0x10)]
    public virtual string? PreferredOfferRemaining
    {
        get; set;
    }
    /// <summary>우선매수잔량</summary>
    [DataMember, JsonProperty("우선매수잔량"), StringLength(0x10)]
    public virtual string? PreferredBidRemaining
    {
        get; set;
    }
    /// <summary>우선매도건수</summary>
    [DataMember, JsonProperty("우선매도건수"), StringLength(0x10)]
    public virtual string? NumberOfPreferentialOffer
    {
        get; set;
    }
    /// <summary>우선매수건수</summary>
    [DataMember, JsonProperty("우선매수건수"), StringLength(0x10)]
    public virtual string? NumberOfPreferentialBid
    {
        get; set;
    }
    /// <summary>총매도잔량</summary>
    [DataMember, JsonProperty("총매도잔량"), StringLength(0x10)]
    public virtual string? TotalOfferRemaining
    {
        get; set;
    }
    /// <summary>총매수잔량</summary>
    [DataMember, JsonProperty("총매수잔량"), StringLength(0x10)]
    public virtual string? TotalBidRemaining
    {
        get; set;
    }
    /// <summary>총매도건수</summary>
    [DataMember, JsonProperty("총매도건수"), StringLength(0x10)]
    public virtual string? NumberOfTotalOffer
    {
        get; set;
    }
    /// <summary>총매수건수</summary>
    [DataMember, JsonProperty("총매수건수"), StringLength(0x10)]
    public virtual string? NumberOfTotalBid
    {
        get; set;
    }
    /// <summary>패리티</summary>
    [DataMember, JsonProperty("패리티"), StringLength(0x10)]
    public virtual string? Parity
    {
        get; set;
    }
    /// <summary>기어링</summary>
    [DataMember, JsonProperty("기어링"), StringLength(0x10)]
    public virtual string? Gearing
    {
        get; set;
    }
    /// <summary>손익분기</summary>
    [DataMember, JsonProperty("손익분기"), StringLength(0x10)]
    public virtual string? BreakEven
    {
        get; set;
    }
    /// <summary>자본지지</summary>
    [DataMember, JsonProperty("자본지지"), StringLength(0x10)]
    public virtual string? CapitalSupport
    {
        get; set;
    }
    /// <summary>ELW행사가</summary>
    [DataMember, JsonProperty("ELW행사가"), StringLength(0x10)]
    public virtual string? ELWEventPrice
    {
        get; set;
    }
    /// <summary>전환비율</summary>
    [DataMember, JsonProperty("전환비율"), StringLength(0x10)]
    public virtual string? ConversionRate
    {
        get; set;
    }
    /// <summary>ELW만기일</summary>
    [DataMember, JsonProperty("ELW만기일"), StringLength(0x10)]
    public virtual string? ELWDueDate
    {
        get; set;
    }
    /// <summary>미결제약정</summary>
    [DataMember, JsonProperty("미결제약정"), StringLength(0x10)]
    public virtual string? OpenInterest
    {
        get; set;
    }
    /// <summary>미결제전일대비</summary>
    [DataMember, JsonProperty("미결제전일대비"), StringLength(0x10)]
    public virtual string? ComparePreviousOutstanding
    {
        get; set;
    }
    /// <summary>이론가</summary>
    [DataMember, JsonProperty("이론가"), StringLength(0x10)]
    public virtual string? TheoreticalPrice
    {
        get; set;
    }
    /// <summary>내재변동성</summary>
    [DataMember, JsonProperty("내재변동성"), StringLength(0x10)]
    public virtual string? ImpliedVolatility
    {
        get; set;
    }
    /// <summary>델타</summary>
    [DataMember, JsonProperty("델타"), StringLength(0x10)]
    public virtual string? Delta
    {
        get; set;
    }
    /// <summary>감마</summary>
    [DataMember, JsonProperty("감마"), StringLength(0x10)]
    public virtual string? Gamma
    {
        get; set;
    }
    /// <summary>쎄타</summary>
    [DataMember, JsonProperty("쎄타"), StringLength(0x10)]
    public virtual string? Theta
    {
        get; set;
    }
    /// <summary>베가</summary>
    [DataMember, JsonProperty("베가"), StringLength(0x10)]
    public virtual string? Vega
    {
        get; set;
    }
    /// <summary>로</summary>
    [DataMember, JsonProperty("로"), StringLength(0x10)]
    public virtual string? Rho
    {
        get; set;
    }
}