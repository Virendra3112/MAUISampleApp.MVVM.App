namespace MAUISampleApp.MVVM.Services.Interfaces
{
    public interface IPageNavigationService
    {
        Task GoBack();
        Task NavigateTo(Page pageKey);
        Task NavigateTo(Page pageKey, object parameter);
        Task PopToRoot();

        Task InitializeAsync();
        Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null);

    }
}
