using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using MvvmCrossRefitTest.Core.ViewModels.Main;

namespace MvvmCrossRefitTest.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<MainViewModel>();
        }
    }
}
