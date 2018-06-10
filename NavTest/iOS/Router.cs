using System;
using NavTest.iOS.ViewControllers.TabBarController;
using NavTest.Services;
using NavTest.ViewModels.About;
using NavTest.ViewModels.Items;
using UIKit;

namespace NavTest.iOS
{
    public class Router : IRouter
    {
        private readonly UITabBarController tabBarController;

        private readonly UIStoryboard mainStoryboard = UIStoryboard.FromName("Main", null);

        public Router(TabBarViewController tabBarController)
        {
            this.tabBarController = tabBarController;
            var items = this.makeItemsViewController();
            var about = this.makeAboutViewController();
            var controller = new TabBarController(this, this.makeNavigationController(items), makeNavigationController(about));
            tabBarController.ViewModel = controller.ViewModel;
        }

        public void ShowItems()
        {
            this.tabBarController.SelectedIndex = 0;
            var navigationController = tabBarController.SelectedViewController as UINavigationController;
            navigationController.PopToRootViewController(false);
        }

        public void ShowNewItem()
        {
            this.tabBarController.SelectedIndex = 0;
            var navigationController = tabBarController.SelectedViewController as UINavigationController;
            if (this.PopToViewController(navigationController, typeof(ItemNewViewController), true) == false)
            {

            }
        }

        public void ShowAbout()
        {
            this.tabBarController.SelectedIndex = 1;
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

        private BrowseViewController makeItemsViewController()
        {
            var viewController = this.mainStoryboard.InstantiateViewController("BrowseViewController") as BrowseViewController;
            viewController.ViewModel = new ItemsViewModel();
            return viewController;
        }

        private AboutViewController makeAboutViewController()
        {
            var viewController = this.mainStoryboard.InstantiateViewController("AboutViewController") as AboutViewController;
            viewController.ViewModel = new AboutViewModel();
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
