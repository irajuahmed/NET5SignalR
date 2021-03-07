using System.Threading.Tasks;

namespace NET5SignalR.Models
{
    public interface IHubClient
    {
        Task BroadcastMessage();
    }
}
