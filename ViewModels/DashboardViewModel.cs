using MAUISampleApp.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public DashboardViewModel()
        {
            CategoryList = new ObservableCollection<DashboardItem>();
            CategoryList.Add(new DashboardItem { ItemName = "Custom UI", Itemicon = "icon.png" });
            CategoryList.Add(new DashboardItem { ItemName = "1 Item", Itemicon = "icon.png" });
            CategoryList.Add(new DashboardItem { ItemName = "2 Item", Itemicon = "icon.png" });
            CategoryList.Add(new DashboardItem { ItemName = "3 Item", Itemicon = "icon.png" });
           
           

        }
    }
}
