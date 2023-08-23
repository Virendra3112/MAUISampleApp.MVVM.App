using MAUISampleApp.MVVM.CustomControls;
using SkiaSharp.Views.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
