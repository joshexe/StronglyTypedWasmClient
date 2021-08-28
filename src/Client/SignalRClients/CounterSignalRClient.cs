using System;
using System.Threading.Tasks;
using StronglyTypedWasmClient.Client.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.AspNetCore.Components;

namespace StronglyTypedWasmClient.Client.SignalRClients
{
    /// <summary>
    /// A proof of concept for a strongly typed signalr client and signalR base client
    /// This class also shows how to use the same interface
    /// that the server is using to register the hub.  This should lead to better refactoring support.
    /// When using this example for future code, the key thing to watch should be the hub path (still want a nicer way to unify that).
    /// Anything else required should be required to implement the specific signalRClient interface
    /// </summary>
    public class CounterSignalRClient
        : SignalRClientBase, ICounterSignalRClient
    {
        public CounterSignalRClient(NavigationManager navigationManager)
            : base(navigationManager, "/CounterHub")
        {
        }

        public async Task CountChanged(int newValue)
        {
            await HubConnection.SendAsync(nameof(CountChanged), newValue);
        }

        public void OnCountChanged(Action<int> action)
        {
            // Don't attach the handler once the connection is started to prevent duplicate handling
            // This could also be done per page instead
            if (!Started)
            {
                HubConnection.On(nameof(CountChanged), action);
            }
        }
    }
}
