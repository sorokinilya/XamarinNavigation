using System;
using UIKit;
using NavTest;
using NavTest.ViewModels.Base;

namespace NavTest.iOS.ViewControllers
{
    public class BaseViewController<T> : UIViewController
        where T : IBaseViewModel
    {
        public T ViewModel { get; set; }

        internal object controller { get; set; }

        protected BaseViewController(IntPtr handle) : base(handle)
        {
        }
    }
}
