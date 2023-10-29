using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>미체결요청</summary>
public class Opt10075 : TR
{
    /// <summary>미체결</summary>
    [DataMember, JsonProperty("미체결")]
    public MultiOpt10075[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.전체종목구분
    /// 3.매매구분
    /// 4.종목코드
    /// 5.체결구분
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "전체종목구분", "매매구분", "종목코드", "체결구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "미체결요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10075);
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
    public override string[] Multiple => new[] { "계좌번호", "주문번호", "관리사번", "종목코드", "업무구분", "주문상태", "종목명", "주문수량", "주문가격", "미체결수량", "체결누계금액", "원주문번호", "주문구분", "매매구분", "시간", "체결번호", "체결가", "체결량", "현재가", "매도호가", "매수호가", "단위체결가", "단위체결량", "당일매매수수료", "당일매매세금", "개인투자자" };
}