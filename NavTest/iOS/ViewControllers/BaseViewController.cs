using System;
using UIKit;
using NavTest;
using NavTest.ViewModels.Base;
using System.Diagnostics;

namespace NavTest.iOS.ViewControllers
{
    public class BaseViewController<T> : UIViewController
        where T : class, IBaseViewModel
    {

        private WeakReference<T> viewModel;

        public T ViewModel
        {
            get
            {
                T target;
                if (!viewModel.TryGetTarget(out target))
                {
                    Debug.Assert(false, "ViewModel is released");
                }
                return target;
            }
            set
            {
                this.viewModel = new WeakReference<T>(value);
            }
        }

        protected BaseViewController(IntPtr handle) : base(handle)
        {
        }

        ~BaseViewController()
        {
            Debug.WriteLine("ViewController is released");
            this.ViewModel.ReleaseModelAction();
        }

    }
}
