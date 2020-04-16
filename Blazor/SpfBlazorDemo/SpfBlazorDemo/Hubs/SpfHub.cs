using System;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using SpfBlazorDemo.Services;

namespace SpfBlazorDemo.Hubs
{
    public class SpfHub : Hub
    {
        private readonly MessageService msgService;

        public SpfHub(MessageService msgService)
        {
            this.msgService = msgService;
        }

        public event EventHandler<string> SayHello;
        public async Task BroadcastHelloAsync()
        {
            msgService.AddMessage("Hallo :D");
        }

        public async Task BroadcastAsync(string message)
        {
            msgService.AddMessage(message);
        }
    }
}
