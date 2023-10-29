using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>옵션매도주문증거금현황요청</summary>
public class Opw20015 : TR
{
    /// <summary>옵션행사가</summary>
    [DataMember, JsonProperty("옵션행사가")]
    public SingleOpw20015? SingleResponse
    {
        get; set;
    }
    /// <summary>옵션매도주문증거금</summary>
    [DataMember, JsonProperty("옵션매도주문증거금")]
    public MultiOpw20015[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.월물구분
    /// 2.클래스구분
    /// </summary>
    public override string[] Id => new[] { "월물구분", "클래스구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "옵션매도주문증거금현황요청";
    }
    public override string TrCode
    {
        get => nameof(Opw20015);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "종목코드", "ATM행사가격", "위치", "조회건수" };
    public override string[] Multiple => new[] { "콜조정이론가", "콜최대이론가", "콜전일종가", "콜주문증거금", "행사가격", "풋주문증거금", "풋전일종가", "풋최대이론가", "풋조정이론가" };
}