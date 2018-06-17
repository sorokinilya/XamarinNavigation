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
            var resourcesService = ServiceLayer.Instance.ResourcesService;
            viewModel.Resources = new AboutResourcesModel(resourcesService.GetString(Services.Resources.LocalizedKey.A_Title));
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
