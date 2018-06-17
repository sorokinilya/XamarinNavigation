using System;
using AppKit;
using NavTest.Services;
using NavTest.ViewModels.About;
using NavTest.ViewModels.ItemDetail;
using NavTest.ViewModels.ItemNew;
using NavTest.ViewModels.Items;

namespace NavTest.macOS.Services
{
    public class Router : BaseRouter
    {
        private readonly NSViewController rootViewController;
        private readonly NSStoryboard storyboard;

        public Router(NSViewController rootViewController)
        {
            this.rootViewController = rootViewController;
            this.storyboard = NSStoryboard.FromName("Main", null);
        }

        public override void Initialize()
        {
           // throw new NotImplementedException();
        }

        public override void ShowWeb(string url)
        {
           // throw new NotImplementedException();
        }

        protected override void ShowAbout(AboutViewModel viewModel)
        {
            var viewController = this.storyboard.InstantiateControllerWithIdentifier("AboutViewController") as NSViewController;
            this.rootViewController.PresentViewController(viewController, null);
          //  throw new NotImplementedException();
        }

        protected override void ShowItemDetail(ItemDetailViewModel viewModel)
        {
          //  throw new NotImplementedException();
        }

        protected override void ShowItems(ItemsViewModel viewModel)
        {
           // throw new NotImplementedException();
        }

        protected override void ShowNewItem(AddItemViewModel viewModel)
        {
           // throw new NotImplementedException();
        }
    }
}
