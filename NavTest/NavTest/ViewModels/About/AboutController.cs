using System;
using NavTest.Services;
using NavTest.ViewModels.Base;

namespace NavTest.ViewModels.About
{
    internal class AboutController : BaseController<AboutViewModel>
    {
        internal AboutController(BaseRouter router) : base(router, new AboutViewModel())
        {
            ViewModel.ShowWebPage = () =>
            {
                router.ShowWeb("https://google.com");
            };
        }
    }
}
