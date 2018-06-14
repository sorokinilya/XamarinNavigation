using NavTest.ViewModels.Base;
using NavTest.Services;
using UIKit;
using System.Diagnostics;

namespace NavTest.ViewModels.TabBar
{
    internal class TabBarController : BaseController<TabBarViewModel>
    {
        internal TabBarController(BaseRouter router) : base(new TabBarViewModel())
        {
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
