using System;
using NavTest.iOS.ViewControllers;
using NavTest.ViewModels.ItemDetail;
using UIKit;

namespace NavTest.iOS
{
    public partial class BrowseItemDetailViewController : BaseViewController<ItemDetailsViewModel>
    {
        public BrowseItemDetailViewController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.Load();
        }

        private void Load()
        {
            this.ItemNameLabel.Text = this.ViewModel.Item.Text;
            this.ItemDescriptionLabel.Text = this.ViewModel.Item.Text;
        }
    }
}
