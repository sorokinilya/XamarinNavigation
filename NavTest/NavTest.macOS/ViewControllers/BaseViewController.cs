using System;
using System.Diagnostics;
using AppKit;
using NavTest.ViewModels.Base;

namespace NavTest.macOS.ViewControllers
{
        public class BaseViewController<T> : NSViewController
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

        public override void ViewDidDisappear()
        {
            base.ViewDidDisappear();

            Debug.WriteLine("ViewController is disappeared");
            this.ViewModel.ReleaseModelAction();
        }

            ~BaseViewController()
            {
                Debug.WriteLine("ViewController is released");
            }

        }
    }
