using Autofac;
using MAUISampleApp.MVVM.Helpers;

namespace MAUISampleApp.MVVM.Platforms.Android.Helpers
{
    public class AndroidLocator : AppLocator
    {
        public static void Initialize()
        {
            var builder = new ContainerBuilder();
            Init(builder);

            Container = builder.Build();
            builder = null;
        }
    }
}
