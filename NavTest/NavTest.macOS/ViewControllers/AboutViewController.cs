using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using NavTest.ViewModels.About;

namespace NavTest.macOS.ViewControllers
{
    public partial class AboutViewController : BaseViewController<AboutViewModel>
    {
        internal AboutViewController(IntPtr handle) : base(handle)
        {

        }
    }
}
