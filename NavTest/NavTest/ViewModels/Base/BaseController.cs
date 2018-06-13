using System;
using NavTest.Services;
using NavTest.Services.Resources;

namespace NavTest.ViewModels.Base
{
    public class BaseController<T> where T : class, IBaseViewModel
    {
        public readonly T viewModel;
        protected readonly ResourcesService resourcesService;

        protected BaseController(BaseRouter router, T viewModel)
        {
            this.viewModel = viewModel;
            this.resourcesService = ServiceLayer.Instance.ResourcesService;
            this.viewModel.ShowItems = () =>
            {
                router.ShowItems();
            };
            this.viewModel.ShowAbout = () =>
            {
                router.ShowAbout();
            };

            this.viewModel.ShowNewItem = () =>
            {
                router.ShowNewItem();
            };
            this.viewModel.Release = () =>
            {
                router.ReleaseConroller(this.GetType());
            };
        }
    }
}
