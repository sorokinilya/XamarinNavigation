using System;
using UIKit;
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

        public override void DidMoveToParentViewController(UIViewController parent)
        {
            base.DidMoveToParentViewController(parent);

            if (parent == null)
            {
                Debug.WriteLine("ViewController is removed from parrent");
                this.ViewModel.ReleaseModelAction();
            }
        }

        ~BaseViewController()
        {
            Debug.WriteLine("ViewController is released");
        }

    }
}
