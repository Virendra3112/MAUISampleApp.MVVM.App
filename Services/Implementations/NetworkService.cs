using MAUISampleApp.MVVM.Services.Interfaces;

namespace MAUISampleApp.MVVM.Services.Implementations
{
    public class NetworkService : INetworkService
    {
        private NetworkAccess accessType;
        public NetworkService()
        {
            accessType = Connectivity.Current.NetworkAccess;

            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;

        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            if (e.NetworkAccess == NetworkAccess.ConstrainedInternet)
                Console.WriteLine("Internet access is available but is limited.");

            else if (e.NetworkAccess != NetworkAccess.Internet)
                Console.WriteLine("Internet access has been lost.");
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
