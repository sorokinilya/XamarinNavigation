using System;
using NavTest.Services;
using NavTest.Services.Resources;

namespace NavTest.ViewModels.Base
{
    public class BaseController<T> where T : class, IBaseViewModel
    {
        public readonly T viewModel;
        protected readonly BaseResourcesService resourcesService;

        protected BaseController(T viewModel)
        {
            this.viewModel = viewModel;
            this.resourcesService = ServiceLayer.Instance.ResourcesService;
        }
    }
}
