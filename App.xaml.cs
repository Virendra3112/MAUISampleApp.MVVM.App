using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using MAUISampleApp.MVVM.Helpers;
using Microsoft.Maui.Devices.Sensors;

namespace MAUISampleApp.MVVM;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();



        //if (!ServiceLocator.IsLocationProviderSet)
        //    ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(AppLocator.Container));

        Locator();

        MainPage = new AppShell();

    }

    private async Task Locator()
    {
        try
        {

            await Task.Delay(5000);

            if (!ServiceLocator.IsLocationProviderSet)
                ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(AppLocator.Container));

        }
        catch (Exception ex)
        {

        }

    }
}
