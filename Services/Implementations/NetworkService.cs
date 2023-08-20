using MAUISampleApp.MVVM.Models.Enums;
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
                result = true;

            return result;
        }

        public NetworkStatus GetNetworkStatus()
        {
            if (accessType == NetworkAccess.Internet)
                return NetworkStatus.Available;

            else if (accessType == NetworkAccess.ConstrainedInternet)
                return NetworkStatus.SlowNetwork;

            else
                return NetworkStatus.NotAvailable;
        }
    }
}
