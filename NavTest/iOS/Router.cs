﻿using System;
using NavTest.iOS.ViewControllers.TabBarController;
using NavTest.Services;
using NavTest.ViewModels.About;
using NavTest.ViewModels.Items;
using UIKit;
using Foundation;
using NavTest.ViewModels.ItemNew;
using System.Diagnostics.Contracts;

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

        public override void Initialize()
        {
            var controller = this.GetController(() => new TabBarController(this));
            this.tabBarController.ViewModel = controller.ViewModel;
            UIViewController[] controllers = { this.makeNavigationController(), this.makeNavigationController() };
            this.tabBarController.ViewControllers = controllers;
        }

        protected override void ShowItems(ItemsViewModel viewModel)
        {
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

        public override void ShowWeb(string url)
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

        private UINavigationController makeNavigationController()
        {
            var viewController = this.mainStoryboard.InstantiateViewController("NavigationController") as UINavigationController;
            return viewController;
        }
    }
}
