using System;
using System.Diagnostics;
using NavTest.Services;
using NavTest.ViewModels.Base;

namespace NavTest.ViewModels.About
{
    internal class AboutController : BaseController<AboutViewModel>
    {
        internal AboutController(BaseRouter router) : base(new AboutViewModel())
        {
            viewModel.ShowWebPage = () =>
            {
                router.ShowWeb("https://google.com");
            };
            this.viewModel.ReleaseModelAction = () =>
            {
                Debug.WriteLine("Released" + this.GetType());
                router.ReleaseConroller(this.GetType());
            };
        }
    }
}
