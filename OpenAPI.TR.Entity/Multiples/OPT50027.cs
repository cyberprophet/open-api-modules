using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵잔고</summary>
public class MultiOPT50027
{
    /// <summary>계좌번호</summary>
    [DataMember, JsonProperty("계좌번호")]
    public string? AccountNumber
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? Code
    {
        get; set;
    }
    /// <summary>신용구분</summary>
    [DataMember, JsonProperty("신용구분")]
    public string? CreditClassification
    {
        get; set;
    }
    /// <summary>대출일</summary>
    [DataMember, JsonProperty("대출일")]
    public string? DateOfLoan
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
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? FluctuationRate
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? AccumulatedTradingVolume
    {
        get; set;
    }
    /// <summary>보유수량</summary>
    [DataMember, JsonProperty("보유수량")]
    public string? AmountHeld
    {
        get; set;
    }
    /// <summary>매입단가</summary>
    [DataMember, JsonProperty("매입단가")]
    public string? PurchaseUnitPrice
    {
        get; set;
    }
    /// <summary>총매입가</summary>
    [DataMember, JsonProperty("총매입가")]
    public string? TotalPurchasePrice
    {
        get; set;
    }
    /// <summary>주문가능수량</summary>
    [DataMember, JsonProperty("주문가능수량")]
    public string? OrderableQuantity
    {
        get; set;
    }
    /// <summary>당일매도수량</summary>
    [DataMember, JsonProperty("당일매도수량")]
    public string? SameDaySalesQuantity
    {
        get; set;
    }
    /// <summary>당일매도금액</summary>
    [DataMember, JsonProperty("당일매도금액")]
    public string? SameDaySaleAmount
    {
        get; set;
    }
    /// <summary>당일매수수량</summary>
    [DataMember, JsonProperty("당일매수수량")]
    public string? SameDayPurchaseQuantity
    {
        get; set;
    }
    /// <summary>당일매수금액</summary>
    [DataMember, JsonProperty("당일매수금액")]
    public string? SameDayPurchaseAmount
    {
        get; set;
    }
    /// <summary>당일매매수수료</summary>
    [DataMember, JsonProperty("당일매매수수료")]
    public string? SameDayTradingFee
    {
        get; set;
    }
    /// <summary>당일매매세금</summary>
    [DataMember, JsonProperty("당일매매세금")]
    public string? SameDaySalesTax
    {
        get; set;
    }
    /// <summary>당일HTS매도수수료</summary>
    [DataMember, JsonProperty("당일HTS매도수수료")]
    public string? SameDayHTSSaleFee
    {
        get; set;
    }
    /// <summary>당일HTS매수수수료</summary>
    [DataMember, JsonProperty("당일HTS매수수수료")]
    public string? SameDayHTSPurchaseFee
    {
        get; set;
    }
    /// <summary>D+2매수정산금</summary>
    [DataMember, JsonProperty("D+2매수정산금")]
    public string? D2PurchaseSettlement
    {
        get; set;
    }
    /// <summary>당일매도손익</summary>
    [DataMember, JsonProperty("당일매도손익")]
    public string? ProfitOrLossOnSaleOnTheSameDay
    {
        get; set;
    }
    /// <summary>당일순매수량</summary>
    [DataMember, JsonProperty("당일순매수량")]
    public string? NetPurchaseVolumeOnTheDay
    {
        get; set;
    }
    /// <summary>매매구분</summary>
    [DataMember, JsonProperty("매매구분")]
    public string? TradingClassification
    {
        get; set;
    }
    /// <summary>당일총매도손익</summary>
    [DataMember, JsonProperty("당일총매도손익")]
    public string? ProfitAndLossOnTotalSaleOnTheDay
    {
        get; set;
    }
    /// <summary>예수금</summary>
    [DataMember, JsonProperty("예수금")]
    public string? Deposit
    {
        get; set;
    }
    /// <summary>최우선매도호가</summary>
    [DataMember, JsonProperty("최우선매도호가")]
    public string? HighestSellingPrice
    {
        get; set;
    }
    /// <summary>최우선매수호가</summary>
    [DataMember, JsonProperty("최우선매수호가")]
    public string? HighestAskingPrice
    {
        get; set;
    }
    /// <summary>결제잔고</summary>
    [DataMember, JsonProperty("결제잔고")]
    public string? PaymentBalance
    {
        get; set;
    }
    /// <summary>결제금액</summary>
    [DataMember, JsonProperty("결제금액")]
    public string? PaymentAmount
    {
        get; set;
    }
    /// <summary>전일매도수량</summary>
    [DataMember, JsonProperty("전일매도수량")]
    public string? SalesVolumeOfTheQuantity
    {
        get; set;
    }
    /// <summary>전일매수수량</summary>
    [DataMember, JsonProperty("전일매수수량")]
    public string? DailyPurchaseQuantity
    {
        get; set;
    }
    /// <summary>전일매도금액</summary>
    [DataMember, JsonProperty("전일매도금액")]
    public string? AmountSoldThePreviousDay
    {
        get; set;
    }
    /// <summary>전일매수금액</summary>
    [DataMember, JsonProperty("전일매수금액")]
    public string? AmountPurchasedOnThePreviousDay
    {
        get; set;
    }
    /// <summary>전일순매수량</summary>
    [DataMember, JsonProperty("전일순매수량")]
    public string? NetPurchaseVolumeForThePreviousDay
    {
        get; set;
    }
    /// <summary>손익율</summary>
    [DataMember, JsonProperty("손익율")]
    public string? ProfitLossRatio
    {
        get; set;
    }
    /// <summary>신용금액</summary>
    [DataMember, JsonProperty("신용금액")]
    public string? CreditAmount
    {
        get; set;
    }
    /// <summary>신용이자</summary>
    [DataMember, JsonProperty("신용이자")]
    public string? CreditInterest
    {
        get; set;
    }
    /// <summary>만기일</summary>
    [DataMember, JsonProperty("만기일")]
    public string? ExpirationDate
    {
        get; set;
    }
    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가")]
    public string? StandardPrice
    {
        get; set;
    }
    /// <summary>하한가</summary>
    [DataMember, JsonProperty("하한가")]
    public string? LowerPrice
    {
        get; set;
    }
    /// <summary>상한가</summary>
    [DataMember, JsonProperty("상한가")]
    public string? UpperLimit
    {
        get; set;
    }
    /// <summary>담보대출수량</summary>
    [DataMember, JsonProperty("담보대출수량")]
    public string? AmountOfMortgageLoan
    {
        get; set;
    }
    /// <summary>연누적거래대금</summary>
    [DataMember, JsonProperty("연누적거래대금")]
    public string? CumulativeAnnualTransactionAmount
    {
        get; set;
    }
}