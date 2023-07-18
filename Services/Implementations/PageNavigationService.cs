using MAUISampleApp.MVVM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleApp.MVVM.Services.Implementations
{
    public class PageNavigationService : IPageNavigationService
    {
        public string CurrentPageKey { get; set; }

        protected INavigation Navigation
        {
            get
            {
                INavigation? navigation = Application.Current?.MainPage?.Navigation;
                if (navigation is not null)
                    return navigation;

                else return null;

            }
        }

        public Task GoBack()
        {
            if (Navigation.NavigationStack.Count > 1)
                return Navigation.PopAsync();

            throw new InvalidOperationException("No pages to navigate back to!");
        }

        public async void NavigateTo(Page pageKey)
        {
            await Navigation.PushAsync(pageKey);
        }

        public void NavigateTo(Page pageKey, object parameter)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Debugger.Break();
            }
        }

        public void PopToRoot()
        {
            throw new NotImplementedException();
        }
    }

    public interface IModalPage { }
}
