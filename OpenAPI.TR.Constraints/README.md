### · Execute
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
### · Initialize
```C#
axAPI.OnEventConnect += (sender, e) =>
{
    if (e.nErrCode != 0)
    {
        textBox.Text = e.nErrCode.ToString();
    }
    foreach (var code in GetCodeListByMarket())
    {
        axAPI.CommRqData(new Opt10004
        {
            Value = new[] { code }
        });
    }
}
Delay.Instance.Run();
```
### · Options
```C#
// If true, a limit of 1000 per hour is used.
// default is false.
public static bool IsUsingHoursUnit
{
    get; set;
}
internal static int CheckAndResetLimits(DateTime? now = null)
{
    ...

    if (IsUsingHoursUnit && perHour > 0)
    {
        return (int)perHour + 1;
    }
    ...
}
```
### [· For detailed examples, follow the link.](https://github.com/Share-Invest/open-api-modules/tree/dev/OpenAPI.TR.Constraints)
