using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCrossRefitTest.Core;
using UIKit;

namespace MvvmCrossRefitTest.iOS
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
