using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>체결요청</summary>
public class Opt10076 : TR
{
    /// <summary>체결</summary>
    [DataMember, JsonProperty("체결")]
    public MultiOpt10076[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.조회구분
    /// 3.매도수구분
    /// 4.계좌번호
    /// 5.비밀번호
    /// 6.주문번호
    /// 7.체결구분
    /// </summary>
    public override string[] Id => new[] { "종목코드", "조회구분", "매도수구분", "계좌번호", "비밀번호", "주문번호", "체결구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "체결요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10076);
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
    public override string[] Multiple => new[] { "주문번호", "종목명", "주문구분", "주문가격", "주문수량", "체결가", "체결량", "미체결수량", "당일매매수수료", "당일매매세금", "주문상태", "매매구분", "원주문번호", "주문시간", "종목코드" };
}