using Autofac;
using MAUISampleApp.MVVM.Services.Implementations;
using MAUISampleApp.MVVM.Services.Interfaces;
using MAUISampleApp.MVVM.ViewModels;

namespace MAUISampleApp.MVVM.Helpers
{
    public class AppBootStrapper : AppLocator
    {
        protected static void Init(ContainerBuilder builder)
        {
            RegisterCommon(builder);
            RegisterAppServices(builder);
            RegisterAppViewModel(builder);
        }

        /// <summary>
        /// Registers the services.
        /// </summary>
        private static void RegisterAppServices(ContainerBuilder containerBuilder)
        {
            var nav = new PageNavigationService();
            CreateNavigationService(nav);
            containerBuilder.Register<IPageNavigationService>(c => nav).SingleInstance();
        }

        private static PageNavigationService CreateNavigationService(PageNavigationService navigationService)
        {
            return navigationService;
        }

        private static void RegisterAppViewModel(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(BaseViewModel).Assembly).InstancePerLifetimeScope().AsImplementedInterfaces().AsSelf().AssignableTo<BaseViewModel>();
        }
    }
}
