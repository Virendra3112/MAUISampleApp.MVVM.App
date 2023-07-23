using Autofac;

namespace MAUISampleApp.MVVM.Helpers
{
    public class AppLocator
    {
        public static Autofac.IContainer Container { get; set; }


        protected static void RegisterCommon(ContainerBuilder builder)
        {
            RegisterServices(builder);
        }


        private static void RegisterServices(ContainerBuilder containerBuilder)
        {

        }
    }
}
