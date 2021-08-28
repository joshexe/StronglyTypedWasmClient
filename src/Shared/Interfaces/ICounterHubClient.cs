using System.Threading.Tasks;

namespace StronglyTypedWasmClient.Shared.Interfaces
{
    public interface ICounterHubClient
    {
        Task CountChanged(int newValue);
    }
}