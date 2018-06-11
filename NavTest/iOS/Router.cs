using System;
using NavTest.iOS.ViewControllers.TabBarController;
using NavTest.Services;
using NavTest.ViewModels.About;
using NavTest.ViewModels.Items;
using UIKit;
using Foundation;
using NavTest.ViewModels.ItemNew;

namespace NavTest.iOS
{
    public class Router : IRouter
    {
        private readonly TabBarViewController tabBarController;

        private readonly UIStoryboard mainStoryboard = UIStoryboard.FromName("Main", null);

        public Router(TabBarViewController tabBarController)
        {
            this.tabBarController = tabBarController;
        }

        public void Initialize()
        {
            var controller = new TabBarController(this);
            this.tabBarController.ViewModel = controller.ViewModel;
            var items = this.makeItemsViewController();
            var about = this.makeAboutViewController();
            UIViewController[] controllers = { this.makeNavigationController(items), makeNavigationController(about) };
            this.tabBarController.ViewControllers = controllers;
        }

        public void ShowItems()
        {
            var selected = this.tabBarController.SelectedIndex == 0;
            if (!selected)
            {
                this.tabBarController.SelectedIndex = 0;
            }
            var navigationController = tabBarController.SelectedViewController as UINavigationController;
            navigationController.PopToRootViewController(selected);
        }

        public void ShowNewItem()
        {
            var selected = this.tabBarController.SelectedIndex == 0;
            if (!selected)
            {
                this.tabBarController.SelectedIndex = 0;
            }
            var navigationController = tabBarController.SelectedViewController as UINavigationController;
            if (this.PopToViewController(navigationController, typeof(ItemNewViewController), selected) == false)
            {
                navigationController.PopToRootViewController(false);
                navigationController.PushViewController(this.makeItemNewViewController(), selected);
            }
        }

        public void ShowAbout()
        {
            var selected = this.tabBarController.SelectedIndex == 1;
            if (!selected)
            {
                this.tabBarController.SelectedIndex = 1;
            }
            var navigationController = tabBarController.SelectedViewController as UINavigationController;
            navigationController.PopToRootViewController(selected);
        }

        public void ShowWeb(string url)
        {
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

        private UIViewController makeItemNewViewController()
        {
            var viewController = this.mainStoryboard.InstantiateViewController("ItemNewViewController") as ItemNewViewController;
            var controller = new AddItemController(this);
            viewController.controller = controller;
            viewController.ViewModel = controller.ViewModel;
            return viewController;
        }

        private UIViewController makeItemsViewController()
        {
            var viewController = this.mainStoryboard.InstantiateViewController("BrowseViewController") as BrowseViewController;
            var controller = new ItemsController(this);
            viewController.controller = controller;
            viewController.ViewModel = controller.ViewModel;
            return viewController;
        }

        private UIViewController makeAboutViewController()
        {
            var viewController = this.mainStoryboard.InstantiateViewController("AboutViewController") as AboutViewController;
            var controller = new AboutController(this);
            viewController.controller = controller;
            viewController.ViewModel = controller.ViewModel;
            return viewController;
        }

        private UINavigationController makeNavigationController(UIViewController rootViewController)
        {
            var viewController = this.mainStoryboard.InstantiateViewController("NavigationController") as UINavigationController;
            UIViewController[] viewControllers = { rootViewController };
            viewController.ViewControllers = viewControllers;
            return viewController;
        }
    }
}
