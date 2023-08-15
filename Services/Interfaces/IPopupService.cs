using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleApp.MVVM.Services.Interfaces
{
    public interface IPopupService
    {
        void DisplayAlert(string title, string message);
        void DisplayAlert(string title, string message, string okButtonText, string canelButtonText);

    }
}
