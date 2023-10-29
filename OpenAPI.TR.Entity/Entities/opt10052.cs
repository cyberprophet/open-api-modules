using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>거래원순간거래량요청</summary>
public class Opt10052 : TR
{
    /// <summary>거래원순간거래량</summary>
    [DataMember, JsonProperty("거래원순간거래량")]
    public MultiOpt10052[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.회원사코드
    /// 2.종목코드
    /// 3.시장구분
    /// 4.수량구분
    /// 5.가격구분
    /// </summary>
    public override string[] Id => new[] { "회원사코드", "종목코드", "시장구분", "수량구분", "가격구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "거래원순간거래량요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10052);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => Array.Empty<string>();
    public override string[] Multiple => new[] { "시간", "종목코드", "종목명", "거래원명", "구분", "순간거래량", "누적순매수", "현재가", "전일대비기호", "전일대비", "전일대비" };
}