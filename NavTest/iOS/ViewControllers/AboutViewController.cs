using System;
using NavTest.iOS.ViewControllers;
using NavTest.ViewModels.About;
using UIKit;

namespace NavTest.iOS
{
    internal partial class AboutViewController : BaseViewController<AboutViewModel>
    {

        internal AboutViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = ViewModel.resources.Title;

            //AppNameLabel.Text = "NavTest";
            //VersionLabel.Text = "1.0";
            //AboutTextView.Text = "This app is written in C# and native APIs using the Xamarin Platform. It shares code with its iOS, Android, & Windows versions.";
        }

        partial void ReadMoreButton_TouchUpInside(UIButton sender) => this.ViewModel.ShowWebPage();
    }
}
