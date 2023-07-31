using MAUISampleApp.MVVM.Models;
using MAUISampleApp.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUISampleApp.MVVM.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        private ObservableCollection<DashboardItem> _categoryList;
        public ObservableCollection<DashboardItem> CategoryList
        {
            get { return _categoryList; }
            set { _categoryList = value; OnPropertyChanged(); }
        }

        public ICommand MenuItemCommand { get; set; }

        public DashboardViewModel()
        {
            MenuItemCommand = new Command(MenuSelected);


            CategoryList = new ObservableCollection<DashboardItem>
            {
                new DashboardItem { ItemName = "Custom UI", Itemicon = "icon.png", page = new CustomNavigationBar() },
                new DashboardItem { ItemName = "1 Item", Itemicon = "icon.png" },
                new DashboardItem { ItemName = "2 Item", Itemicon = "icon.png" },
                new DashboardItem { ItemName = "3 Item", Itemicon = "icon.png" }
            };
        }


        private void MenuSelected(object obj)
        {
            try
            {
                if (obj != null)
                {
                    var model = obj as DashboardItem;

                    if (model != null && model.page != null)
                    {
                        NavigateToPage(model.page);
                    }

                    //await PageNavigationService.NavigateTo(new CustomNavigationBar());
                }
            }
            catch (Exception ex)
            { }
        }

        private async void NavigateToPage(Page page)
        {
            try
            {
                await PageNavigationService.NavigateTo(page);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //public async Task<ImageSource> TakeScreenshotAsync()
        //{
        //    if (Screenshot.Default.IsCaptureSupported)
        //    {
        //        IScreenshotResult screen = await Screenshot.Default.CaptureAsync();

        //        Stream stream = await screen.OpenReadAsync();

        //        return ImageSource.FromStream(() => stream);
        //    }

        //    return null;
        //}

    }
}
