using System;
using NavTest.Services;
using NavTest.ViewModels.About;
using NavTest.ViewModels.ItemDetail;
using NavTest.ViewModels.ItemNew;
using NavTest.ViewModels.Items;

namespace NavTest.Droid
{
    public class Router : BaseRouter
    {
        public Router()
        {
        }

        public override void Initialize()
        {
            throw new NotImplementedException();
        }

        public override void ShowWeb(string url)
        {
            throw new NotImplementedException();
        }

        protected override void ShowAbout(AboutViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        protected override void ShowItemDetail(ItemDetailViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        protected override void ShowItems(ItemsViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        protected override void ShowNewItem(AddItemViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}