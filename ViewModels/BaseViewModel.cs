using CommonServiceLocator;
using MAUISampleApp.MVVM.Services.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MAUISampleApp.MVVM.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged//, ObservableObject
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
            try
            {
                //if (!ServiceLocator..<IPageNavigationService>())

                    PageNavigationService = ServiceLocator.Current.GetInstance<IPageNavigationService>();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }

    }
}
