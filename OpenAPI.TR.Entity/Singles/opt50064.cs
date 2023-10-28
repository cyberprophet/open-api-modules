using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>옵션현재가정보</summary>
public class SingleOpt50064
{
    /// <summary>현재가s</summary>
    [DataMember, JsonProperty("현재가s")]
    public string? 현재가s
    {
        get; set;
    }
    /// <summary>대비기호s</summary>
    [DataMember, JsonProperty("대비기호s")]
    public string? 대비기호s
    {
        get; set;
    }
    /// <summary>전일대비s</summary>
    [DataMember, JsonProperty("전일대비s")]
    public string? 전일대비s
    {
        get; set;
    }
    /// <summary>등락율s</summary>
    [DataMember, JsonProperty("등락율s")]
    public string? 등락율s
    {
        get; set;
    }
    /// <summary>고가s</summary>
    [DataMember, JsonProperty("고가s")]
    public string? 고가s
    {
        get; set;
    }
    /// <summary>저가s</summary>
    [DataMember, JsonProperty("저가s")]
    public string? 저가s
    {
        get; set;
    }
    /// <summary>누적거래량s</summary>
    [DataMember, JsonProperty("누적거래량s")]
    public string? 누적거래량s
    {
        get; set;
    }
    /// <summary>미결제약정s</summary>
    [DataMember, JsonProperty("미결제약정s")]
    public string? 미결제약정s
    {
        get; set;
    }
    /// <summary>종목명s</summary>
    [DataMember, JsonProperty("종목명s")]
    public string? 종목명s
    {
        get; set;
    }
}