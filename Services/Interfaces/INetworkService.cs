using MAUISampleApp.MVVM.Models.Enums;

namespace MAUISampleApp.MVVM.Services.Interfaces
{
    public interface INetworkService
    {
        bool IsNetworkAvailable();
        NetworkStatus GetNetworkStatus();
    }
}
