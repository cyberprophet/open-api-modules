```C#
Delay.Instance.RequestTheMission(new Task(() =>
{
    for (int index = 0; index < tr.Id.Length; index++)
    {
        axAPI.SetInputValue(tr.Id[index], tr.Value?[index]);
    }
    OnReceiveErrMessage(tr.RQName, axAPI.CommRqData(tr.RQName, tr.TrCode, tr.PrevNext, tr.ScreenNo));
}));
```
### [· For detailed examples, follow the link.](https://github.com/Share-Invest/open-api-modules/tree/dev/OpenAPI.TR.Constraints)
