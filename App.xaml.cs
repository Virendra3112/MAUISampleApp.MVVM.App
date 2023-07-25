using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using MAUISampleApp.MVVM.Helpers;

namespace MAUISampleApp.MVVM;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        if (!ServiceLocator.IsLocationProviderSet)
            ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(AppLocator.Container));

        MainPage = new AppShell();

    }
}
