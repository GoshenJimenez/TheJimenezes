using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.Controllers
{
    public class SignalHub : Hub
    {
        public async Task SendMessage(Guid? userId, string message)
        {
            await Clients.All.SendAsync("ReceiveNotification", userId, message);
        }
    }
}
