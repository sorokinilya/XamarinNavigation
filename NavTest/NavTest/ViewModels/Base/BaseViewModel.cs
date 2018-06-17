using System;
using System.Diagnostics;
using NavTest.ViewModels.Base;

namespace NavTest
{
    public class BaseViewModel<T> : IBaseViewModel where T: struct
    {
        public T Resources { get; internal set; }

        public Action ReleaseModelAction { get; internal set; }

        protected BaseViewModel()
        {
        }

        ~BaseViewModel()
        {
            Debug.WriteLine("BaseViewModel is Released");
        }
    }
}
