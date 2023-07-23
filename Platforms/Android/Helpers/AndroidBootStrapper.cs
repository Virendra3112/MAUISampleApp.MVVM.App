using Autofac;
using MAUISampleApp.MVVM.Helpers;

namespace MAUISampleApp.MVVM.Platforms.Android.Helpers
{
    public class AndroidBootStrapper : AppBootStrapper
    {
        public static void Initialize()
        {
            var builder = new ContainerBuilder();
            AppBootStrapper.Init(builder);

            RegisterAppHelpers(builder);
            RegisterAppServices(builder);

            Container = builder.Build();
#pragma warning disable S1854 // Dead stores should be removed
            builder = null;
#pragma warning restore S1854 // Dead stores should be removed
        }

        private static void RegisterAppHelpers(ContainerBuilder builder)
        {
            //RegisterHelpers
        }

        private static void RegisterAppServices(ContainerBuilder builder)
        {
            //register services
        }
    }
}
