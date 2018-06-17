using System;
using NavTest.iOS.Extension;
using NavTest.iOS.ViewControllers;
using NavTest.ViewModels.ItemNew;
using UIKit;

namespace NavTest.iOS
{
    internal partial class ItemNewViewController : BaseViewController<AddItemViewModel>
    {

        internal ItemNewViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.Title = this.ViewModel.Resources.title;

            this.titleLabel.Text = this.ViewModel.Resources.itemTitle;
            this.titleLabel.TextColor = this.ViewModel.Resources.titleColor.ToUIColor();

            this.descriptionLabel.Text = this.ViewModel.Resources.itemDescription;
            this.descriptionLabel.TextColor = this.ViewModel.Resources.descriptionColor.ToUIColor();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            this.btnSaveItem.TouchUpInside += this.HandleAddButton;
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);

            this.btnSaveItem.TouchUpInside -= this.HandleAddButton;
        }

        private void HandleAddButton(object sender, EventArgs ea)
        {
            this.ViewModel.SaveItem(new Item(txtTitle.Text, txtDesc.Text));
        }
    }
}
