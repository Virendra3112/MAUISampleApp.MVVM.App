namespace MAUISampleApp.MVVM.Services.Interfaces
{
    public interface IPageNavigationService
    {
        void GoBack();
        void NavigateTo(Page pageKey);
        void NavigateTo(Page pageKey, object parameter);
        void PopToRoot();
    }
}
