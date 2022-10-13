using Microsoft.AspNetCore.SignalR;
using SignallRHub.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignallRHub
{
    public class BroadcastHub : Hub<IHubClient>
    {
        public async Task BroadcastQRDetails(string qRDetails)
        {
            QRDetails QR = JsonConvert.DeserializeObject<QRDetails>(qRDetails);
            await Clients.All.ListenQRDetails(QR);
        }

        public async Task BroadcastCardDetails(string cardDetails)
        {
            //QRDetails QR = JsonConvert.DeserializeObject<QRDetails>(qRDetails);
            await Clients.All.ListenCardDetails(cardDetails);
        }

        public async Task BroadcastMessage(string Message)
        {
            await Clients.All.ListenMessage(Message);
        }
    }
}
