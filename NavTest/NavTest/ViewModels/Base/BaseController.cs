using System;
using NavTest.Services;

namespace NavTest.ViewModels.Base
{
    public class BaseController<T> where T : class, IBaseViewModel, new()
    {
        public T ViewModel { get; protected set; }

        protected BaseController(BaseRouter router)
        {
            this.ViewModel = new T();

            this.ViewModel.ShowItems = () =>
            {
                router.ShowItems();
            };
            this.ViewModel.ShowAbout = () =>
            {
                router.ShowAbout();
            };

            this.ViewModel.ShowNewItem = () =>
            {
                router.ShowNewItem();
            };
            this.ViewModel.Release = () =>
            {
                router.ReleaseConroller(this.GetType());
            };
        }
    }
}
