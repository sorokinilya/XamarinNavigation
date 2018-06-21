using System;
using System.Diagnostics;
using NavTest.iOS.Extension;
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

            TabBar.Items[0].Title = ViewModel.Resources.ItemsTitle;
            TabBar.Items[0].Image = ViewModel.Resources.ItemsImage.ToUIImage();
            TabBar.Items[0].SelectedImage = ViewModel.Resources.ItemsSelectedImage.ToUIImage();

            TabBar.Items[1].Title = ViewModel.Resources.AboutTitle;
            TabBar.Items[1].Image = ViewModel.Resources.AboutImage.ToUIImage();
            TabBar.Items[1].SelectedImage = ViewModel.Resources.ItemsSelectedImage.ToUIImage();

            TabBar.TintColor = ViewModel.Resources.TextColor.ToUIColor();
            TabBar.SelectedImageTintColor = ViewModel.Resources.SelectedTextColor.ToUIColor();
            this.Delegate = new TabBarDelegate(ViewModel.ItemsAction, ViewModel.AboutAction);
        }
    }
}