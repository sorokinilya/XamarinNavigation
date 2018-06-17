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
            this.viewModel.resources.AboutSelectedImage = resourcesService.GetImage(ImageKey.TB_SelectedAboutImage);

            this.viewModel.resources.ItemsTitle = resourcesService.GetString(LocalizedKey.TB_ListsTitle);
            this.viewModel.resources.ItemsImage = resourcesService.GetImage(ImageKey.TB_ItemsImage);
            this.viewModel.resources.ItemsSelectedImage = resourcesService.GetImage(ImageKey.TB_SelectedItemsImage);

            this.viewModel.resources.TextColor = resourcesService.GetColor(ColorKey.TB_TextColor);
            this.viewModel.resources.SelectedTextColor = resourcesService.GetColor(ColorKey.TB_SelectedTextColor);

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
