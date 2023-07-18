namespace MAUISampleApp.MVVM.Services.Interfaces
{
    public interface IPageNavigationService
    {
        Task GoBack();
        Task NavigateTo(Page pageKey);
        Task NavigateTo(Page pageKey, object parameter);
        Task PopToRoot();
    }
}
