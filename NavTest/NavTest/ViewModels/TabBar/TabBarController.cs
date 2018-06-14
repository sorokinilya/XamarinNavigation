using NavTest.ViewModels.Base;
using NavTest.Services;
using System.Diagnostics;
using NavTest.Services.Resources;

namespace NavTest.ViewModels.TabBar
{
    internal class TabBarController : BaseController<TabBarViewModel>
    {
        internal TabBarController(BaseRouter router) : base(new TabBarViewModel())
        {
            this.viewModel.resources.AboutTitle = this.resourcesService.GetString(Localized.TB_AboutTitle);
            this.viewModel.resources.BrowseTitle = this.resourcesService.GetString(Localized.TB_LitstTitle);
            this.viewModel.ItemsAction = () =>
            {
                router.ShowItems();
            };
            this.viewModel.AboutAction = () =>
            {
                router.ShowAbout();
            };
            this.viewModel.ReleaseModelAction = () =>
            {
                Debug.WriteLine("Released" + this.GetType());
                router.ReleaseConroller(this.GetType());
            };
        }
    }
}
