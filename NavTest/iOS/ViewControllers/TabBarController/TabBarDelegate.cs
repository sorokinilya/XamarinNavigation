using System;
using UIKit;

namespace NavTest.iOS.ViewControllers.TabBarController
{
    public class TabBarDelegate : UITabBarControllerDelegate
    {
        private Action showItems;
        private Action showAbout;

        public TabBarDelegate(Action showItems, Action showAbout)
        {
            this.showItems = showItems;
            this.showAbout = showAbout;
        }

        public override bool ShouldSelectViewController(UITabBarController tabBarController, UIViewController viewController)
        {
            var navigationController = viewController as UINavigationController;
            var vc = navigationController.ViewControllers[0] as BrowseViewController;
            if (vc != null)
            {
                this.showItems();
            }
            else
            {
                this.showAbout();
            }
            return false;
        }
    }
}
