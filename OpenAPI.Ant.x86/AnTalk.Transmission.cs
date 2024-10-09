using RestSharp;

using ShareInvest.Observers;
using ShareInvest.OpenAPI.Entity;

using System.Diagnostics;
using System.Net;

namespace ShareInvest;

partial class AnTalk
{
    async Task OnReceiveMessage(TransmissionEventArgs e)
    {
        RestResponse? response;

        switch (e.Transmission)
        {
            case Opt50029 when Talk != null && opt50029Collection.IsEmpty is false:
                response = await Talk.ExecutePostAsync(e.Transmission.TrCode, opt50029Collection);

                if (HttpStatusCode.OK != response.StatusCode || StopContinuousInquiry(response.Content, opt50029Collection.Count))
                {
                    e.Transmission.PrevNext = 0;
                }
                opt50029Collection.Clear();
                break;

            case Opt50067 when Talk != null && opt50067Collection.IsEmpty is false:
                response = await Talk.ExecutePostAsync(e.Transmission.TrCode, opt50067Collection);

                if (HttpStatusCode.OK != response.StatusCode || StopContinuousInquiry(response.Content, opt50067Collection.Count))
                {
                    e.Transmission.PrevNext = 0;
                }
                opt50067Collection.Clear();
                break;

            case OPT50006 when Talk != null && opt50006Collection.IsEmpty is false:
                response = await Talk.ExecutePostAsync(e.Transmission.TrCode, opt50006Collection);

                if (HttpStatusCode.OK != response.StatusCode || StopContinuousInquiry(response.Content, opt50006Collection.Count))
                {
                    e.Transmission.PrevNext = 0;
                }
                opt50006Collection.Clear();
                break;

            case Opt10003 when Talk != null && opt10003Collection.IsEmpty is false:
                response = await Talk.ExecutePostAsync(e.Transmission.TrCode, opt10003Collection);

                if (HttpStatusCode.OK != response.StatusCode || StopContinuousInquiry(response.Content, opt10003Collection.Count))
                {
                    e.Transmission.PrevNext = 0;
                }
                opt10003Collection.Clear();
                break;

            case Opt10080 when Talk != null && opt10080Collection.IsEmpty is false:
                response = await Talk.ExecutePostAsync(e.Transmission.TrCode, opt10080Collection);

                if (HttpStatusCode.OK != response.StatusCode || StopContinuousInquiry(response.Content, opt10080Collection.Count))
                {
                    e.Transmission.PrevNext = 0;
                }
                opt10080Collection.Clear();
                break;

            case Opt20005 when Talk != null && opt20005Collection.IsEmpty is false:
                response = await Talk.ExecutePostAsync(e.Transmission.TrCode, opt20005Collection);

                if (HttpStatusCode.OK != response.StatusCode || StopContinuousInquiry(response.Content, opt20005Collection.Count))
                {
                    e.Transmission.PrevNext = 0;
                }
                opt20005Collection.Clear();
                break;

            case Opt50068 when Talk != null:

                while (opt50068Collection.TryDequeue(out var collection))
                {
                    response = await Talk.ExecutePostAsync(e.Transmission.TrCode, collection);

                    if (HttpStatusCode.OK == response.StatusCode && StopContinuousInquiry(response.Content))
                    {
                        continue;
                    }
                    opt50068Collection.Clear();

                    e.Transmission.PrevNext = opt50068Collection.Count;
                }
                break;

            case Opt50030 when Talk != null:

                while (opt50030Collection.TryDequeue(out var collection))
                {
                    response = await Talk.ExecutePostAsync(e.Transmission.TrCode, collection);

                    if (HttpStatusCode.OK == response.StatusCode && StopContinuousInquiry(response.Content))
                    {
                        continue;
                    }
                    opt50030Collection.Clear();

                    e.Transmission.PrevNext = opt50030Collection.Count;
                }
                break;

            case Opt10081 when Talk != null:

                while (opt10081Collection.TryDequeue(out var collection))
                {
                    response = await Talk.ExecutePostAsync(e.Transmission.TrCode, collection);

                    if (HttpStatusCode.OK == response.StatusCode && StopContinuousInquiry(response.Content))
                    {
                        continue;
                    }
                    opt10081Collection.Clear();

                    e.Transmission.PrevNext = opt10081Collection.Count;
                }
                break;

            case Opt20006 when Talk != null:

                while (opt20006Collection.TryDequeue(out var collection))
                {
                    response = await Talk.ExecutePostAsync(e.Transmission.TrCode, collection);

                    if (HttpStatusCode.OK == response.StatusCode && StopContinuousInquiry(response.Content))
                    {
                        continue;
                    }
                    opt20006Collection.Clear();

                    e.Transmission.PrevNext = opt20006Collection.Count;
                }
                break;
        }

        if (e.Transmission.PrevNext == 2)
        {
            axAPI.CommRqData(e.Transmission);

            return;
        }

        switch (e.Transmission)
        {
            case Opt10003:
            case Opt10080:
            case Opt20005 or Opt20006:
            case OPT50006:
            case Opt50029 or Opt50030:
            case Opt50067 or Opt50068:
#if DEBUG
                Debug.WriteLine(e.Transmission);
#endif
                break;

            case Opt10081 when DateTime.Now.ToString("yyyyMMdd").Equals(e.Transmission.Value?[1]):

                break;

            default:

                return;
        }
        Delay.Instance.Milliseconds = await RequestTransmissionAsync(e.Transmission.TrCode);
    }

    static bool StopContinuousInquiry(string? content, int count)
    {
        var positive = int.TryParse(content?.Replace("\"", string.Empty), out int saveChanges);

        return positive && saveChanges != count;
    }

    static bool StopContinuousInquiry(string? content)
    {
        var positive = int.TryParse(content?.Replace("\"", string.Empty), out int saveChanges);

        return positive && saveChanges > 0;
    }
}