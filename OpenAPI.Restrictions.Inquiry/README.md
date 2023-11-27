```C#
Delay.Instance.RequestTheMission(new Task(async () =>
{
    var delayTime = RequestLimit.CheckAndResetLimits();

    if (delayTime > 0)
    {
        await Task.Delay(delayTime);
    }
    for (int index = 0; index < tr.Id.Length; index++)
    {
        axAPI.SetInputValue(tr.Id[index], tr.Value?[index]);
    }
    OnReceiveErrMessage(tr.RQName, axAPI.CommRqData(tr.RQName, tr.TrCode, tr.PrevNext, sScrNo));
}));
Cache.SaveTemporarily(sScrNo, tr);
```
### [· For detailed examples, follow the link.](https://github.com/Share-Invest/open-api-modules/blob/dev/OpenAPI.Restrictions.Inquiry/RequestLimit.cs)
