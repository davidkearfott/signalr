using HTTR.Models;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace HTTR.Hubs
{
    public class RichmondHub : Hub
    {
        public void Rate(int playerId, bool thumbsUp)
        {
            Player PlayerToRate = Roster.Players.Find(p => p.Id == playerId);
            PlayerToRate.Rating += thumbsUp ? 1 : -1;

            Clients.All.updateRating(playerId, PlayerToRate.Rating);
        }

        public override Task OnConnected()
        {
            // Send current rating to newly joined client   
            Clients.Caller.hailToTheRedskins(Roster.Players);

            Roster.counter += 1;
            Clients.All.incrementCounter(Roster.counter);

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            Roster.counter -= 1;
            Clients.All.incrementCounter(Roster.counter);
            return base.OnDisconnected(stopCalled);
        }


    }
}