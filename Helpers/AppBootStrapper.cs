using Autofac;
using CommonServiceLocator;
using MAUISampleApp.MVVM.Services.Implementations;
using MAUISampleApp.MVVM.Services.Interfaces;
using MAUISampleApp.MVVM.ViewModels;
using MAUISampleApp.MVVM.Views;

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
            navigationService.Configure(nameof(DashboardPage), typeof(DashboardPage));

            return navigationService;
        }

        private static void RegisterAppViewModel(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(BaseViewModel).Assembly).InstancePerLifetimeScope().AsImplementedInterfaces().AsSelf().AssignableTo<BaseViewModel>();
        }
    }
}
