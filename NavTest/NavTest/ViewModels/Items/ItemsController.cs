using NavTest.Services;
using NavTest.ViewModels.Base;

namespace NavTest.ViewModels.Items
{
    public class ItemsController : BaseController<ItemsViewModel>
    {
        public ItemsController(IRouter router) : base(router, new ItemsViewModel())
        {

        }
    }
}
