using Microsoft.AspNet.SignalR;

namespace SignalRDemo
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }

        public void Push()
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.pushMessage("Selamlar");
        }
    }
}