using System;
using System.Diagnostics;
using NavTest.iOS.ViewControllers.TabBarController;
using UIKit;

namespace NavTest.iOS
{
    public partial class TabBarViewController : UITabBarController
    {
        private WeakReference<TabBarViewModel> viewModel;

        public TabBarViewModel ViewModel
        {
            get
            {
                TabBarViewModel target;
                if (!viewModel.TryGetTarget(out target))
                {
                    Debug.Assert(false);
                }
                return target;
            }
            set
            {
                this.viewModel = new WeakReference<TabBarViewModel>(value);
            }
        }

        public TabBarViewController(IntPtr handle) : base(handle)
        {
        }

        ~TabBarViewController()
        {
            this.ViewModel.Release();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TabBar.Items[0].Title = ViewModel.resources.browseTitle;
            TabBar.Items[1].Title = ViewModel.resources.aboutTitle;
            this.Delegate = new TabBarDelegate(ViewModel.ShowItems, ViewModel.ShowAbout);
        }
    }
}