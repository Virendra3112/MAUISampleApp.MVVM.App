using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleApp.MVVM.ViewModels
{
    public class CustomControlsSampleViewModel : BaseViewModel
    {
        private float _progress;
        public float Progress
        {
            get { return _progress; }
            set { _progress = value; OnPropertyChanged(); }
        }
        public CustomControlsSampleViewModel()
        {

        }
    }
}
