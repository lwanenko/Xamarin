using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using MvvmCrossAppNative.Core.ViewModels;

namespace MvvmCrossAppNative.Core
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
