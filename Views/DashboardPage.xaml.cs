using MAUISampleApp.MVVM.ViewModels;

namespace MAUISampleApp.MVVM.Views;

public partial class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        InitializeComponent();
        BindingContext = new DashboardViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }
}