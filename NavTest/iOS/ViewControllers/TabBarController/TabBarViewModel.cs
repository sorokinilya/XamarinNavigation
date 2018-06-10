using System;
using UIKit;

namespace NavTest.iOS.ViewControllers.TabBarController
{
    public class TabBarViewModel : BaseViewModel<TabBarUIModel>
    {
        public readonly UIViewController browseViewController;
        public readonly UIViewController aboutViewController;

        public TabBarViewModel(UIViewController browseViewController, UIViewController aboutViewController)
        {
            this.browseViewController = browseViewController;
            this.aboutViewController = aboutViewController;
        }
    }
}
