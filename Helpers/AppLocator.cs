using Autofac;

namespace MAUISampleApp.MVVM.Helpers
{
    public class AppLocator
    {
        public static Autofac.IContainer Container { get; set; }


        protected static void Init(ContainerBuilder builder)
        {
            //RegisterServices(builder);
            //RegisterViewModel(builder);
        }

        private static void RegisterViewModel(ContainerBuilder builder)
        {
            throw new NotImplementedException();
        }

        private static void RegisterServices(ContainerBuilder builder)
        {
            throw new NotImplementedException();
        }
    }
}
