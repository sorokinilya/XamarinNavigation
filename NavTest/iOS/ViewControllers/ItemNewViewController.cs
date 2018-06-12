using System;
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
            this.ViewModel.AddItem(new Item(txtTitle.Text, txtDesc.Text));
        }
    }
}
