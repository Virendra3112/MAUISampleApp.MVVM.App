//using CommunityToolkit.Maui;
//using CommunityToolkit.Maui.Core;
//using CommunityToolkit.Maui.Markup;
using MAUISampleApp.MVVM.Handlers;
using MAUISampleApp.MVVM.Services.Implementations;
using MAUISampleApp.MVVM.Services.Interfaces;
using MAUISampleApp.MVVM.ViewModels;
using MAUISampleApp.MVVM.Views;
using MetroLog;
using MetroLog.MicrosoftExtensions;
using MetroLog.Targets;

namespace MAUISampleApp.MVVM;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var config = new LoggingConfiguration();

#if RELEASE
    config.AddTarget(
        LogLevel.Info, 
        LogLevel.Fatal, 
        new StreamingFileTarget(retainDays: 2);
#else
        // Will write logs to the Debug output
        config.AddTarget(
            LogLevel.Trace,
            LogLevel.Fatal,
            new TraceTarget());
#endif

        // will write logs to the console output (Logcat for android)
        config.AddTarget(
            LogLevel.Info,
            LogLevel.Fatal,
            new ConsoleTarget());

        config.AddTarget(
            LogLevel.Info,
            LogLevel.Fatal,
            new MemoryTarget(2048));

        LoggerFactory.Initialize(config);

        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            //.UseMauiCommunityToolkit()
            //.UseMauiCommunityToolkitMarkup()
            //.UseMauiCommunityToolkitCore()
            .UseProgressBar()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        //builder.Logging
        //  .AddTraceLogger(
        //      options =>
        //      {
        //          options.MinLevel = (Microsoft.Extensions.Logging.LogLevel?)LogLevel.Trace;
        //          options.MaxLevel = LogLevel.Critical;
        //      }) // Will write to the Debug Output
        //  .AddInMemoryLogger(
        //      options =>
        //      {
        //          options.MaxLines = 1024;
        //          options.MinLevel = (Microsoft.Extensions.Logging.LogLevel?)LogLevel.Debug;
        //          options.MaxLevel = LogLevel.Critical;
        //      })
        //  .AddStreamingFileLogger(
        //      options =>
        //      {
        //          options.RetainDays = 2;
        //          options.FolderPath = Path.Combine(
        //              FileSystem.CacheDirectory,
        //              "MetroLogs");
        //      });

        //register services
        builder.Services.AddSingleton<IPageNavigationService, PageNavigationService>();
        builder.Services.AddSingleton<ILoggerService, LoggerService>();
        builder.Services.AddSingleton<IPopupService, PopupService>();
        builder.Services.AddSingleton<IHttpService, HttpService>();
        builder.Services.AddSingleton<INetworkService, NetworkService>();

        //register viewmodels
        builder.Services.AddSingleton<BaseViewModel>();

        builder.Services.AddSingleton<DashboardPage>();
        builder.Services.AddSingleton<DashboardViewModel>();

        builder.Services.AddSingleton<CustomNavigationBar>();
        builder.Services.AddSingleton<CustomNavigationBarViewModel>();

        builder.Services.AddSingleton<CustomControlsSamplePage>();
        builder.Services.AddSingleton<CustomControlsSampleViewModel>();


        return builder.Build();
    }


}
