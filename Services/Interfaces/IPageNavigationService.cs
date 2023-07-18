namespace MAUISampleApp.MVVM.Services.Interfaces
{
    public interface IPageNavigationService
    {
        Task GoBack();
        void NavigateTo(Page pageKey);
        void NavigateTo(Page pageKey, object parameter);
        void PopToRoot();
    }
}
