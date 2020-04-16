using System;

namespace SpfBlazorDemo.Services
{
    public class MessageService
    {
        public event EventHandler<string> MessageAdd;

        public void AddMessage(string message)
        {
            MessageAdd?.Invoke(this, message);
        }
    }
}
