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

            TabBar.Items[0].Title = ViewModel.Resources.itemsTitle;
            TabBar.Items[0].Image = ViewModel.Resources.itemsImage.ToUIImage();
            TabBar.Items[0].SelectedImage = ViewModel.Resources.itemsSelectedImage.ToUIImage();

            TabBar.Items[1].Title = ViewModel.Resources.aboutTitle;
            TabBar.Items[1].Image = ViewModel.Resources.aboutImage.ToUIImage();
            TabBar.Items[1].SelectedImage = ViewModel.Resources.itemsSelectedImage.ToUIImage();

            TabBar.TintColor = ViewModel.Resources.textColor.ToUIColor();
            TabBar.SelectedImageTintColor = ViewModel.Resources.selectedTextColor.ToUIColor();
            this.Delegate = new TabBarDelegate(ViewModel.ItemsAction, ViewModel.AboutAction);
        }
    }
}