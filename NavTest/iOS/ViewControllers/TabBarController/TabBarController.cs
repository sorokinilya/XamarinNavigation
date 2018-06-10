using NavTest.ViewModels.Base;
using NavTest.Services;
using UIKit;

namespace NavTest.iOS.ViewControllers.TabBarController
{
    public class TabBarController : BaseController<TabBarViewModel>
    {
        public TabBarController(IRouter router,
                                UIViewController browseViewController,
                                UIViewController aboutViewController) :
        base(router, new TabBarViewModel(browseViewController, aboutViewController))
        {
        }
    }
}
