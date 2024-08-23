using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRP2
{
    [HubName("chat")]
    public class ChatHub : Hub
    {


        public void sendMessage(string name, string message)
        {
            Clients.All.newMessage(name, message);

            // Save in Db
            //ChatContext chatContext = new ChatContext();

            //Message messsage = new Message() { Name = name, Message1 = message, Date = DateTime.Now };

            //chatContext.Messages.Add(messsage);
            //chatContext.SaveChanges();

        }

    }
}