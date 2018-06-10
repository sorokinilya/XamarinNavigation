using System;
using NavTest.iOS.ViewControllers.TabBarController;
using UIKit;

namespace NavTest.iOS
{
    public partial class TabBarViewController : UITabBarController
    {
        internal TabBarViewModel ViewModel { get; set; }

        public TabBarViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TabBar.Items[0].Title = ViewModel.UIModel.browseTitle;
            TabBar.Items[1].Title = ViewModel.UIModel.aboutTitle;
        }
    }
}