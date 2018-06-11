using NavTest.Services;
using NavTest.ViewModels.Base;

namespace NavTest.ViewModels.Items
{
    internal class ItemsController : BaseController<ItemsViewModel>
    {

        // private DataStore DataStore { get; set; } = ServiceLayer.Instance.DataStore;

        internal ItemsController(BaseRouter router) : base(router)
        {

        }
    }
}
