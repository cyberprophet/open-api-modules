using ShareInvest.Observers;
using ShareInvest.OpenAPI.Entity;

using System.Net;

namespace ShareInvest;

partial class AnTalk
{
    async Task OnReceiveMessage(TransmissionEventArgs e)
    {
        switch (e.Transmission)
        {
            case Opt50029 when Talk != null:

                if (opt50029Collection.IsEmpty is false)
                {
                    var response = await Talk.ExecutePostAsync(e.Transmission.TrCode, opt50029Collection);

                    var positive = int.TryParse(response.Content?.Replace("\"", string.Empty), out int saveChanges);

                    if (HttpStatusCode.OK != response.StatusCode || positive && saveChanges != opt50029Collection.Count)
                    {
                        e.Transmission.PrevNext = 0;
                    }
                    opt50029Collection.Clear();
                }
                break;

            case Opt10080 when Talk != null:

                if (opt10080Collection.IsEmpty is false)
                {
                    var response = await Talk.ExecutePostAsync(e.Transmission.TrCode, opt10080Collection);

                    var positive = int.TryParse(response.Content?.Replace("\"", string.Empty), out int saveChanges);

                    if (HttpStatusCode.OK != response.StatusCode || positive && saveChanges != opt10080Collection.Count)
                    {
                        e.Transmission.PrevNext = 0;
                    }
                    opt10080Collection.Clear();
                }
                break;

            case Opt50068 when Talk != null:

                while (opt50068Collection.TryDequeue(out var collection))
                {
                    var response = await Talk.ExecutePostAsync(e.Transmission.TrCode, collection);

                    var positive = int.TryParse(response.Content?.Replace("\"", string.Empty), out int saveChanges);

                    if (HttpStatusCode.OK == response.StatusCode && positive && saveChanges > 0)
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
                    var response = await Talk.ExecutePostAsync(e.Transmission.TrCode, collection);

                    var positive = int.TryParse(response.Content?.Replace("\"", string.Empty), out int saveChanges);

                    if (HttpStatusCode.OK == response.StatusCode && positive && saveChanges > 0)
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
                    var response = await Talk.ExecutePostAsync(e.Transmission.TrCode, collection);

                    var positive = int.TryParse(response.Content?.Replace("\"", string.Empty), out int saveChanges);

                    if (HttpStatusCode.OK == response.StatusCode && positive && saveChanges > 0)
                    {
                        continue;
                    }
                    opt10081Collection.Clear();

                    e.Transmission.PrevNext = opt10081Collection.Count;
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
            case Opt10080:
            case Opt50029 or Opt50030:
            case Opt50068:

                break;

            case Opt10081 when DateTime.Now.ToString("yyyyMMdd").Equals(e.Transmission.Value?[1]):

                break;

            default:

                return;
        }
        Delay.Instance.Milliseconds = await RequestTransmissionAsync(e.Transmission.TrCode);
    }
}