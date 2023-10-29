using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>차익잔고현황</summary>
public class MultiOpt90011
{
    /// <summary>종목코드1</summary>
    [DataMember, JsonProperty("종목코드1")]
    public string? Code1
    {
        get; set;
    }
    /// <summary>차익매도위탁금액</summary>
    [DataMember, JsonProperty("차익매도위탁금액")]
    public string? ConsignmentAmountForSellTaking
    {
        get; set;
    }
    /// <summary>차익매수위탁금액</summary>
    [DataMember, JsonProperty("차익매수위탁금액")]
    public string? ConsignmentAmountForBuyTaking
    {
        get; set;
    }
    /// <summary>차익매도위탁선물금액</summary>
    [DataMember, JsonProperty("차익매도위탁선물금액")]
    public string? AmountOfConsignmentFuturesForSellTaking
    {
        get; set;
    }
    /// <summary>차익매수위탁선물금액</summary>
    [DataMember, JsonProperty("차익매수위탁선물금액")]
    public string? AmountOfConsignmentFuturesForBuyTaking
    {
        get; set;
    }
    /// <summary>차익매도위탁CALL금액</summary>
    [DataMember, JsonProperty("차익매도위탁CALL금액")]
    public string? ProfitTakingConsignmentCALLAmount
    {
        get; set;
    }
    /// <summary>차익매수위탁CALL금액</summary>
    [DataMember, JsonProperty("차익매수위탁CALL금액")]
    public string? ArbitragePurchaseConsignmentCALLAmount
    {
        get; set;
    }
    /// <summary>차익매도위탁PUT금액</summary>
    [DataMember, JsonProperty("차익매도위탁PUT금액")]
    public string? SellTakingConsignmentPUTAmount
    {
        get; set;
    }
    /// <summary>차익매수위탁PUT금액</summary>
    [DataMember, JsonProperty("차익매수위탁PUT금액")]
    public string? BuyTakingConsignmentPUTAmount
    {
        get; set;
    }
    /// <summary>차익매도자기금액</summary>
    [DataMember, JsonProperty("차익매도자기금액")]
    public string? ProfitSellerFundAmount
    {
        get; set;
    }
    /// <summary>차익매수자기금액</summary>
    [DataMember, JsonProperty("차익매수자기금액")]
    public string? AmountOfProfitsBuyerFund
    {
        get; set;
    }
    /// <summary>차익매도자기선물금액</summary>
    [DataMember, JsonProperty("차익매도자기선물금액")]
    public string? ProfitSellingSelfFuturesAmount
    {
        get; set;
    }
    /// <summary>차익매수자기선물금액</summary>
    [DataMember, JsonProperty("차익매수자기선물금액")]
    public string? AmountOfSelfDebtOnProfitTaking
    {
        get; set;
    }
    /// <summary>차익매도자기CALL금액</summary>
    [DataMember, JsonProperty("차익매도자기CALL금액")]
    public string? SellTakingSelfCALLAmount
    {
        get; set;
    }
    /// <summary>차익매수자기CALL금액</summary>
    [DataMember, JsonProperty("차익매수자기CALL금액")]
    public string? BuyTakingSelfCALLAmount
    {
        get; set;
    }
    /// <summary>차익매도자기PUT금액</summary>
    [DataMember, JsonProperty("차익매도자기PUT금액")]
    public string? ProfitSellingSelfPUTAmount
    {
        get; set;
    }
    /// <summary>차익매수자기PUT금액</summary>
    [DataMember, JsonProperty("차익매수자기PUT금액")]
    public string? ProfitTakingSelfPUTAmount
    {
        get; set;
    }
    /// <summary>차익매도금액</summary>
    [DataMember, JsonProperty("차익매도금액")]
    public string? ProfitSellingAmount
    {
        get; set;
    }
    /// <summary>차익매수금액</summary>
    [DataMember, JsonProperty("차익매수금액")]
    public string? ProfitTakingAmount
    {
        get; set;
    }
    /// <summary>차익매도선물금액</summary>
    [DataMember, JsonProperty("차익매도선물금액")]
    public string? ProfitSellingFuturesAmount
    {
        get; set;
    }
    /// <summary>차익매수선물금액</summary>
    [DataMember, JsonProperty("차익매수선물금액")]
    public string? AmountOfArbitragePurchaseFutures
    {
        get; set;
    }
    /// <summary>차익매도CALL금액</summary>
    [DataMember, JsonProperty("차익매도CALL금액")]
    public string? ProfitSellingCALLAmount
    {
        get; set;
    }
    /// <summary>차익매수CALL금액</summary>
    [DataMember, JsonProperty("차익매수CALL금액")]
    public string? ProfitTakingCALLAmount
    {
        get; set;
    }
    /// <summary>차익매도PUT금액</summary>
    [DataMember, JsonProperty("차익매도PUT금액")]
    public string? ProfitSellingPUTAmount
    {
        get; set;
    }
    /// <summary>차익매수PUT금액</summary>
    [DataMember, JsonProperty("차익매수PUT금액")]
    public string? ProfitTakingPUTAmount
    {
        get; set;
    }
    /// <summary>종목코드2</summary>
    [DataMember, JsonProperty("종목코드2")]
    public string? Code2
    {
        get; set;
    }
    /// <summary>차익매도위탁금액2</summary>
    [DataMember, JsonProperty("차익매도위탁금액2")]
    public string? ConsignmentAmountOfProfitSelling2
    {
        get; set;
    }
    /// <summary>차익매수위탁금액2</summary>
    [DataMember, JsonProperty("차익매수위탁금액2")]
    public string? ConsignmentAmountForProfitTaking2
    {
        get; set;
    }
    /// <summary>차익매도위탁선물금액2</summary>
    [DataMember, JsonProperty("차익매도위탁선물금액2")]
    public string? ProfitSellingConsignmentFuturesAmount2
    {
        get; set;
    }
    /// <summary>차익매수위탁선물금액2</summary>
    [DataMember, JsonProperty("차익매수위탁선물금액2")]
    public string? ProfitTakingConsignmentFuturesAmount2
    {
        get; set;
    }
    /// <summary>차익매도위탁CALL금액2</summary>
    [DataMember, JsonProperty("차익매도위탁CALL금액2")]
    public string? ConsignmentOfProfitTakingCALLAmount2
    {
        get; set;
    }
    /// <summary>차익매수위탁CALL금액2</summary>
    [DataMember, JsonProperty("차익매수위탁CALL금액2")]
    public string? ProfitTakingConsignmentCALLAmount2
    {
        get; set;
    }
    /// <summary>차익매도위탁PUT금액2</summary>
    [DataMember, JsonProperty("차익매도위탁PUT금액2")]
    public string? SellTakingConsignmentPUTAmount2
    {
        get; set;
    }
    /// <summary>차익매수위탁PUT금액2</summary>
    [DataMember, JsonProperty("차익매수위탁PUT금액2")]
    public string? BuyTakingConsignmentPUTAmount2
    {
        get; set;
    }
    /// <summary>차익매도자기금액2</summary>
    [DataMember, JsonProperty("차익매도자기금액2")]
    public string? ProfitSellerFundAmount2
    {
        get; set;
    }
    /// <summary>차익매수자기금액2</summary>
    [DataMember, JsonProperty("차익매수자기금액2")]
    public string? ProfitBuyerFundAmount2
    {
        get; set;
    }
    /// <summary>차익매도자기선물금액2</summary>
    [DataMember, JsonProperty("차익매도자기선물금액2")]
    public string? ProfitSellingSelfFinanceFuturesAmount2
    {
        get; set;
    }
    /// <summary>차익매수자기선물금액2</summary>
    [DataMember, JsonProperty("차익매수자기선물금액2")]
    public string? ProfitTakingSelfFinanceFuturesAmount2
    {
        get; set;
    }
    /// <summary>차익매도자기CALL금액2</summary>
    [DataMember, JsonProperty("차익매도자기CALL금액2")]
    public string? ProfitTakingSelfDealingCALLAmount2
    {
        get; set;
    }
    /// <summary>차익매수자기CALL금액2</summary>
    [DataMember, JsonProperty("차익매수자기CALL금액2")]
    public string? ProfitTakingSelfCALLAmount2
    {
        get; set;
    }
    /// <summary>차익매도자기PUT금액2</summary>
    [DataMember, JsonProperty("차익매도자기PUT금액2")]
    public string? ProfitSellingSelfPUTAmount2
    {
        get; set;
    }
    /// <summary>차익매수자기PUT금액2</summary>
    [DataMember, JsonProperty("차익매수자기PUT금액2")]
    public string? ProfitTakingSelfPUTAmount2
    {
        get; set;
    }
    /// <summary>차익매도금액2</summary>
    [DataMember, JsonProperty("차익매도금액2")]
    public string? ProfitSellingAmount2
    {
        get; set;
    }
    /// <summary>차익매수금액2</summary>
    [DataMember, JsonProperty("차익매수금액2")]
    public string? ProfitTakingAmount2
    {
        get; set;
    }
    /// <summary>차익매도선물금액2</summary>
    [DataMember, JsonProperty("차익매도선물금액2")]
    public string? ProfitSellingFuturesAmount2
    {
        get; set;
    }
    /// <summary>차익매수선물금액2</summary>
    [DataMember, JsonProperty("차익매수선물금액2")]
    public string? ProfitTakingFuturesAmount2
    {
        get; set;
    }
    /// <summary>차익매도CALL금액2</summary>
    [DataMember, JsonProperty("차익매도CALL금액2")]
    public string? ProfitSellingCALLAmount2
    {
        get; set;
    }
    /// <summary>차익매수CALL금액2</summary>
    [DataMember, JsonProperty("차익매수CALL금액2")]
    public string? ProfitTakingCALLAmount2
    {
        get; set;
    }
    /// <summary>차익매도PUT금액2</summary>
    [DataMember, JsonProperty("차익매도PUT금액2")]
    public string? ProfitSellingPUTAmount2
    {
        get; set;
    }
    /// <summary>차익매수PUT금액2</summary>
    [DataMember, JsonProperty("차익매수PUT금액2")]
    public string? ProfitTakingPUTAmount2
    {
        get; set;
    }
}