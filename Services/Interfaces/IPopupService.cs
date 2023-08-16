using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleApp.MVVM.Services.Interfaces
{
    public interface IPopupService
    {
        void Init();
        Task DisplayAlertPopup(string title, string message);
        Task DisplayAlertPopup(string title, string message, string okButtonText, string canelButtonText);

    }
}
