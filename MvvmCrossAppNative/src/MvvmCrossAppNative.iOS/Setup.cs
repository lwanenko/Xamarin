using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCrossAppNative.Core;
using UIKit;

namespace MvvmCrossAppNative.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        protected override IMvxApplication CreateApp()
            => new App();
    }
}
