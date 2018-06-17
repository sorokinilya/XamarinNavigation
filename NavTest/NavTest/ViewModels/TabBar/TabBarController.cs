﻿using NavTest.ViewModels.Base;
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
            viewModel.Resources = new TabBarResourcesModel(
                 resourcesService.GetString(LocalizedKey.TB_ListsTitle),
            resourcesService.GetImage(ImageKey.TB_ItemsImage),
             resourcesService.GetImage(ImageKey.TB_SelectedItemsImage),

            resourcesService.GetString(LocalizedKey.TB_AboutTitle),
             resourcesService.GetImage(ImageKey.TB_AboutImage),
            resourcesService.GetImage(ImageKey.TB_SelectedAboutImage),

             resourcesService.GetColor(ColorKey.TB_TextColor),
              resourcesService.GetColor(ColorKey.TB_SelectedTextColor));

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
