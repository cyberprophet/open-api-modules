```C#
ax.API.OnReceiveTrData += (sender, e) =>
{
    textBox.Text = ax.ConvertTrSingleData<string>(new Opt10001().Single, e);
};
ax.API.OnEventConnect += async (sender, e) =>
{
    if (e.nErrCode != 0)
    {
        textBox.Text = e.nErrCode.ToString();
    }
    foreach (var code in GetCodeListByMarket())
    {
        // Returns in milliseconds, reflecting latency.
        var delayTime = RequestLimit.CheckAndResetLimits();

        if (delayTime != 0)
        {
            textBox.Text = $"Count: {CodeCount}
                             Seconds: {RequestLimit.GetDelaySeconds()}
                             Minutes: {RequestLimit.GetDelayMinute()}
                             Hours: {RequestLimit.GetDelayHour()}";
        }
        await Task.Delay((int)delayTime + 1);

        ax.CommRqData(new Opt10001
        {
            Value = new[] { code }
        });
        CodeCount++;
    }
};
ax.API.CommConnect();
```
### [· For detailed examples, follow the link.](https://github.com/Share-Invest/open-api-modules/blob/dev/OpenAPI.Restrictions.Inquiry/RequestLimit.cs)
