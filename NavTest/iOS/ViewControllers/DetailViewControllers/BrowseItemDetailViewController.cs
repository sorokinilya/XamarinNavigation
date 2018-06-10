using System;
using NavTest.iOS.ViewControllers;
using NavTest.ViewModels.Items;
using UIKit;

namespace NavTest.iOS
{
    public partial class BrowseItemDetailViewController : BaseViewController<ItemsViewModel>
    {
        public BrowseItemDetailViewController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

        }
    }
}
