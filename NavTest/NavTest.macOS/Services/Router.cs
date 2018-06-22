using System;
using AppKit;
using NavTest.macOS.ViewControllers;
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

        internal override void Initialize()
        {
            this.ShowItems();
        }

        protected override void ShowWeb(string url)
        {
            // throw new NotImplementedException();
        }

        protected override void ShowAbout(AboutViewModel viewModel)
        {
            var viewController = this.storyboard.InstantiateControllerWithIdentifier("AboutViewController") as AboutViewController;
            viewController.ViewModel = viewModel;
            this.rootViewController.PresentViewControllerAsModalWindow(viewController);
        }

        protected override void ShowItems(ItemsViewModel viewModel)
        {
            // throw new NotImplementedException();
        }

        protected override void ShowNewItem(AddItemViewModel viewModel)
        {
            // throw new NotImplementedException();
        }

        protected override void ShowItemDetails(ItemDetailsViewModel viewModel)
        {
            //throw new NotImplementedException();
        }
    }
}
