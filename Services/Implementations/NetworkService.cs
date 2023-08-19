using MAUISampleApp.MVVM.Services.Interfaces;

namespace MAUISampleApp.MVVM.Services.Implementations
{
    public class NetworkService : INetworkService
    {
        private NetworkAccess accessType;
        public NetworkService()
        {
            accessType = Connectivity.Current.NetworkAccess;
        }
        public bool IsNetworkAvailable()
        {
            bool result = false;
            if (accessType == NetworkAccess.Internet)
            {
                // Connection to internet is available
                result = true;
            }

            return result;
        }
    }
}
