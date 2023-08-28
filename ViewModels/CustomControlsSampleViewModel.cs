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
            try
            {
                await Task.Delay(100);
                Progress = 0.1f;
                
                await Task.Delay(100);
                Progress = 0.2f;
                
                await Task.Delay(100);
                Progress = 0.3f;
                
                await Task.Delay(100);
                Progress = 0.4f;
                
                await Task.Delay(100);
                Progress = 0.6f;
                
                await Task.Delay(100);
                Progress = 0.8f;
                
                await Task.Delay(100);
                Progress = 1.0f;
            }
            catch(Exception ex)
            {

            }
        }
    }
}
