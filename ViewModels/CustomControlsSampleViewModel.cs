using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

        public ICommand ProgressCommand { private set; get; }
        public CustomControlsSampleViewModel()
        {
            ProgressCommand = new Command(
            execute: async () =>
            {
                await UpdateProgress();
            });

            ProgressCommand.Execute(null);
        }

        private async Task UpdateProgress()
        {
            //ToDo
            throw new NotImplementedException();
        }
    }
}
