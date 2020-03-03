using LeakCanaryTest.ViewModels;
using MvvmCross.Platform.IoC;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace LeakCanaryTest
{
    public class App : MvxApplication
    {

        //public App()
        //{
        //    Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<HomeViewModel>());
        //}
        public override void Initialize()
        {
            base.Initialize();
            InitialisePlugins();
            InitaliseServices();
            InitialiseStartNavigation();
        }

        private void InitaliseServices()
        {
            CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();
        }

        private void InitialiseStartNavigation()
        {
            //RegisterAppStart<HomeViewModel>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<HomeViewModel>());
        }

        private void InitialisePlugins()
        {
            // initialise any plugins where are required at app startup
            // e.g. MvvmCross.Plugins.Visibility.PluginLoader.Instance.EnsureLoaded();
        }
    }
    
}
