using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using MvvmCrossRefitTest.Core.ViewModels.Main;
using UIKit;

namespace MvvmCrossRefitTest.iOS.Views.Main
{
    [MvxFromStoryboard(nameof(MainViewController))]
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class MainViewController : BaseViewController<MainViewModel>
    {
        public MainViewController(IntPtr handle) : base(handle)
        {
        }
    }
}
