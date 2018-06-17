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
            var resourcesService = ServiceLayer.Instance.ResourcesService;
            this.viewModel.resources.AboutTitle = resourcesService.GetString(LocalizedKey.TB_AboutTitle);
            this.viewModel.resources.AboutImage = resourcesService.GetImage(ImageKey.TB_AboutImage);

            this.viewModel.resources.BrowseTitle = resourcesService.GetString(LocalizedKey.TB_ListsTitle);
            this.viewModel.resources.BrowseImage = resourcesService.GetImage(ImageKey.TB_ListsImage);
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
