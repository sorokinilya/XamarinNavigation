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
            if (tabBarController.SelectedIndex != 0)
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
