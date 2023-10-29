using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>관심종목정보</summary>
public class MultiOPTKWFID
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? Name
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public string? StandardPrice
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>전일대비기호</summary>
    [DataMember, JsonProperty("전일대비기호")]
    public string? SignsComparedToThePreviousDay
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
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금")]
    public string? TransactionPrice
    {
        get; set;
    }
    /// <summary>체결량</summary>
    [DataMember, JsonProperty("체결량")]
    public string? AmountOfEngagement
    {
        get; set;
    }
    /// <summary>체결강도</summary>
    [DataMember, JsonProperty("체결강도")]
    public string? FasteningStrength
    {
        get; set;
    }
    /// <summary>전일거래량대비</summary>
    [DataMember, JsonProperty("전일거래량대비")]
    public string? ComparedToThePreviousDayTradingVolume
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
    /// <summary>매도1차호가</summary>
    [DataMember, JsonProperty("매도1차호가")]
    public string? FirstSellingPrice
    {
        get; set;
    }
    /// <summary>매도2차호가</summary>
    [DataMember, JsonProperty("매도2차호가")]
    public string? SecondarySellingPrice
    {
        get; set;
    }
    /// <summary>매도3차호가</summary>
    [DataMember, JsonProperty("매도3차호가")]
    public string? ThirdIssueOfSellingPrice
    {
        get; set;
    }
    /// <summary>매도4차호가</summary>
    [DataMember, JsonProperty("매도4차호가")]
    public string? FourthIssueOfSellingPrice
    {
        get; set;
    }
    /// <summary>매도5차호가</summary>
    [DataMember, JsonProperty("매도5차호가")]
    public string? The5thIssueOfSellingPrice
    {
        get; set;
    }
    /// <summary>매수1차호가</summary>
    [DataMember, JsonProperty("매수1차호가")]
    public string? TheFirstPurchasePrice
    {
        get; set;
    }
    /// <summary>매수2차호가</summary>
    [DataMember, JsonProperty("매수2차호가")]
    public string? TheSecondIssueOfBuying
    {
        get; set;
    }
    /// <summary>매수3차호가</summary>
    [DataMember, JsonProperty("매수3차호가")]
    public string? TheThirdIssueOfBuying
    {
        get; set;
    }
    /// <summary>매수4차호가</summary>
    [DataMember, JsonProperty("매수4차호가")]
    public string? The4thIssueOf
    {
        get; set;
    }
    /// <summary>매수5차호가</summary>
    [DataMember, JsonProperty("매수5차호가")]
    public string? The5thIssueOfPurchase
    {
        get; set;
    }
    /// <summary>상한가</summary>
    [DataMember, JsonProperty("상한가")]
    public string? UpperLimit
    {
        get; set;
    }
    /// <summary>하한가</summary>
    [DataMember, JsonProperty("하한가")]
    public string? LowerPrice
    {
        get; set;
    }
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가")]
    public string? StartPrice
    {
        get; set;
    }
    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가")]
    public string? HighPrice
    {
        get; set;
    }
    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가")]
    public string? LowPrice
    {
        get; set;
    }
    /// <summary>종가</summary>
    [DataMember, JsonProperty("종가")]
    public string? ClosingPrice
    {
        get; set;
    }
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간")]
    public string? ConcludingTime
    {
        get; set;
    }
    /// <summary>예상체결가</summary>
    [DataMember, JsonProperty("예상체결가")]
    public string? EstimatedClosingPrice
    {
        get; set;
    }
    /// <summary>예상체결량</summary>
    [DataMember, JsonProperty("예상체결량")]
    public string? EstimatedAmountOfEngagement
    {
        get; set;
    }
    /// <summary>자본금</summary>
    [DataMember, JsonProperty("자본금")]
    public string? CapitalStock
    {
        get; set;
    }
    /// <summary>액면가</summary>
    [DataMember, JsonProperty("액면가")]
    public string? FaceValue
    {
        get; set;
    }
    /// <summary>시가총액</summary>
    [DataMember, JsonProperty("시가총액")]
    public string? MarketCapitalization
    {
        get; set;
    }
    /// <summary>주식수</summary>
    [DataMember, JsonProperty("주식수")]
    public string? NumberOfShares
    {
        get; set;
    }
    /// <summary>호가시간</summary>
    [DataMember, JsonProperty("호가시간")]
    public string? AskingTime
    {
        get; set;
    }
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>우선매도잔량</summary>
    [DataMember, JsonProperty("우선매도잔량")]
    public string? PreferredSellingRemainingAmount
    {
        get; set;
    }
    /// <summary>우선매수잔량</summary>
    [DataMember, JsonProperty("우선매수잔량")]
    public string? PreferredPurchaseRemainingAmount
    {
        get; set;
    }
    /// <summary>우선매도건수</summary>
    [DataMember, JsonProperty("우선매도건수")]
    public string? NumberOfPreferentialSales
    {
        get; set;
    }
    /// <summary>우선매수건수</summary>
    [DataMember, JsonProperty("우선매수건수")]
    public string? NumberOfPreferentialPurchases
    {
        get; set;
    }
    /// <summary>총매도잔량</summary>
    [DataMember, JsonProperty("총매도잔량")]
    public string? TotalRemainingSales
    {
        get; set;
    }
    /// <summary>총매수잔량</summary>
    [DataMember, JsonProperty("총매수잔량")]
    public string? TotalPurchaseBacklog
    {
        get; set;
    }
    /// <summary>총매도건수</summary>
    [DataMember, JsonProperty("총매도건수")]
    public string? TotalNumberOfSales
    {
        get; set;
    }
    /// <summary>총매수건수</summary>
    [DataMember, JsonProperty("총매수건수")]
    public string? TotalNumberOfPurchases
    {
        get; set;
    }
    /// <summary>패리티</summary>
    [DataMember, JsonProperty("패리티")]
    public string? Parity
    {
        get; set;
    }
    /// <summary>기어링</summary>
    [DataMember, JsonProperty("기어링")]
    public string? Gearing
    {
        get; set;
    }
    /// <summary>손익분기</summary>
    [DataMember, JsonProperty("손익분기")]
    public string? BreakEven
    {
        get; set;
    }
    /// <summary>자본지지</summary>
    [DataMember, JsonProperty("자본지지")]
    public string? CapitalSupport
    {
        get; set;
    }
    /// <summary>ELW행사가</summary>
    [DataMember, JsonProperty("ELW행사가")]
    public string? ELWEventIs
    {
        get; set;
    }
    /// <summary>전환비율</summary>
    [DataMember, JsonProperty("전환비율")]
    public string? ConversionRatio
    {
        get; set;
    }
    /// <summary>ELW만기일</summary>
    [DataMember, JsonProperty("ELW만기일")]
    public string? ELWExpirationDate
    {
        get; set;
    }
    /// <summary>미결제약정</summary>
    [DataMember, JsonProperty("미결제약정")]
    public string? OpenInterest
    {
        get; set;
    }
    /// <summary>미결제전일대비</summary>
    [DataMember, JsonProperty("미결제전일대비")]
    public string? ComparedToThePreviousDayOutstanding
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
    /// <summary>감마</summary>
    [DataMember, JsonProperty("감마")]
    public string? Gamma
    {
        get; set;
    }
    /// <summary>쎄타</summary>
    [DataMember, JsonProperty("쎄타")]
    public string? Seta
    {
        get; set;
    }
    /// <summary>베가</summary>
    [DataMember, JsonProperty("베가")]
    public string? Vega
    {
        get; set;
    }
    /// <summary>로</summary>
    [DataMember, JsonProperty("로")]
    public string? Rho
    {
        get; set;
    }
}