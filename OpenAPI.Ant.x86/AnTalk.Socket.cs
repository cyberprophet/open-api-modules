﻿using Microsoft.AspNetCore.SignalR.Client;

using ShareInvest.Hubs.Socket;
using ShareInvest.Properties;

using System.Media;

namespace ShareInvest;

partial class AnTalk
{
    async Task ConnectingAsync(string resource)
    {
        while (Socket is null)
        {
            if (string.IsNullOrEmpty(webView.AccessToken))
            {
                await Task.Delay(0x400);

                continue;
            }
            using (var sp = new SoundPlayer(Resources.MARIO))
            {
                Socket = new KiwoomHub(string.Concat(webView.Url, resource), accessToken: webView.AccessToken, serialKey: serialKey);

                sp.PlaySync();
            }
            break;
        }
        if (HubConnectionState.Disconnected == Socket.Hub.State)
        {
            Socket.Hub.Closed += OccursDependingOnConnection;
            Socket.Hub.ServerTimeout = TimeSpan.FromSeconds(0x40);
            Socket.Hub.HandshakeTimeout = TimeSpan.FromSeconds(0x20);

            await Socket.Hub.StartAsync();
        }
    }
    bool IsAdministrator
    {
        get; set;
    }
}