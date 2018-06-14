using System;
using System.Diagnostics;
using NavTest.iOS.ViewControllers.TabBarController;
using NavTest.ViewModels.TabBar;
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
            this.ViewModel.ReleaseModelAction();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TabBar.Items[0].Title = ViewModel.resources.BrowseTitle;
            TabBar.Items[1].Title = ViewModel.resources.AboutTitle;
            this.Delegate = new TabBarDelegate(ViewModel.ItemsAction, ViewModel.AboutAction);
        }
    }
}