using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물전체시세요청</summary>
public class OPTFOFID : TR
{
    /// <summary>선물전체시세</summary>
    [DataMember, JsonProperty("선물전체시세")]
    public SingleOPTFOFID? SingleResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// </summary>
    public override string[] Id => new[] { "종목코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선물전체시세요청";
    }
    public override string TrCode
    {
        get => nameof(OPTFOFID);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "종목코드", "종목명", "현재가", "전일대비", "매도호가2", "매도호가1", "매수호가1", "매수호가2", "거래량", "거래량전일대비", "누적거래대금", "미결제약정", "미결제약정전일대비", "시가", "고가", "저가", "이론가", "괴리율", "시장베이시스", "이론베이시스", "행사가", "지수환산", "대비기호", "등락율", "매수수량", "매수호가총건수", "매도호가총건수", "기준가", "잔존일수", "영업일기준잔존일" };
    public override string[] Multiple => Array.Empty<string>();
}