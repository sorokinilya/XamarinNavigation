using System;
using System.Diagnostics;
using NavTest.ViewModels.Base;

namespace NavTest
{
    public class BaseViewModel<T> : IBaseViewModel
    {
        public T resources;

        public bool Busy { get; internal set; } = false;

        public Action ReleaseModelAction { get; internal set; }

        protected BaseViewModel(T resources)
        {
            this.resources = resources;
        }

        ~BaseViewModel()
        {
            Debug.WriteLine("BaseViewModel is Released");
        }
    }
}
