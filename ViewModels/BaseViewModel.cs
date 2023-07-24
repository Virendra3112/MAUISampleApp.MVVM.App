using CommonServiceLocator;
using MAUISampleApp.MVVM.Services.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MAUISampleApp.MVVM.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region propertychanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion

        protected readonly IPageNavigationService PageNavigationService;

        public BaseViewModel()
        {
            //PageNavigationService = ServiceLocator.Current.GetInstance<IPageNavigationService>();
        }

    }
}
