using MAUISampleApp.MVVM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MAUISampleApp.MVVM.Services.Implementations
{
    public class PopupService : IPopupService
    {

        public void DisplayAlertPopup(string title, string message, string okButtonText, string canelButtonText)
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
