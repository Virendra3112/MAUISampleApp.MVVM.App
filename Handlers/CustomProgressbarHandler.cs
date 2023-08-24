using MAUISampleApp.MVVM.CustomControls;
using SkiaSharp.Views.Maui.Handlers;

namespace MAUISampleApp.MVVM.Handlers
{
    public static class CustomProgressbarHandler
    {
        public static MauiAppBuilder UseProgressBar(this MauiAppBuilder builder)
        {
            builder.ConfigureMauiHandlers(h =>
            {
                h.AddHandler<CustomProgressBar, SKCanvasViewHandler>();
            });

            return builder;
        }
    }
}
