using System;
using NavTest.Services;
using NavTest.ViewModels.About;
using NavTest.ViewModels.Items;
using UIKit;
using Foundation;
using NavTest.ViewModels.ItemNew;
using System.Diagnostics;
using NavTest.ViewModels.ItemDetail;
using NavTest.ViewModels.TabBar;

namespace NavTest.iOS
{
    public class Router : BaseRouter
    {
        private readonly TabBarViewController tabBarController;

        private readonly UIStoryboard mainStoryboard = UIStoryboard.FromName("Main", null);

        public Router(TabBarViewController tabBarController) : base()
        {
            this.tabBarController = tabBarController;
        }

        internal override void Initialize()
        {
            Debug.Assert(NSThread.IsMain, "Navigation from second thread" + new StackTrace().GetFrame(1).GetMethod().Name);
            var controller = this.GetController(() => new TabBarController());
            this.tabBarController.ViewModel = controller.viewModel;
            UIViewController[] controllers = { this.makeNavigationController(), this.makeNavigationController() };
            this.tabBarController.ViewControllers = controllers;
            this.ShowItems();
        }

        protected override void ShowItems(ItemsViewModel viewModel)
        {
            Debug.Assert(NSThread.IsMain, "Navigation from second thread" + new StackTrace().GetFrame(1).GetMethod().Name);
            var selected = this.tabBarController.SelectedIndex == 0;
            if (!selected)
            {
                this.tabBarController.SelectedIndex = 0;
            }
            var navigationController = tabBarController.SelectedViewController as UINavigationController;
            if (navigationController.ViewControllers.Length == 0)
            {
                var rootViewController = this.mainStoryboard.InstantiateViewController("BrowseViewController") as BrowseViewController;
                rootViewController.ViewModel = viewModel;
                UIViewController[] viewControllers = { rootViewController };
                navigationController.ViewControllers = viewControllers;
            }
            else
            {
                navigationController.PopToRootViewController(selected);
            }
        }

        protected override void ShowAbout(AboutViewModel viewModel)
        {
            Debug.Assert(NSThread.IsMain, "Navigation from second thread" + new StackTrace().GetFrame(1).GetMethod().Name);
            var selected = this.tabBarController.SelectedIndex == 1;
            if (!selected)
            {
                this.tabBarController.SelectedIndex = 1;
            }
            var navigationController = tabBarController.SelectedViewController as UINavigationController;
            if (navigationController.ViewControllers.Length == 0)
            {
                var rootViewController = this.mainStoryboard.InstantiateViewController("AboutViewController") as AboutViewController;
                rootViewController.ViewModel = viewModel;
                UIViewController[] viewControllers = { rootViewController };
                navigationController.ViewControllers = viewControllers;
            }
            else
            {
                navigationController.PopToRootViewController(selected);
            }
        }

        protected override void ShowNewItem(AddItemViewModel viewModel)
        {
            Debug.Assert(NSThread.IsMain, "Navigation from second thread" + new StackTrace().GetFrame(1).GetMethod().Name);
            var selected = this.tabBarController.SelectedIndex == 0;
            if (!selected)
            {
                this.tabBarController.SelectedIndex = 0;
            }
            var navigationController = tabBarController.SelectedViewController as UINavigationController;
            if (this.PopToViewController(navigationController, typeof(ItemNewViewController), selected) == false)
            {
                navigationController.PopToRootViewController(false);
                var viewController = this.mainStoryboard.InstantiateViewController("ItemNewViewController") as ItemNewViewController;
                viewController.ViewModel = viewModel;
                navigationController.PushViewController(viewController, selected);
            }
        }


        protected override void ShowItemDetails(ItemDetailsViewModel viewModel)
        {
            Debug.Assert(NSThread.IsMain, "Navigation from second thread" + new StackTrace().GetFrame(1).GetMethod().Name);
            var selected = this.tabBarController.SelectedIndex == 0;
            if (!selected)
            {
                this.tabBarController.SelectedIndex = 0;
            }
            var navigationController = tabBarController.SelectedViewController as UINavigationController;
            if (this.PopToViewController(navigationController, typeof(BrowseItemDetailViewController), selected) == false)
            {
                navigationController.PopToRootViewController(false);
                var viewController = this.mainStoryboard.InstantiateViewController("BrowseItemDetailViewController") as BrowseItemDetailViewController;
                viewController.ViewModel = viewModel;
                navigationController.PushViewController(viewController, selected);
            }
        }

        protected override void ShowWeb(string url)
        {
            Debug.Assert(NSThread.IsMain, "Navigation from second thread" + new StackTrace().GetFrame(1).GetMethod().Name);
            UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
        }

        private bool PopToViewController(UINavigationController navigationController, Type type, bool animated)
        {
            foreach (var viewController in navigationController.ViewControllers)
            {
                if (viewController.GetType() == type)
                {
                    navigationController.PopToViewController(viewController, animated);
                    return true;
                }
            }
            return false;
        }

        private UINavigationController makeNavigationController()
        {
            var viewController = this.mainStoryboard.InstantiateViewController("NavigationController") as UINavigationController;
            return viewController;
        }
    }
}
