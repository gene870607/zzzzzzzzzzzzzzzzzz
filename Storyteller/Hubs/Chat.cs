using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storyteller.Hubs
{
    public class Chat : Hub
    {

        public async Task AddToGroup(string groupId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupId);

            await Clients.Group(groupId).SendAsync("Send", $"{Context.ConnectionId} 加入 {groupId}.");
        }





        public override async Task OnConnectedAsync()
        {
            //連上線
            await base.OnConnectedAsync();
        }




        public override async Task OnDisconnectedAsync(Exception exception)
        {
            //斷線
            await base.OnDisconnectedAsync(exception);
        }
    }
}
