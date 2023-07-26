using MAUISampleApp.MVVM.Services.Implementations;
using MAUISampleApp.MVVM.Services.Interfaces;
using MAUISampleApp.MVVM.ViewModels;

namespace MAUISampleApp.MVVM;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//register services
		builder.Services.AddSingleton<IPageNavigationService, PageNavigationService>();

		//register viewmodels
		builder.Services.AddTransient<DashboardViewModel>();

		return builder.Build();
	}
}
