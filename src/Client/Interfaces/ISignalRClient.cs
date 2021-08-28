using System.Threading.Tasks;
using StronglyTypedWasmClient.Shared.Interfaces;

namespace StronglyTypedWasmClient.Client.Interfaces
{
    /// <summary>
    /// Interface that provides for ui clients to connect to and use signalR hubs
    ///</summary>
    public interface ISignalRClient
    {
        bool IsConnected { get; }
        Task Start();
    }
}