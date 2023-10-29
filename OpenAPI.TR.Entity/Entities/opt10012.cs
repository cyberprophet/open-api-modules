using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주문체결요청</summary>
public class Opt10012 : TR
{
    /// <summary>주문체결</summary>
    [DataMember, JsonProperty("주문체결")]
    public MultiOpt10012[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// </summary>
    public override string[] Id => new[] { "계좌번호" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "주문체결요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10012);
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
    public override string[] Multiple => new[] { "주문수량", "주문가격", "미체결수량", "체결누계금액", "원주문번호", "주문구분", "매매구분", "매도수구분", "주문/체결시간", "체결가", "체결량", "주문상태", "단위체결가", "대출일", "신용구분", "만기일", "보유수량", "매입단가", "총매입가", "주문가능수량", "당일매도수량", "당일매도금액", "당일매수수량", "당일매수금액", "당일매매수수료", "당일매매세금", "당일hts매도수수료", "당일hts매수수수료", "당일매도손익", "당일순매수량", "매도/매수구분", "당일총매도손일", "예수금", "사용가능현금", "사용가능대용", "전일재사용", "당일재사용", "담보현금", "신용금액", "신용이자", "담보대출수량", "현물주문체결이상유무", "현물잔고이상유무", "현물예수금이상유무", "선물주문체결이상유무", "선물잔고이상유무", "D+1추정예수금", "D+2추정예수금", "D+1매수/매도정산금", "D+2매수/매도정산금", "D+1연체변제소요금", "D+2연체변제소요금", "D+1추정인출가능금", "D+2추정인출가능금", "현금증거금", "대용잔고", "대용증거금", "수표금액", "현금미수금", "신용설정보증금", "인출가능금액" };
}