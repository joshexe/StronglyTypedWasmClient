using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using StronglyTypedWasmClient.Shared.Interfaces;

namespace StronglyTypedWasmClient.Server.Hubs
{
    public class CounterHub : Hub<ICounterHubClient>
    {
        public async Task CountChanged(int newValue)
        {
            await Clients.All.CountChanged(newValue);
        }
    }
}