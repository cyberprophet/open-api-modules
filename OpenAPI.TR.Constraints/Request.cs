using System.Diagnostics;

namespace ShareInvest;

public static class Request
{
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
    /// <summary>The maximum number of requests per second is 5.</summary>
    public static double DelaySeconds
    {
        get; private set;
    }
    /// <summary>The maximum number of requests per minute is 100.</summary>
    public static double DelayMinutes
    {
        get; private set;
    }
    /// <summary>The maximum number of requests per hour is 1000.</summary>
    public static double DelayHours
    {
        get; private set;
    }
    internal static int CheckAndResetLimits(DateTime? now = null)
    {
        var requestTime = now ?? DateTime.Now;

        var perSecond = CheckAndResetLimitsPerSecond(requestTime);
        var perMinute = CheckAndResetLimitsPerMinute(requestTime);
        var perHour = CheckAndResetLimitsPerHour(requestTime);

        if (perHour > 0)
        {
            return (int)perHour + 1;
        }
        if (perMinute > 0)
        {
            return (int)perMinute + 1;
        }
        if (perSecond > 0)
        {
            return (int)perSecond + 1;
        }
        return 0;
    }
    static double CheckAndResetLimitsPerSecond(DateTime requestTime)
    {
        DelaySeconds = double.NegativeZero;

        if (maxRequestsPerSecond.Count >= 5 && maxRequestsPerSecond.TryDequeue(out DateTime firstRequestTime))
        {
            var timeSpan = requestTime.Subtract(firstRequestTime);

            if (timeSpan.TotalSeconds <= 1)
            {
                DelaySeconds = 1000 - timeSpan.TotalMilliseconds;
            }
            Debug.WriteLine(new
            {
                Second = timeSpan,
                maxRequestsPerSecond.Count
            });
        }
        maxRequestsPerSecond.Enqueue(requestTime);

        return double.NegativeZero + DelaySeconds;
    }
    static double CheckAndResetLimitsPerMinute(DateTime requestTime)
    {
        DelayMinutes = double.NegativeZero;

        if (maxRequestsPerMinute.Count >= 100 && maxRequestsPerMinute.TryDequeue(out DateTime firstRequestTime))
        {
            var timeSpan = requestTime.Subtract(firstRequestTime);

            if (timeSpan.TotalMinutes <= 1)
            {
                DelayMinutes = 1000 * 60 - timeSpan.TotalMilliseconds;
            }
            Debug.WriteLine(new
            {
                Minute = timeSpan,
                maxRequestsPerMinute.Count
            });
        }
        maxRequestsPerMinute.Enqueue(requestTime);

        return double.NegativeZero + DelayMinutes;
    }
    static double CheckAndResetLimitsPerHour(DateTime requestTime)
    {
        DelayHours = double.NegativeZero;

        if (maxRequestsPerHour.Count >= 1000 && maxRequestsPerHour.TryDequeue(out DateTime firstRequestTime))
        {
            var timeSpan = requestTime.Subtract(firstRequestTime);

            if (timeSpan.TotalHours <= 1)
            {
                DelayHours = 1000 * 60 * 60 - timeSpan.TotalMilliseconds;
            }
            Debug.WriteLine(new
            {
                Hour = timeSpan,
                maxRequestsPerHour.Count
            });
        }
        maxRequestsPerHour.Enqueue(requestTime);

        return double.NegativeZero + DelayHours;
    }
    static readonly Queue<DateTime> maxRequestsPerSecond = new();
    static readonly Queue<DateTime> maxRequestsPerMinute = new(0x20);
    static readonly Queue<DateTime> maxRequestsPerHour = new(0x100);
}