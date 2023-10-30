### 키움증권 OpenAPI x86 라이브러리
- **TR**요청 **opt10001**
```C#
partial class Kiwoom : Form
{
    internal Kiwoom()
    {
        InitializeComponent();

        var ax = new AxKH();

        Controls.Add(ax);

        ax.Dock = DockStyle.Fill;
        ax.Visible = false;

        TR tr = new Opt10001
        {
            /// <summary>Input 순서에 맞게 배열에 값을 채워주면 모든 TR요청이 가능합니다.</summary>
            Value = new[] { "005930" }
        };
        ax.API.OnReceiveTrData += (sender, e) =>
        {
            /// <summary>JSON또는 Dictionary로 return을 받을 수 있습니다.</summary>
            var dictionary = ax.ConvertTrSingleData<Dictionary<string, string>>(tr.Single, e);

            var json = ax.ConvertTrSingleData<string>(tr.Single, e);

            /// <summary>JSON으로 return 받았다면 Entity패키지를 사용하여 class로 변환할 수 있습니다.
            var result = JsonConvert.DeserializeObject<SingleOpt10001>(json);

            Console.WriteLine(json);
        };        
        ax.API.OnEventConnect += (sender, e) =>
        {
            if (e.nErrCode != 0)
            {
                return;
            }
            /// <summary>기본값은 601ms로 설정되어 있습니다.</summary>
            Delay.Instance.Run();

            /// <summary>지연시간은 ms단위로 자유롭게 설정할 수 있습니다.</summary>
            Delay.Instance.Milliseconds = 1;

            ax.CommRqData(tr);
        };
        ax.API.CommConnect();
    }
}
```
- **JSON**
```json
{
  "종목코드": "005930",
  "종목명": "삼성전자",
  "결산월": "12",
  "액면가": "100",
  "자본금": "7780",
  "상장주식": "5969783",
  "신용비율": "+0.09",
  "연중최고": "+73600",
  "연중최저": "-54500",
  "시가총액": "4017664",
  "시가총액비중": "",
  "외인소진률": "+53.08",
  "대용가": "53840",
  "PER": "8.35",
  "EPS": "8057",
  "ROE": "17.1",
  "PBR": "1.32",
  "EV": "3.60",
  "BPS": "50817",
  "매출액": "3022314",
  "영업이익": "433766",
  "당기순이익": "556541",
  "250최고": "+73600",
  "250최저": "-54500",
  "시가": "-66800",
  "고가": "+67800",
  "저가": "-66700",
  "상한가": "+87400",
  "하한가": "-47200",
  "기준가": "67300",
  "예상체결가": "-0",
  "예상체결수량": "0",
  "250최고가일": "20230704",
  "250최고가대비율": "-8.56",
  "250최저가일": "20230103",
  "250최저가대비율": "+23.49",
  "현재가": "67300",
  "대비기호": "3",
  "전일대비": "0",
  "등락율": "0.00",
  "거래량": "10139270",
  "거래대비": "",
  "액면가단위": "원",
  "유통주식": "4533800",
  "유통비율": "76.0"
}
```
### · Implemented as [![Platform](https://img.shields.io/nuget/v/Microsoft.NETCore.Platforms?label=CSharp&style=plastic&logo=.NET&color=512BD4)](https://versionsof.net) using [![IDE](https://img.shields.io/badge/Visual%20Studio-2022-5C2D91?style=plastic&logoColor=white&logo=visualstudio)](https://learn.microsoft.com/en-us/visualstudio/releases/2022).
