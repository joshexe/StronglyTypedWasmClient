using System;
using StronglyTypedWasmClient.Shared.Interfaces;

namespace StronglyTypedWasmClient.Client.Interfaces
{
    /// <summary>
    /// This interface allows for strongly typed ui clients.
    /// It inherits any functions that exist on the hub.
    /// It also inherits from the ui SignalRClient interface that defines shared signalR client functions and properties
    /// This interface specifically defines method(s) that register actions to perform when the hub generates events
    /// </summary>
    public interface ICounterSignalRClient
        : ICounterHubClient, ISignalRClient
    {
        // Used to allow the clients to take action when the server event occurs
        void OnCountChanged(Action<int> action);
    }
}