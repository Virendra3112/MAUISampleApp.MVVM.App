using MAUISampleApp.MVVM.Services.Interfaces;

namespace MAUISampleApp.MVVM.Services.Implementations
{
    public class PageNavigationService : IPageNavigationService
    {
        private readonly Dictionary<string, Type> _pageKeyDictionary;

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

        public PageNavigationService()
        {
            _pageKeyDictionary = new Dictionary<string, Type>();
        }

        public Task GoBack()
        {
            if (Navigation.NavigationStack.Count > 1)
                return Navigation.PopAsync();

            throw new InvalidOperationException("No pages to navigate back to!");
        }

        public async Task NavigateTo(Page page)
        {
            await Navigation.PushAsync(page);
        }

        public Task NavigateTo(Page pageKey, object parameter)
        {
            throw new Exception();
        }

        public Task PopToRoot()
        {
            if (Navigation.NavigationStack.Count > 1)
                return Navigation.PopToRootAsync();

            throw new InvalidOperationException("No pages to navigate back to!");
        }

        public void Configure(string pageKey, Type pageType)
        {
            lock (_pageKeyDictionary)
            {
                if (_pageKeyDictionary.ContainsKey(pageKey))
                {
                    _pageKeyDictionary[pageKey] = pageType;
                }
                else
                {
                    _pageKeyDictionary.Add(pageKey, pageType);
                }
            }
        }

        public Task InitializeAsync()
        {
            throw new NotImplementedException();
        }

        public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
        {
            throw new NotImplementedException();
        }
    }
}
