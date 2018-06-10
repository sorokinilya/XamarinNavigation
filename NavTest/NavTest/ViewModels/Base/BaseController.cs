using System;
using NavTest.Services;

namespace NavTest.ViewModels.Base
{
    public class BaseController<T> where T : class, IBaseViewModel, new()
    {
        public T ViewModel { get; protected set; }

        public BaseController(IRouter router)
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
        }
    }
}
