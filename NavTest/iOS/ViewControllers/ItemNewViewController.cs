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

            this.Title = this.ViewModel.Resources.Title;

            this.titleLabel.Text = this.ViewModel.Resources.ItemTitle;
            this.titleLabel.TextColor = this.ViewModel.Resources.ItemTitleColor.ToUIColor();

            this.descriptionLabel.Text = this.ViewModel.Resources.ItemDescription;
            this.descriptionLabel.TextColor = this.ViewModel.Resources.DescriptionColor.ToUIColor();
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
