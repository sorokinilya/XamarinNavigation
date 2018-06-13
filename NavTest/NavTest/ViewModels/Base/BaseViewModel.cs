using System;
using NavTest.ViewModels.Base;

namespace NavTest
{
    public class BaseViewModel<T> : IBaseViewModel
    {
        public T resources;

        public bool IsLoading { get; set; }

        public Action ShowItems { get; set; }
        public Action ShowAbout { get; set; }
        public Action ShowNewItem { get; set; }
        public Action ReleaseModel { get; set; }

        protected BaseViewModel(T resources)
        {
            this.resources = resources;
        }
        //~BaseViewModel()
        //{
        //    var a = 10;
        //}
    }
}
