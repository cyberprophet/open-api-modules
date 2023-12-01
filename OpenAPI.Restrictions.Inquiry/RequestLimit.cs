namespace ShareInvest;

public static class RequestLimit
{
    /// <summary>It tells waiting milliseconds.</summary>
    /// <returns>If get zero, can request it immediately.</returns>
    public static int CheckAndResetLimits(DateTime? now = null)
    {
        var requestTime = now ?? DateTime.Now;

        var perSecond = CheckAndResetLimitsPerSecond(requestTime);
        var perMinute = CheckAndResetLimitsPerMinute(requestTime);
        var perHour = CheckAndResetLimitsPerHour(requestTime);

        if (perSecond > 0)
        {
            return (int)perSecond + 0x10;
        }
        if (perMinute > 0)
        {
            return (int)perMinute + 0x100;
        }
        if (perHour > 0)
        {
            return (int)perHour + 0x1000;
        }
        return 0;
    }
    /// <summary>The maximum number of requests per second is 5.</summary>
    public static (int requestCount, TimeSpan delayTime) GetDelaySeconds()
    {
        if (maxRequestsPerSecond.Count < 5)
        {
            return (maxRequestsPerSecond.Count, TimeSpan.Zero);
        }
        _ = maxRequestsPerSecond.TryPeek(out DateTime firstRequestTime);

        return (maxRequestsPerSecond.Count, DateTime.Now.Subtract(firstRequestTime));
    }
    /// <summary>The maximum number of requests per minute is 100.</summary>
    public static (int requestCount, TimeSpan delayTime) GetDelayMinute()
    {
        if (maxRequestsPerMinute.Count < 100)
        {
            return (maxRequestsPerMinute.Count, TimeSpan.Zero);
        }
        _ = maxRequestsPerMinute.TryPeek(out DateTime firstRequestTime);

        return (maxRequestsPerMinute.Count, DateTime.Now.Subtract(firstRequestTime));
    }
    /// <summary>The maximum number of requests per hour is 1000.</summary>
    public static (int requestCount, TimeSpan delayTime) GetDelayHour()
    {
        if (maxRequestsPerHour.Count < 1000)
        {
            return (maxRequestsPerHour.Count, TimeSpan.Zero);
        }
        _ = maxRequestsPerHour.TryPeek(out DateTime firstRequestTime);

        return (maxRequestsPerHour.Count, DateTime.Now.Subtract(firstRequestTime));
    }
    static double CheckAndResetLimitsPerSecond(DateTime requestTime)
    {
        while (maxRequestsPerSecond.TryPeek(out DateTime firstRequestTime))
        {
            var timeSpan = requestTime.Subtract(firstRequestTime);

            if (timeSpan.TotalSeconds > 1)
            {
                maxRequestsPerSecond.Dequeue();

                continue;
            }
            if (maxRequestsPerSecond.Count < 5)
            {
                break;
            }
            maxRequestsPerSecond.Enqueue(requestTime.AddMilliseconds(timeSpan.TotalMilliseconds));

            return timeSpan.TotalMilliseconds;
        }
        maxRequestsPerSecond.Enqueue(requestTime);

        return double.NegativeZero;
    }
    static double CheckAndResetLimitsPerMinute(DateTime requestTime)
    {
        while (maxRequestsPerMinute.TryPeek(out DateTime firstRequestTime))
        {
            var timeSpan = requestTime.Subtract(firstRequestTime);

            if (timeSpan.TotalMinutes > 1)
            {
                maxRequestsPerMinute.Dequeue();

                continue;
            }
            if (maxRequestsPerMinute.Count < 100)
            {
                break;
            }
            maxRequestsPerMinute.Enqueue(requestTime.AddMilliseconds(timeSpan.TotalMilliseconds));

            return timeSpan.TotalMilliseconds;
        }
        maxRequestsPerMinute.Enqueue(requestTime);

        return double.NegativeZero;
    }
    static double CheckAndResetLimitsPerHour(DateTime requestTime)
    {
        while (maxRequestsPerHour.TryPeek(out DateTime firstRequestTime))
        {
            var timeSpan = requestTime.Subtract(firstRequestTime);

            if (timeSpan.TotalHours > 1)
            {
                maxRequestsPerHour.Dequeue();

                continue;
            }
            if (maxRequestsPerHour.Count < 1000)
            {
                break;
            }
            maxRequestsPerHour.Enqueue(requestTime.AddMilliseconds(timeSpan.TotalMilliseconds));

            return timeSpan.TotalMilliseconds;
        }
        maxRequestsPerHour.Enqueue(requestTime);

        return double.NegativeZero;
    }
    static readonly Queue<DateTime> maxRequestsPerSecond = new();
    static readonly Queue<DateTime> maxRequestsPerMinute = new(0x20);
    static readonly Queue<DateTime> maxRequestsPerHour = new(0x100);
}