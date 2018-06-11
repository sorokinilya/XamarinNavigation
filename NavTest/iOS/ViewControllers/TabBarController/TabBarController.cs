using NavTest.ViewModels.Base;
using NavTest.Services;
using UIKit;

namespace NavTest.iOS.ViewControllers.TabBarController
{
    internal class TabBarController : BaseController<TabBarViewModel>
    {
        internal TabBarController(BaseRouter router) : base(router)
        {
        }
    }
}
