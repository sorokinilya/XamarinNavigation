using System;
using NavTest.Services;

namespace NavTest.ViewModels.Base
{
    public class BaseController<T> where T : class, IBaseViewModel
    {
        public T ViewModel { get; protected set; }

        public BaseController(IRouter router, T viewModel = null)
        {
            this.ViewModel = viewModel;

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
