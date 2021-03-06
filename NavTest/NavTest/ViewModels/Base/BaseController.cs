﻿
namespace NavTest.ViewModels.Base
{
    public class BaseController<T> where T : class, IBaseViewModel
    {
        public readonly T viewModel;

        protected BaseController(T viewModel)
        {
            this.viewModel = viewModel;
        }
    }
}
