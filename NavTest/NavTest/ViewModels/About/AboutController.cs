using System;
using NavTest.Services;
using NavTest.ViewModels.Base;

namespace NavTest.ViewModels.About
{
    public class AboutController : BaseController<AboutViewModel>
    {
        public AboutController(IRouter router) : base(router)
        {
            ViewModel.ShowWebPage = () =>
            {
                router.ShowWeb("https://google.com");
            };
        }
    }
}
