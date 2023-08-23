using CommunityToolkit.Maui.Views;
using MAUISampleApp.MVVM.Services.Interfaces;

namespace MAUISampleApp.MVVM.Services.Implementations
{
    public class PopupService : IPopupService
    {

        public void DisplayAlertPopup(string title, string message, string okButtonText, string canelButtonText)
        {
            throw new NotImplementedException();
        }

        public Task DisplayAlertPopup(string title, string message)
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }

        Task IPopupService.DisplayAlertPopup(string title, string message, string okButtonText, string canelButtonText)
        {
            throw new NotImplementedException();
        }
    }
}
