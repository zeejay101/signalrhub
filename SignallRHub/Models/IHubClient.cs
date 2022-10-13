using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignallRHub.Models
{
    public interface IHubClient
    {

        Task BroadcastQRDetails(string qRDetails);
        Task ListenQRDetails(QRDetails qRDetails);

        Task BroadcastCardDetails(string cardDetails);

        Task ListenCardDetails(string cardDetails);
        Task BroadcastMessage(string Message);
        Task ListenMessage(string Message);

        /*
        Task JoinGroup(string GroupName);
        Task SendMessageToGroup(string GroupName, string Message);
        */

    }
}
