// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NavTest.iOS
{
	[Register ("ItemNewViewController")]
	partial class ItemNewViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton btnSaveItem { get; set; }

		[Outlet]
		UIKit.UILabel descriptionLabel { get; set; }

		[Outlet]
		UIKit.UILabel titleLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UITextField txtDesc { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UITextField txtTitle { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (descriptionLabel != null) {
				descriptionLabel.Dispose ();
				descriptionLabel = null;
			}

			if (titleLabel != null) {
				titleLabel.Dispose ();
				titleLabel = null;
			}

			if (btnSaveItem != null) {
				btnSaveItem.Dispose ();
				btnSaveItem = null;
			}

			if (txtDesc != null) {
				txtDesc.Dispose ();
				txtDesc = null;
			}

			if (txtTitle != null) {
				txtTitle.Dispose ();
				txtTitle = null;
			}
		}
	}
}
