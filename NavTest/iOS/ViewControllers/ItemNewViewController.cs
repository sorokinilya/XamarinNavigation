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

            //btnSaveItem.TouchUpInside += (sender, e) =>
            //{
            //    var item = new Item
            //    {
            //        Text = txtTitle.Text,
            //        Description = txtDesc.Text
            //    };
            //    ViewModel.AddItemAction(item);
            //    NavigationController.PopToRootViewController(true);
            //};
        }
    }
}
